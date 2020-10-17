using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;
using System.Numerics;
using Microsoft.AspNetCore.Http;
using Sodium;
using System.Text;
using System.Timers;

namespace EncryptedChatApplication
{
    public class ChatSpaceModel : PageModel
    {
        private MyOwnMySQLConnection MyOwnMySQLConnectionClass = new MyOwnMySQLConnection();
        public Timer ConfirmationTimer;
        public int Determiner;

        public void OnGet()
        {
            String PrivateKeyString = HttpContext.Session.GetString("PrivateKeyString");
            String ID = HttpContext.Session.GetString("Chat_ID");
            String Current_User = HttpContext.Session.GetString("User_Name");
            if (PrivateKeyString == null || ID == null || Current_User == null) 
            {
                Response.Redirect("ChatDataEntrance");
            }
        }

        public void OnPost() 
        {
            String PrivateKeyString = HttpContext.Session.GetString("PrivateKeyString");
            String ID = HttpContext.Session.GetString("Chat_ID");
            String Current_User = HttpContext.Session.GetString("User_Name");
            String Chat_Message = Request.Form["Chat_Message"];
            String Exception = "";
            Boolean CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
            MySqlCommand MySQLQuery = new MySqlCommand();
            MySqlDataReader PublicKeyStringReader;
            MySqlDataReader RecordReader;
            String PublicKeyString = "";
            BigInteger PrivateKey = 0;
            BigInteger Nonce = 0;
            BigInteger PublicKey = 0;
            BigInteger MessageInt = 0;
            BigInteger SaltInt = 0;
            Byte[] NonceByte = new Byte[] { };
            Byte[] PrivateKeyByte = new Byte[] { };
            Byte[] PublicKeyByte = new Byte[] { };
            Byte[] SharedSecretByte = new Byte[] { };
            Byte[] MessageByte = new Byte[] { };
            Byte[] SaltByte = new Byte[] { };
            Byte[] NewKeyByte = new Byte[] { };
            int Checker = 0;
            int Count = 1;
            long OUTPUT_LENGTH = 32;
            if (Chat_Message != null) 
            {
                MySQLQuery.CommandText = "SELECT COUNT(*) FROM `DF_Public_Key` WHERE `Requestor_1`=@Current_User AND `ID`=@ID";
                MySQLQuery.Parameters.Add("@ID", MySqlDbType.Text).Value = ID;
                MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                Checker = int.Parse(MySQLQuery.ExecuteScalar().ToString());
                if (Checker == 1)
                {
                    MySQLQuery = new MySqlCommand();
                    MySQLQuery.CommandText = "SELECT `Requestor_2_PK` FROM `DF_Public_Key` WHERE `Requestor_1`=@Current_User AND `ID`=@ID";
                    MySQLQuery.Parameters.Add("@ID", MySqlDbType.Text).Value = ID;
                    MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                    MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                    MySQLQuery.Prepare();
                    PublicKeyStringReader = MySQLQuery.ExecuteReader();
                    while (PublicKeyStringReader.Read()) 
                    {
                        PublicKeyString = PublicKeyStringReader.GetValue(0).ToString();
                    }
                    MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                }
                else 
                {
                    MySQLQuery = new MySqlCommand();
                    MySQLQuery.CommandText = "SELECT `Requestor_1_PK` FROM `DF_Public_Key` WHERE `Requestor_2`=@Current_User AND `ID`=@ID";
                    MySQLQuery.Parameters.Add("@ID", MySqlDbType.Text).Value = ID;
                    MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                    MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                    MySQLQuery.Prepare();
                    PublicKeyStringReader = MySQLQuery.ExecuteReader();
                    while (PublicKeyStringReader.Read())
                    {
                        PublicKeyString = PublicKeyStringReader.GetValue(0).ToString();
                    }
                    MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                }
                CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
                PublicKey = BigInteger.Parse(PublicKeyString);
                PublicKeyByte = PublicKey.ToByteArray();
                PrivateKey = BigInteger.Parse(PrivateKeyString);
                PrivateKeyByte = PrivateKey.ToByteArray();
                SharedSecretByte = ScalarMult.Mult(PrivateKeyByte, PublicKeyByte);
                MySQLQuery = new MySqlCommand();
                Checker = 0;
                MySQLQuery.CommandText = "SELECT COUNT(*) FROM `Chat_Message` WHERE `FK_ID`=@ID";
                MySQLQuery.Parameters.Add("@ID", MySqlDbType.Text).Value = ID;
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                Checker = int.Parse(MySQLQuery.ExecuteScalar().ToString());
                if (Checker != 0)
                {
                    MySQLQuery = new MySqlCommand();
                    MySQLQuery.CommandText = "SELECT `Salt` FROM `Chat_Message` WHERE `FK_ID`=@ID";
                    MySQLQuery.Parameters.Add("@ID", MySqlDbType.Text).Value = ID;
                    MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                    MySQLQuery.Prepare();
                    RecordReader = MySQLQuery.ExecuteReader();
                    while (RecordReader.Read()) 
                    {
                        SaltInt = BigInteger.Parse(RecordReader.GetValue(0).ToString());
                        SaltByte = SaltInt.ToByteArray();
                        if (Count == 1)
                        {
                            NewKeyByte = PasswordHash.ArgonHashBinary(SharedSecretByte, SaltByte, PasswordHash.StrengthArgon.Medium, OUTPUT_LENGTH, PasswordHash.ArgonAlgorithm.Argon_2ID13);
                        }
                        else 
                        {
                            NewKeyByte = PasswordHash.ArgonHashBinary(NewKeyByte, SaltByte, PasswordHash.StrengthArgon.Medium, OUTPUT_LENGTH, PasswordHash.ArgonAlgorithm.Argon_2ID13);
                        }
                        Count += 1;
                    }
                }
                if (NewKeyByte.Length == 0)
                {
                    SaltByte = PasswordHash.ArgonGenerateSalt();
                    NewKeyByte = PasswordHash.ArgonHashBinary(SharedSecretByte, SaltByte, PasswordHash.StrengthArgon.Medium, OUTPUT_LENGTH, PasswordHash.ArgonAlgorithm.Argon_2ID13);
                    SaltInt = new BigInteger(SaltByte);
                    NonceByte = SecretBox.GenerateNonce();
                    MessageByte = SecretBox.Create(Encoding.UTF8.GetBytes(Chat_Message), NonceByte, NewKeyByte);
                    MessageInt = new BigInteger(MessageByte);
                    Nonce = new BigInteger(NonceByte);
                }
                else 
                {
                    SaltByte = PasswordHash.ArgonGenerateSalt();
                    NewKeyByte = PasswordHash.ArgonHashBinary(NewKeyByte, SaltByte, PasswordHash.StrengthArgon.Medium, OUTPUT_LENGTH, PasswordHash.ArgonAlgorithm.Argon_2ID13);
                    SaltInt = new BigInteger(SaltByte);
                    NonceByte = SecretBox.GenerateNonce();
                    MessageByte = SecretBox.Create(Encoding.UTF8.GetBytes(Chat_Message), NonceByte, NewKeyByte);
                    MessageInt = new BigInteger(MessageByte);
                    Nonce = new BigInteger(NonceByte);
                }
                MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
                MySQLQuery = new MySqlCommand();
                MySQLQuery.CommandText = "INSERT INTO `Chat_Message`(`FK_ID`,`Message`,`Sender_Name`,`Receiver_Status`,`Salt`,`Nonce`) VALUES (@FK_ID,@Message,@Sender_Name,@Receiver_Status,@Salt,@Nonce)";
                MySQLQuery.Parameters.Add("@FK_ID", MySqlDbType.Text).Value = ID;
                MySQLQuery.Parameters.Add("@Message", MySqlDbType.Text).Value = MessageInt.ToString();
                MySQLQuery.Parameters.Add("@Sender_Name", MySqlDbType.Text).Value = Current_User;
                MySQLQuery.Parameters.Add("@Receiver_Status", MySqlDbType.Text).Value = "Sent";
                MySQLQuery.Parameters.Add("@Salt", MySqlDbType.Text).Value = SaltInt.ToString();
                MySQLQuery.Parameters.Add("@Nonce", MySqlDbType.Text).Value = Nonce.ToString();
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                MySQLQuery.ExecuteNonQuery();
                MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                Determiner = 0;
                if (Determiner == 0 && ConfirmationTimer==null) 
                {
                    SetConfirmationTimer();
                }
            }
        }

        public void OnPostReset() 
        {
            Determiner = 0;
        }

        public void SetConfirmationTimer()
        {
            ConfirmationTimer = new Timer(300000);
            ConfirmationTimer.Elapsed += ConfirmSelectionOnTimer;
            ConfirmationTimer.AutoReset = true;
            ConfirmationTimer.Enabled = true;
        }

        public void ConfirmSelectionOnTimer(Object source, ElapsedEventArgs e)
        {
            String CurrentDeterminerString = HttpContext.Session.GetString("CurrentDeterminerString");
            if (CurrentDeterminerString == null)
            {
                Determiner = 1;
                HttpContext.Session.SetString("CurrentDeterminerString", Determiner.ToString());
            }
            else 
            {
                Determiner = int.Parse(CurrentDeterminerString);
                Determiner += 1;
                HttpContext.Session.SetString("CurrentDeterminerString", Determiner.ToString());
                if (Determiner == 2) 
                {
                    HttpContext.Session.Remove("CurrentDeterminerString");
                    HttpContext.Session.Remove("PrivateKeyString");
                    HttpContext.Session.Remove("Chat_ID");
                    Response.Redirect("ChatDataEntrance");
                }
            }
        }
    }
}