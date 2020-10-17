using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Numerics;
using MySql.Data.MySqlClient;
using Sodium;
using Microsoft.AspNetCore.Http;

namespace EncryptedChatApplication
{
    public class DFKey_CheckModel : PageModel
    {
        private MyOwnMySQLConnection MyOwnMySQLConnectionClass = new MyOwnMySQLConnection();

        public void OnGet()
        {
            String ID = HttpContext.Session.GetString("ID");
            if (ID == null) 
            {
                Response.Redirect("Users");
            }
        }

        public void OnPost() 
        {
            String ID = HttpContext.Session.GetString("ID");
            String Exception = "";
            Boolean CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
            MySqlCommand MySQLQuery = new MySqlCommand();
            MySqlDataReader PublicKeyDBReader;
            int Checker = 0;
            DateTime MyUTCDateTime = DateTime.UtcNow.AddHours(8);
            String PrivateKeyString = Request.Form["SK_Diffie_Hellman"].ToString();
            String Current_User = HttpContext.Session.GetString("User_Name");
            String PublicKeyStringDB = "";
            BigInteger PrivateKey = BigInteger.Parse(PrivateKeyString);
            BigInteger PublicKey = 0;
            Byte[] PrivateKeyBytes = new Byte[] { };
            Byte[] PublicKeyBytes = new Byte[] { };
            PrivateKeyBytes = PrivateKey.ToByteArray();
            PublicKeyBytes = ScalarMult.Base(PrivateKeyBytes);
            PublicKey = new BigInteger(PublicKeyBytes);
            MySQLQuery.CommandText = "SELECT COUNT(*) FROM `DF_Public_Key` WHERE `Requestor_1`=@Current_User AND `ID`=@ID";
            MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
            MySQLQuery.Parameters.Add("@ID", MySqlDbType.Text).Value = ID;
            MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
            MySQLQuery.Prepare();
            Checker = int.Parse(MySQLQuery.ExecuteScalar().ToString());
            if (Checker == 1)
            {
                MySQLQuery = new MySqlCommand();
                MySQLQuery.CommandText = "SELECT `Requestor_1_PK` FROM `DF_Public_Key` WHERE `ID`=@ID";
                MySQLQuery.Parameters.Add("@ID", MySqlDbType.Text).Value = ID;
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                PublicKeyDBReader = MySQLQuery.ExecuteReader();
                while (PublicKeyDBReader.Read()) 
                {
                    PublicKeyStringDB = PublicKeyDBReader.GetValue(0).ToString();
                }
                MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
                MySQLQuery = new MySqlCommand();
                MySQLQuery.CommandText = "UPDATE `DF_Public_Key` SET `Last_Checked_Date_R1`=@Last_Checked_Date_R1,`Requestor_1_PK`=@Requestor_1_PK WHERE `ID`=@ID";
                MySQLQuery.Parameters.Add("@Last_Checked_Date_R1", MySqlDbType.DateTime).Value = MyUTCDateTime;
                MySQLQuery.Parameters.Add("@Requestor_1_PK", MySqlDbType.Text).Value = PublicKey.ToString();
                MySQLQuery.Parameters.Add("@ID", MySqlDbType.Text).Value = ID;
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                MySQLQuery.ExecuteNonQuery();
            }
            else
            {
                MySQLQuery = new MySqlCommand();
                MySQLQuery.CommandText = "SELECT `Requestor_2_PK` FROM `DF_Public_Key` WHERE `ID`=@ID";
                MySQLQuery.Parameters.Add("@ID", MySqlDbType.Text).Value = ID;
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                PublicKeyDBReader = MySQLQuery.ExecuteReader();
                while (PublicKeyDBReader.Read())
                {
                    PublicKeyStringDB = PublicKeyDBReader.GetValue(0).ToString();
                }
                MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
                MySQLQuery = new MySqlCommand();
                MySQLQuery.CommandText = "UPDATE `DF_Public_Key` SET `Last_Checked_Date_R2`=@Last_Checked_Date_R2,`Requestor_2_PK`=@Requestor_2_PK WHERE `ID`=@ID";
                MySQLQuery.Parameters.Add("@Last_Checked_Date_R2", MySqlDbType.DateTime).Value = MyUTCDateTime;
                MySQLQuery.Parameters.Add("@Requestor_2_PK", MySqlDbType.Text).Value = PublicKey.ToString();
                MySQLQuery.Parameters.Add("@ID", MySqlDbType.Text).Value = ID;
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                MySQLQuery.ExecuteNonQuery();
            }
            if (PublicKeyStringDB.CompareTo(PublicKey.ToString()) == 0)
            {
                ViewData["Result"] = "Your public key value hasn't been tampered with..";
            }
            else 
            {
                ViewData["Result"] = "You better watch out someone has modified ur public key value..";
            }
            HttpContext.Session.Remove("ID");
        }
    }
}