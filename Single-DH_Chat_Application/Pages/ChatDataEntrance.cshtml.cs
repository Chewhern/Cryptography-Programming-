using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using MySql.Data.MySqlClient;
using System.Numerics;
using Sodium;

namespace EncryptedChatApplication
{
    public class ChatDataEntranceModel : PageModel
    {
        private MyOwnMySQLConnection MyOwnMySQLConnectionClass = new MyOwnMySQLConnection();

        public void OnGet()
        {

        }

        public void OnPost() 
        {
            String PrivateKeyString = Request.Form["DHSKey"];
            String ID = HttpContext.Session.GetString("Chat_ID");
            String Current_User = HttpContext.Session.GetString("User_Name");
            String Exception = "";
            Boolean CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
            MySqlCommand MySQLQuery = new MySqlCommand();
            MySqlDataReader PublicKeyStringReader;
            String PublicKeyString = "";
            int Checker = 0;
            BigInteger PrivateKey = 0;
            BigInteger PublicKey = 0;
            Byte[] PrivateKeyBytes = new Byte[] { };
            Byte[] PublicKeyBytes = new Byte[] { };
            if (ID != null && PrivateKeyString != null) 
            {
                PrivateKey = BigInteger.Parse(PrivateKeyString);
                MySQLQuery.CommandText = "SELECT COUNT(*) FROM `DF_Public_Key` WHERE `Requestor_1`=@Current_User AND `ID`=@ID";
                MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                MySQLQuery.Parameters.Add("@ID", MySqlDbType.Text).Value = ID;
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                Checker = int.Parse(MySQLQuery.ExecuteScalar().ToString());
                if (Checker == 1)
                {
                    MySQLQuery = new MySqlCommand();
                    MySQLQuery.CommandText = "SELECT `Requestor_1_PK` FROM `DF_Public_Key` WHERE `Requestor_1`=@Current_User AND `ID`=@ID";
                    MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                    MySQLQuery.Parameters.Add("@ID", MySqlDbType.Text).Value = ID;
                    MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                    MySQLQuery.Prepare();
                    PublicKeyStringReader = MySQLQuery.ExecuteReader();
                    while (PublicKeyStringReader.Read())
                    {
                        PublicKeyString = PublicKeyStringReader.GetValue(0).ToString();
                    }
                }
                else 
                {
                    MySQLQuery = new MySqlCommand();
                    MySQLQuery.CommandText = "SELECT `Requestor_2_PK` FROM `DF_Public_Key` WHERE `Requestor_2`=@Current_User AND `ID`=@ID";
                    MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                    MySQLQuery.Parameters.Add("@ID", MySqlDbType.Text).Value = ID;
                    MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                    MySQLQuery.Prepare();
                    PublicKeyStringReader = MySQLQuery.ExecuteReader();
                    while (PublicKeyStringReader.Read())
                    {
                        PublicKeyString = PublicKeyStringReader.GetValue(0).ToString();
                    }
                }
                MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                PrivateKeyBytes = PrivateKey.ToByteArray();
                PublicKeyBytes = ScalarMult.Base(PrivateKeyBytes);
                PublicKey = new BigInteger(PublicKeyBytes);
                if (PublicKeyString.CompareTo(PublicKey.ToString()) == 0)
                {
                    Response.Redirect("ChatSpace");
                    HttpContext.Session.SetString("PrivateKeyString",PrivateKeyString);
                }
                else 
                {
                    ViewData["Result"] = "The private/public key didn't match.. Perhaps try again?";
                }
            }
        }
    }
}