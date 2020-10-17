using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Timers;
using System.Numerics;
using MySql.Data.MySqlClient;
using Sodium;
using Microsoft.AspNetCore.Http;
using System.Text;

namespace EncryptedChatApplication
{
    public class ChatStorageModel : PageModel
    {
        private MyOwnMySQLConnection MyOwnMySQLConnectionClass = new MyOwnMySQLConnection();
        public Timer aTimer;
        public List<String> Message_List = new List<String> { };
        public List<String> Sender_NameList = new List<String> { };
        public List<String> Receiver_StatusList = new List<String> { };
        public int Current_Count = 0;
        public String Other_User = "";
        public String Current_User = "";

        public void OnGet()
        {
            String PrivateKeyString = HttpContext.Session.GetString("PrivateKeyString");
            String PublicKeyString = "";
            String ID = HttpContext.Session.GetString("Chat_ID");
            String Exception = "";
            Boolean CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
            MySqlCommand MySQLQuery = new MySqlCommand();
            MySqlDataReader RecordReader;
            List<BigInteger> MessageIntList = new List<BigInteger> { };
            List<BigInteger> SaltIntList = new List<BigInteger> { };
            List<BigInteger> NonceIntList = new List<BigInteger> { };
            Byte[] CurrentMessageByte = new Byte[] { };
            Byte[] CurrentSaltByte = new Byte[] { };
            Byte[] CurrentNonceByte = new Byte[] { };
            Byte[] PrivateKeyByte = new Byte[] { };
            Byte[] PublicKeyByte = new Byte[] { };
            Byte[] SharedSecretByte = new Byte[] { };
            Byte[] DerivedKeyByte = new Byte[] { };
            Byte[] DecryptedMessageByte = new Byte[] { };
            BigInteger PrivateKey = 0;
            BigInteger PublicKey = 0;
            BigInteger DerivedKeyInt = 0;
            int Loop = 0;
            int Checker = 0;
            long OUTPUT_LENGTH = 32;
            Current_User = HttpContext.Session.GetString("User_Name");
            if (PrivateKeyString != null && ID != null && Current_User!=null) 
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
                    MySQLQuery.CommandText = "SELECT `Requestor_2_PK`,`Requestor_2` FROM `DF_Public_Key` WHERE `Requestor_1`=@Current_User AND `ID`=@ID";
                    MySQLQuery.Parameters.Add("@ID", MySqlDbType.Text).Value = ID;
                    MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                    MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                    MySQLQuery.Prepare();
                    RecordReader = MySQLQuery.ExecuteReader();
                    while (RecordReader.Read())
                    {
                        PublicKeyString = RecordReader.GetValue(0).ToString();
                        Other_User = RecordReader.GetValue(1).ToString();
                    }
                    MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                }
                else
                {
                    MySQLQuery = new MySqlCommand();
                    MySQLQuery.CommandText = "SELECT `Requestor_1_PK`,`Requestor_1` FROM `DF_Public_Key` WHERE `Requestor_2`=@Current_User AND `ID`=@ID";
                    MySQLQuery.Parameters.Add("@ID", MySqlDbType.Text).Value = ID;
                    MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                    MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                    MySQLQuery.Prepare();
                    RecordReader = MySQLQuery.ExecuteReader();
                    while (RecordReader.Read())
                    {
                        PublicKeyString = RecordReader.GetValue(0).ToString();
                        Other_User = RecordReader.GetValue(1).ToString();
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
                MySQLQuery.CommandText = "SELECT COUNT(*) FROM `Chat_Message` WHERE `FK_ID`=@FK_ID";
                MySQLQuery.Parameters.Add("@FK_ID", MySqlDbType.Text).Value = ID;
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                Current_Count = int.Parse(MySQLQuery.ExecuteScalar().ToString());
                MySQLQuery = new MySqlCommand();
                MySQLQuery.CommandText = "UPDATE `Chat_Message` SET `Receiver_Status`=@Receiver_Status WHERE `FK_ID`=@FK_ID AND `Receiver_Status`!=@Receiver_Status AND `Sender_Name`!=@Current_User";
                MySQLQuery.Parameters.Add("@FK_ID", MySqlDbType.Text).Value = ID;
                MySQLQuery.Parameters.Add("@Receiver_Status", MySqlDbType.Text).Value = "Received";
                MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                MySQLQuery.ExecuteNonQuery();
                MySQLQuery = new MySqlCommand();
                MySQLQuery.CommandText = "SELECT `Salt`,`Nonce`,`Message`,`Sender_Name`,`Receiver_Status` FROM `Chat_Message` WHERE `FK_ID`=@FK_ID";
                MySQLQuery.Parameters.Add("@FK_ID", MySqlDbType.Text).Value = ID;
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                RecordReader = MySQLQuery.ExecuteReader();
                while (RecordReader.Read())
                {
                    SaltIntList.Add(BigInteger.Parse(RecordReader.GetValue(0).ToString()));
                    NonceIntList.Add(BigInteger.Parse(RecordReader.GetValue(1).ToString()));
                    MessageIntList.Add(BigInteger.Parse(RecordReader.GetValue(2).ToString()));
                    Sender_NameList.Add(RecordReader.GetValue(3).ToString());
                    Receiver_StatusList.Add(RecordReader.GetValue(4).ToString());
                }
                MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                Loop = 0;
                while (Loop < SaltIntList.Count)
                {
                    CurrentSaltByte = SaltIntList[Loop].ToByteArray();
                    CurrentNonceByte = NonceIntList[Loop].ToByteArray();
                    CurrentMessageByte = MessageIntList[Loop].ToByteArray();
                    if (Loop == 0)
                    {
                        DerivedKeyByte = PasswordHash.ArgonHashBinary(SharedSecretByte, CurrentSaltByte, PasswordHash.StrengthArgon.Medium, OUTPUT_LENGTH, PasswordHash.ArgonAlgorithm.Argon_2ID13);
                    }
                    else 
                    {
                        DerivedKeyByte = PasswordHash.ArgonHashBinary(DerivedKeyByte, CurrentSaltByte, PasswordHash.StrengthArgon.Medium, OUTPUT_LENGTH, PasswordHash.ArgonAlgorithm.Argon_2ID13);
                    }
                    DecryptedMessageByte = SecretBox.Open(CurrentMessageByte, CurrentNonceByte, DerivedKeyByte);
                    Message_List.Add(Encoding.UTF8.GetString(DecryptedMessageByte));
                    Loop += 1;
                }
                HttpContext.Session.SetString("CurrentCount", Current_Count.ToString());
                if (aTimer == null) 
                {
                    SetRefreshTimer();
                }
            }
        }

        public void SetRefreshTimer()
        {
            aTimer = new Timer(1000);
            aTimer.Elapsed += RefreshPageOnNewRecords;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        public void RefreshPageOnNewRecords(Object source, ElapsedEventArgs e)
        {
            String CurrentCountString = HttpContext.Session.GetString("CurrentCount");
            String ID = HttpContext.Session.GetString("Chat_ID");
            int FuncCurrentCount = 0;
            int Checker = 0;
            MySqlCommand MySQLQuery = new MySqlCommand();
            if (CurrentCountString != null) 
            {
                FuncCurrentCount = int.Parse(CurrentCountString);
                MySQLQuery.CommandText = "SELECT COUNT(*) FROM `Chat_Message` WHERE `FK_ID`=@FK_ID";
                MySQLQuery.Parameters.Add("@FK_ID", MySqlDbType.Text).Value = ID;
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                Checker = int.Parse(MySQLQuery.ExecuteScalar().ToString());
                if (Checker > FuncCurrentCount && Checker!=0) 
                {
                    Response.Redirect("ChatStorage");
                }
            }
        }
    }
}