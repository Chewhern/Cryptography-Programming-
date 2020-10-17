using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Http;
using System.Numerics;

namespace EncryptedChatApplication
{
    public class LoginModel : PageModel
    {
        private MyOwnMySQLConnection MyOwnMySQLConnectionClass = new MyOwnMySQLConnection();
        private GetPepperClass MyGetPepperClass = new GetPepperClass();
        private Password_Hasher Password_HasherClass = new Password_Hasher();

        public void OnGet()
        {

        }

        public void OnPost() 
        {
            String Exception = "";
            Boolean CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
            MySqlCommand MySQLQuery = new MySqlCommand();
            MySqlDataReader MyRecordReader;
            int Checker = 0;
            String User_Name = Request.Form["User_Name"];
            String Password = Request.Form["Password"];
            String Salt_From_Database = "";
            String Secondary_Password = Request.Form["Secondary_Password"];
            String Pepper = "";
            String[] SaltArray = new String[2];
            BigInteger PasswordBigInt = 0;
            MyGetPepperClass.InitializePepper();
            Pepper = MyGetPepperClass.Pepper;
            MySQLQuery.CommandText = "SELECT `Salt` FROM `Salt_Table` WHERE `User_Name` = @User_Name";
            MySQLQuery.Parameters.Add("@User_Name", MySqlDbType.Text).Value = User_Name;
            MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
            MySQLQuery.Prepare();
            MyRecordReader = MySQLQuery.ExecuteReader();
            while (MyRecordReader.Read()) 
            {
                Salt_From_Database = MyRecordReader.GetValue(0).ToString();
            }
            MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
            CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
            SaltArray[0] = Salt_From_Database;
            SaltArray[1] = Secondary_Password;
            PasswordBigInt = Password_HasherClass.Hashing_Function(Password, SaltArray, Pepper);
            MySQLQuery = new MySqlCommand();
            MySQLQuery.CommandText = "SELECT COUNT(*) FROM `User` WHERE `User_Name` = @User_Name AND `Password` = @Password";
            MySQLQuery.Parameters.Add("@User_Name", MySqlDbType.Text).Value = User_Name;
            MySQLQuery.Parameters.Add("@Password", MySqlDbType.Text).Value = PasswordBigInt.ToString();
            MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
            MySQLQuery.Prepare();
            Checker = int.Parse(MySQLQuery.ExecuteScalar().ToString());
            MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
            if (Checker == 1)
            {
                HttpContext.Session.SetString("User_Name", User_Name);
                Response.Redirect("Users");
            }
            else 
            {
                ViewData["Redirect_Error"] = "This account does not exist in our system";
            }
        }
    }
}