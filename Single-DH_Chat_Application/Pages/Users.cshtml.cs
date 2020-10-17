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
    public class UsersModel : PageModel
    {
        private MyOwnMySQLConnection MyOwnMySQLConnectionClass = new MyOwnMySQLConnection();
        private IDGenerator IDGeneratorClass = new IDGenerator();
        public List<String> UserList = new List<String> { };
        public int UserListCount;
        public String SessionSearchUser;

        public void OnGet()
        {
            String Exception = "";
            String Current_User = HttpContext.Session.GetString("User_Name");
            Boolean CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
            MySqlCommand MySQLQuery = new MySqlCommand();
            MySqlDataReader UserListDataReader;
            SessionSearchUser= HttpContext.Session.GetString("Search_User");
            MySQLQuery.CommandText = "SELECT COUNT(*) FROM `User`";
            MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
            MySQLQuery.Prepare();
            UserListCount = int.Parse(MySQLQuery.ExecuteScalar().ToString());
            MySQLQuery = new MySqlCommand();
            MySQLQuery.CommandText = "SELECT `User_Name` FROM `User` WHERE `User_Name`!=@Current_User LIMIT 50";
            MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;            
            MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
            MySQLQuery.Prepare();
            UserListDataReader = MySQLQuery.ExecuteReader();
            while (UserListDataReader.Read()) 
            {
                UserList.Add(UserListDataReader.GetValue(0).ToString());
            }
            MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
        }

        //Redirect to DFKey_Display
        public void OnPost() 
        {
            KeyPair Current_Requestor_KeyPair = PublicKeyBox.GenerateKeyPair();
            String Exception = "";
            String ID = IDGeneratorClass.GetUniqueString();
            Boolean CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
            MySqlCommand MySQLQuery = new MySqlCommand();
            String Current_User = HttpContext.Session.GetString("User_Name");
            String Chosen_User = Request.Form["Key_Establishment_BTN"];
            BigInteger PublicKeyBigInt = 0;
            BigInteger PrivateKeyBigInt = 0;
            int Checker = 0;
            int Checker2 = 0;
            PublicKeyBigInt = new BigInteger(Current_Requestor_KeyPair.PublicKey);
            PrivateKeyBigInt = new BigInteger(Current_Requestor_KeyPair.PrivateKey);
            MySQLQuery.CommandText = "SELECT COUNT(*) FROM `DF_Public_Key` WHERE `Requestor_1`=@Current_User AND `Requestor_2`=@Chosen_User";
            MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
            MySQLQuery.Parameters.Add("@Chosen_User", MySqlDbType.Text).Value = Chosen_User;
            MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
            MySQLQuery.Prepare();
            Checker = int.Parse(MySQLQuery.ExecuteScalar().ToString());
            MySQLQuery = new MySqlCommand();
            MySQLQuery.Parameters.Clear();
            MySQLQuery.CommandText = "SELECT COUNT(*) FROM `DF_Public_Key` WHERE `Requestor_1`=@Chosen_User AND `Requestor_2`=@Current_User";
            MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
            MySQLQuery.Parameters.Add("@Chosen_User", MySqlDbType.Text).Value = Chosen_User;
            MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
            MySQLQuery.Prepare();
            Checker2 = int.Parse(MySQLQuery.ExecuteScalar().ToString());
            if (Checker == 0 && Checker2 == 0)
            {
                MySQLQuery = new MySqlCommand();
                MySQLQuery.Parameters.Clear();
                MySQLQuery.CommandText = "INSERT INTO `DF_Public_Key`(`Requestor_1`, `Requestor_1_PK`, `Requestor_2`, `Status`, `ID`) VALUES (@Requestor_1, @Requestor_1_PK, @Requestor_2, @Status, @ID)";
                MySQLQuery.Parameters.Add("@ID", MySqlDbType.Text).Value = ID;
                MySQLQuery.Parameters.Add("@Requestor_1", MySqlDbType.Text).Value = Current_User;
                MySQLQuery.Parameters.Add("@Requestor_1_PK", MySqlDbType.Text).Value = PublicKeyBigInt;
                MySQLQuery.Parameters.Add("@Requestor_2", MySqlDbType.Text).Value = Chosen_User;
                MySQLQuery.Parameters.Add("@Status", MySqlDbType.Text).Value = "R1 had created his/her own key pairs";
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                MySQLQuery.ExecuteNonQuery();
                HttpContext.Session.SetString("Chosen_User",Chosen_User);
                HttpContext.Session.SetString("User_PK", PublicKeyBigInt.ToString());
                HttpContext.Session.SetString("User_SK", PrivateKeyBigInt.ToString());
                MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                Response.Redirect("DFKey_Display");
            }
            else if (Checker2 == 1)
            {
                MySQLQuery = new MySqlCommand();
                MySQLQuery.Parameters.Clear();
                MySQLQuery.CommandText = "UPDATE `DF_Public_Key` SET `Requestor_2_PK`=@Requestor_2_PK,`Status`=@Status WHERE `Requestor_1`=@Chosen_User AND `Requestor_2`=@Current_User";
                MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                MySQLQuery.Parameters.Add("@Requestor_2_PK", MySqlDbType.Text).Value = PublicKeyBigInt;
                MySQLQuery.Parameters.Add("@Chosen_User", MySqlDbType.Text).Value = Chosen_User;
                MySQLQuery.Parameters.Add("@Status", MySqlDbType.Text).Value = "R1 & R2 had established keys respectively";
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                MySQLQuery.ExecuteNonQuery();
                HttpContext.Session.SetString("Chosen_User", Chosen_User);
                HttpContext.Session.SetString("User_PK", PublicKeyBigInt.ToString());
                HttpContext.Session.SetString("User_SK", PrivateKeyBigInt.ToString());
                MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                Response.Redirect("DFKey_Display");
            }
            else 
            {
                ViewData["Result"]= "Not Available to create DF key pairs";
                MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
            }
        }

        //Show next records
        public void OnPostNext() 
        {
            String User = HttpContext.Session.GetString("Search_User");
            String OFFSETString = HttpContext.Session.GetString("OFFSET");
            String Exception = "";
            String Current_User = HttpContext.Session.GetString("User_Name");
            Boolean CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
            MySqlCommand MySQLQuery = new MySqlCommand();
            MySqlDataReader UserReader;
            UserList = new List<String> { };
            int OFFSET = 0;
            SessionSearchUser = User;
            if (User != null && OFFSETString != null)
            {
                OFFSET = int.Parse(OFFSETString);
                if (OFFSET == 0)
                {
                    OFFSET += 50;
                }
                MySQLQuery.CommandText = "SELECT `User_Name` FROM `User` WHERE `User_Name`!='@Current_User' AND `User_Name` LIKE '%@Search_User%' LIMIT 50 OFFSET " + OFFSET.ToString();
                MySQLQuery.Parameters.Add("@Search_User", MySqlDbType.Text).Value = User;
                MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                UserReader = MySQLQuery.ExecuteReader();
                while (UserReader.Read())
                {
                    UserList.Add(UserReader.GetValue(0).ToString());
                }
                MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                HttpContext.Session.SetString("OFFSET", (OFFSET + 50).ToString());
            }
            else if (User == null && OFFSETString != null)
            {
                OFFSET = int.Parse(OFFSETString);
                if (OFFSET == 0)
                {
                    OFFSET += 50;
                }
                MySQLQuery.CommandText = "SELECT `User_Name` FROM `User` WHERE `User_Name`!='@Current_User' LIMIT 50 OFFSET " + OFFSET.ToString();
                MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                UserReader = MySQLQuery.ExecuteReader();
                while (UserReader.Read())
                {
                    UserList.Add(UserReader.GetValue(0).ToString());
                }
                MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                HttpContext.Session.SetString("OFFSET", (OFFSET + 50).ToString());
            }
            else if (User==null && OFFSETString==null) 
            {
                OFFSET = 50;
                MySQLQuery.CommandText = "SELECT `User_Name` FROM `User` WHERE `User_Name`!='@Current_User' LIMIT 50 OFFSET " + OFFSET.ToString();
                MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                UserReader = MySQLQuery.ExecuteReader();
                while (UserReader.Read())
                {
                    UserList.Add(UserReader.GetValue(0).ToString());
                }
                MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                HttpContext.Session.SetString("OFFSET", (OFFSET + 50).ToString());
            }
        }

        //Show previous records
        public void OnPostPrevious() 
        {
            String User = HttpContext.Session.GetString("Search_User");
            String OFFSETString = HttpContext.Session.GetString("OFFSET");
            String Exception = "";
            String Current_User = HttpContext.Session.GetString("User_Name");
            Boolean CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
            MySqlCommand MySQLQuery = new MySqlCommand();
            MySqlDataReader UserReader;
            UserList = new List<String> { };
            int OFFSET = 0;
            SessionSearchUser = User;
            if (User != null && OFFSETString != null)
            {
                OFFSET = int.Parse(OFFSETString);
                if (OFFSET != 0) 
                {
                    OFFSET -= 50;
                }
                MySQLQuery.CommandText = "SELECT `User_Name` FROM `User` WHERE `User_Name`!='@Current_User' AND `User_Name` LIKE '%@Search_User%' LIMIT 50 OFFSET " + OFFSET.ToString();
                MySQLQuery.Parameters.Add("@Search_User", MySqlDbType.Text).Value = User;
                MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                UserReader = MySQLQuery.ExecuteReader();
                while (UserReader.Read())
                {
                    UserList.Add(UserReader.GetValue(0).ToString());
                }
                MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                HttpContext.Session.SetString("OFFSET", OFFSET.ToString());
            }
            else if (User == null && OFFSETString!=null)
            {
                OFFSET = int.Parse(OFFSETString);
                if (OFFSET != 0)
                {
                    OFFSET -= 50;
                }
                MySQLQuery.CommandText = "SELECT `User_Name` FROM `User` WHERE `User_Name`!='@Current_User' LIMIT 50 OFFSET " + OFFSET.ToString();
                MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                UserReader = MySQLQuery.ExecuteReader();
                while (UserReader.Read())
                {
                    UserList.Add(UserReader.GetValue(0).ToString());
                }
                MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                HttpContext.Session.SetString("OFFSET", OFFSET.ToString());
            }
        }

        //Show searched records
        public void OnPostSearch() 
        {
            String Search_User = Request.Form["Search_User"];
            String Exception = "";
            String Current_User = HttpContext.Session.GetString("User_Name");
            int OFFSET = 50;
            Boolean CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
            MySqlCommand MySQLQuery = new MySqlCommand();
            MySqlDataReader UserReader;
            UserList = new List<String> { };
            if (Search_User != null || Search_User.CompareTo("") != 0) 
            {
                HttpContext.Session.SetString("Search_User", Search_User);
                HttpContext.Session.SetString("OFFSET", OFFSET.ToString());
                SessionSearchUser = Search_User;
                MySQLQuery = new MySqlCommand();
                MySQLQuery.Parameters.Clear();
                MySQLQuery.CommandText = "SELECT `User_Name` FROM `User` WHERE `User_Name`!='@Current_User' AND `User_Name` LIKE '%@Search_User%' LIMIT 50";
                MySQLQuery.Parameters.Add("@Search_User", MySqlDbType.Text).Value = Search_User;
                MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                UserReader = MySQLQuery.ExecuteReader();
                while (UserReader.Read()) 
                {
                    UserList.Add(UserReader.GetValue(0).ToString());
                }
                MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
            }
        }

        //Remove Search Session
        public void OnPostClearSearchSession() 
        {
            String User = HttpContext.Session.GetString("Search_User");
            String OFFSETString = HttpContext.Session.GetString("OFFSET");
            if (User != null && OFFSETString != null) 
            {
                HttpContext.Session.Remove("Search_User");
                HttpContext.Session.Remove("OFFSET");
                Response.Redirect("Users");
            }
        }
    }
}