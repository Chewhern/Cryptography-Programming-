using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySql.Data.MySqlClient;
using System.Numerics;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Http;

namespace EncryptedChatApplication
{
    public class RegisterModel : PageModel
    {
        private MyOwnMySQLConnection MyOwnMySQLConnectionClass = new MyOwnMySQLConnection();
        private RandomStrongPasswordGenerator RandomStrongPasswordGeneratorClass = new RandomStrongPasswordGenerator();
        private Password_Hasher Password_HasherClass = new Password_Hasher();
        private AES256Class MyAES256Class = new AES256Class();
        private GetPepperClass MyGetPepperClass = new GetPepperClass();

        public void OnGet()
        {

        }

        public void OnPost() 
        {
            BigInteger EncryptedEmailInt = 0;
            BigInteger AESIV;
            Int64 CheckMySQLUserRow;
            String Exception = "";
            MySqlCommand MySQLNonQuery = new MySqlCommand();
            MySqlCommand MySQLQuery = new MySqlCommand();
            Boolean CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
            String UnhashedPassword = RandomStrongPasswordGeneratorClass.GetUniqueString();
            int Loop = 0;
            String[] SaltsArray = new String[2];
            String Pepper = "";
            String TempSalt = "";
            String SaltsSessionConst = "Salts ";
            String User_Name;
            String Email;
            String Security_Question;
            String Unprocessed_Security_Question;
            Byte[] EncryptedEmailByte = new Byte[] { };
            Byte[] Unprocessed_Security_Question_Byte;
            BigInteger PasswordBigInt = 0;
            Aes MyAES = Aes.Create();
            SHA256 MySHA256 = SHA256.Create();
            MyGetPepperClass.InitializePepper();
            Pepper = MyGetPepperClass.Pepper;
            User_Name = Request.Form["User_Name"];
            Email = Request.Form["Email"];
            Security_Question = Request.Form["Security_Question"];
            while (Loop < 2) 
            {
                TempSalt = RandomStrongPasswordGeneratorClass.GetUniqueString();
                SaltsArray[Loop] = TempSalt;
                TempSalt = "";
                Loop += 1;
            }
            Loop = 0;
            PasswordBigInt=Password_HasherClass.Hashing_Function(UnhashedPassword, SaltsArray, Pepper);
            Unprocessed_Security_Question = Security_Question;
            Unprocessed_Security_Question_Byte = MySHA256.ComputeHash(Encoding.UTF8.GetBytes(Unprocessed_Security_Question));
            MyAES.Key = Unprocessed_Security_Question_Byte;
            AESIV = new BigInteger(MyAES.IV.ToArray());
            if (CheckConnection == true)
            {
                MySQLQuery.CommandText = "SELECT COUNT(*) FROM `User` WHERE `User_Name` = @User_Name";
                MySQLQuery.Parameters.Add("@User_Name", MySqlDbType.VarChar).Value = User_Name;
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                CheckMySQLUserRow = Int64.Parse(MySQLQuery.ExecuteScalar().ToString());
                if (CheckMySQLUserRow == 0)
                {
                    MySQLNonQuery = new MySqlCommand();
                    MySQLNonQuery.Parameters.Clear();
                    MyAES256Class.EncryptBytes(ref EncryptedEmailByte, MyAES.Key, MyAES.IV, Encoding.UTF8.GetBytes(Email));
                    EncryptedEmailInt = new BigInteger(EncryptedEmailByte);
                    MySQLNonQuery = new MySqlCommand();
                    MySQLNonQuery.CommandText = "INSERT INTO `User`(`Email`, `User_Name`, `Password`) VALUES (@Email,@User_Name,@Password)";
                    MySQLNonQuery.Parameters.Clear();
                    MySQLNonQuery.Parameters.Add("@Email", MySqlDbType.Text).Value = EncryptedEmailInt.ToString();
                    MySQLNonQuery.Parameters.Add("@User_Name", MySqlDbType.Text).Value = User_Name;
                    MySQLNonQuery.Parameters.Add("@Password", MySqlDbType.Text).Value = PasswordBigInt.ToString();
                    MySQLNonQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                    MySQLNonQuery.Prepare();
                    MySQLNonQuery.ExecuteNonQuery();
                    MySQLNonQuery = new MySqlCommand();
                    MySQLNonQuery.CommandText = "INSERT INTO `Salt_Table`(`User_Name`, `Salt`) VALUES (@User_Name,@Salt)";
                    MySQLNonQuery.Parameters.Clear();
                    MySQLNonQuery.Parameters.Add("@User_Name", MySqlDbType.Text).Value = User_Name;
                    MySQLNonQuery.Parameters.Add("@Salt", MySqlDbType.Text).Value = SaltsArray[0];
                    MySQLNonQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                    MySQLNonQuery.Prepare();
                    MySQLNonQuery.ExecuteNonQuery();
                    HttpContext.Session.SetString("UserAESIVString", AESIV.ToString());
                    HttpContext.Session.SetString("UserPassword", UnhashedPassword);
                    HttpContext.Session.SetString(SaltsSessionConst+"1",SaltsArray[1]);
                    HttpContext.Session.SetString("User_Name", User_Name);
                    HttpContext.Session.SetString("AccountRecovery", "AccountRecovery");
                    MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                    Response.Redirect("Register_Redirect");
                }
                else
                {
                    ViewData["RegistrationError"] = "This account has been registered/used by someone";
                    MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                }
            }
            else
            {
                ViewData["ConnectionError"] = Exception;
            }
        }

    }
}