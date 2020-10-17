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
    public class Chat_ListModel : PageModel
    {
        private MyOwnMySQLConnection MyOwnMySQLConnectionClass = new MyOwnMySQLConnection();
        public List<String> OtherUserList = new List<String> { };
        public List<String> IDList = new List<String> { };
        public int OtherUserCount;

        public void OnGet()
        {
            String Exception = "";
            Boolean CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
            MySqlCommand MySQLQuery = new MySqlCommand();
            MySqlDataReader RecordReader;
            String Requestor_1 = "";
            String Current_User = HttpContext.Session.GetString("User_Name");
            MySQLQuery.CommandText = "SELECT COUNT(*) FROM `DF_Public_Key` WHERE `Requestor_1`=@Current_User OR `Requestor_2`=@Current_User AND `Status`=@Status";
            MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
            MySQLQuery.Parameters.Add("@Status", MySqlDbType.Text).Value = "R1 & R2 had established keys respectively";
            MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
            MySQLQuery.Prepare();
            OtherUserCount = int.Parse(MySQLQuery.ExecuteScalar().ToString());
            MySQLQuery = new MySqlCommand();
            MySQLQuery.CommandText = "SELECT `Requestor_1`,`Requestor_2`,`ID` FROM `DF_Public_Key` WHERE `Requestor_1`=@Current_User OR `Requestor_2`=@Current_User AND `Status`=@Status LIMIT 50";
            MySQLQuery.Parameters.Add("@Current_User",MySqlDbType.Text).Value=Current_User;
            MySQLQuery.Parameters.Add("@Status", MySqlDbType.Text).Value = "R1 & R2 had established keys respectively";
            MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
            MySQLQuery.Prepare();
            RecordReader = MySQLQuery.ExecuteReader();
            while (RecordReader.Read()) 
            {
                Requestor_1 = RecordReader.GetValue(0).ToString();
                if (Requestor_1.CompareTo(Current_User) != 0)
                {
                    OtherUserList.Add(Requestor_1);
                }
                else 
                {
                    OtherUserList.Add(RecordReader.GetValue(1).ToString());
                }
                IDList.Add(RecordReader.GetValue(2).ToString());
            }
            MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
        }

        public void OnPost() 
        {
            String ID = Request.Form["Key_Checker_BTN"];
            if (ID != null) 
            {
                HttpContext.Session.SetString("ID", ID);
                Response.Redirect("DFKey_Check");
            }
        }

        public void OnPostChat() 
        {
            String ChatID = Request.Form["Chat_BTN"];
            if (ChatID != null) 
            {
                HttpContext.Session.SetString("Chat_ID", ChatID);
                Response.Redirect("ChatDataEntrance");
            }
        }

        public void OnPostNext() 
        {
            String Search_User = HttpContext.Session.GetString("Search_User");
            String Exception = "";
            Boolean CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
            MySqlCommand MySQLQuery = new MySqlCommand();
            MySqlDataReader RecordReader;
            String Requestor_1 = "";
            String Current_User = HttpContext.Session.GetString("User_Name");
            String Chat_OFFSET_String = HttpContext.Session.GetString("Chat_OFFSET");
            int Chat_OFFSET = int.Parse(Chat_OFFSET_String);
            OtherUserList = new List<String> { };
            IDList = new List<String> { };
            if (Search_User != null)
            {
                if (Chat_OFFSET == 0)
                {
                    Chat_OFFSET += 50;
                }
                MySQLQuery.CommandText = "SELECT `Requestor_1`,`ID` FROM `DF_Public_Key` WHERE `Requestor_1`=@Current_User AND `Status`=@Status AND `Requestor_2` LIKE '%@Search_User%' LIMIT 50 OFFSET " + Chat_OFFSET.ToString();
                MySQLQuery.Parameters.Add("@Search_User", MySqlDbType.Text).Value = Search_User;
                MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                MySQLQuery.Parameters.Add("@Status", MySqlDbType.Text).Value = "R1 & R2 had established keys respectively";
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                RecordReader = MySQLQuery.ExecuteReader();
                while (RecordReader.Read())
                {
                    Requestor_1 = RecordReader.GetValue(0).ToString();
                    OtherUserList.Add(Requestor_1);
                    IDList.Add(RecordReader.GetValue(1).ToString());
                }
                MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
                MySQLQuery = new MySqlCommand();
                MySQLQuery.CommandText = "SELECT `Requestor_2`,`ID` FROM `DF_Public_Key` WHERE `Requestor_2`=@Current_User AND `Status`=@Status AND `Requestor_1` LIKE '%@Search_User%' LIMIT 50 OFFSET " + Chat_OFFSET.ToString();
                MySQLQuery.Parameters.Add("@Search_User", MySqlDbType.Text).Value = Search_User;
                MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                MySQLQuery.Parameters.Add("@Status", MySqlDbType.Text).Value = "R1 & R2 had established keys respectively";
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                RecordReader = MySQLQuery.ExecuteReader();
                while (RecordReader.Read())
                {
                    Requestor_1 = RecordReader.GetValue(0).ToString();
                    OtherUserList.Add(Requestor_1);
                    IDList.Add(RecordReader.GetValue(1).ToString());
                }
                MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                HttpContext.Session.SetString("Chat_OFFSET", (Chat_OFFSET + 50).ToString());
            }
            else 
            {
                if (Chat_OFFSET == 0)
                {
                    Chat_OFFSET += 50;
                }
                MySQLQuery.CommandText = "SELECT `Requestor_1`,`ID` FROM `DF_Public_Key` WHERE `Requestor_1`=@Current_User AND `Status`=@Status AND LIMIT 50 OFFSET " + Chat_OFFSET.ToString();
                MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                MySQLQuery.Parameters.Add("@Status", MySqlDbType.Text).Value = "R1 & R2 had established keys respectively";
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                RecordReader = MySQLQuery.ExecuteReader();
                while (RecordReader.Read())
                {
                    Requestor_1 = RecordReader.GetValue(0).ToString();
                    OtherUserList.Add(Requestor_1);
                    IDList.Add(RecordReader.GetValue(1).ToString());
                }
                MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
                MySQLQuery = new MySqlCommand();
                MySQLQuery.CommandText = "SELECT `Requestor_2`,`ID` FROM `DF_Public_Key` WHERE `Requestor_2`=@Current_User AND `Status`=@Status LIMIT 50 OFFSET " + Chat_OFFSET.ToString();
                MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                MySQLQuery.Parameters.Add("@Status", MySqlDbType.Text).Value = "R1 & R2 had established keys respectively";
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                RecordReader = MySQLQuery.ExecuteReader();
                while (RecordReader.Read())
                {
                    Requestor_1 = RecordReader.GetValue(0).ToString();
                    OtherUserList.Add(Requestor_1);
                    IDList.Add(RecordReader.GetValue(1).ToString());
                }
                MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                HttpContext.Session.SetString("Chat_OFFSET", (Chat_OFFSET + 50).ToString());
            }
        }

        public void OnPostPrevious() 
        {
            String Search_User = HttpContext.Session.GetString("Search_User");
            String Exception = "";
            Boolean CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
            MySqlCommand MySQLQuery = new MySqlCommand();
            MySqlDataReader RecordReader;
            String Requestor_1 = "";
            String Current_User = HttpContext.Session.GetString("User_Name");
            String Chat_OFFSET_String = HttpContext.Session.GetString("Chat_OFFSET");
            int Chat_OFFSET = int.Parse(Chat_OFFSET_String);
            OtherUserList = new List<String> { };
            IDList = new List<String> { };
            if (Search_User != null)
            {
                if (Chat_OFFSET != 0)
                {
                    Chat_OFFSET -= 50;
                }
                MySQLQuery.CommandText = "SELECT `Requestor_1`,`ID` FROM `DF_Public_Key` WHERE `Requestor_1`=@Current_User AND `Status`=@Status AND `Requestor_2` LIKE '%@Search_User%' LIMIT 50 OFFSET " + Chat_OFFSET.ToString();
                MySQLQuery.Parameters.Add("@Search_User", MySqlDbType.Text).Value = Search_User;
                MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                MySQLQuery.Parameters.Add("@Status", MySqlDbType.Text).Value = "R1 & R2 had established keys respectively";
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                RecordReader = MySQLQuery.ExecuteReader();
                while (RecordReader.Read())
                {
                    Requestor_1 = RecordReader.GetValue(0).ToString();
                    OtherUserList.Add(Requestor_1);
                    IDList.Add(RecordReader.GetValue(1).ToString());
                }
                MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
                MySQLQuery = new MySqlCommand();
                MySQLQuery.CommandText = "SELECT `Requestor_2`,`ID` FROM `DF_Public_Key` WHERE `Requestor_2`=@Current_User AND `Status`=@Status AND `Requestor_1` LIKE '%@Search_User%' LIMIT 50 OFFSET " + Chat_OFFSET.ToString();
                MySQLQuery.Parameters.Add("@Search_User", MySqlDbType.Text).Value = Search_User;
                MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                MySQLQuery.Parameters.Add("@Status", MySqlDbType.Text).Value = "R1 & R2 had established keys respectively";
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                RecordReader = MySQLQuery.ExecuteReader();
                while (RecordReader.Read())
                {
                    Requestor_1 = RecordReader.GetValue(0).ToString();
                    OtherUserList.Add(Requestor_1);
                    IDList.Add(RecordReader.GetValue(1).ToString());
                }
                MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                HttpContext.Session.SetString("Chat_OFFSET", Chat_OFFSET.ToString());
            }
            else
            {
                if (Chat_OFFSET != 0)
                {
                    Chat_OFFSET -= 50;
                }
                MySQLQuery.CommandText = "SELECT `Requestor_1`,`ID` FROM `DF_Public_Key` WHERE `Requestor_1`=@Current_User AND `Status`=@Status AND LIMIT 50 OFFSET " + Chat_OFFSET.ToString();
                MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                MySQLQuery.Parameters.Add("@Status", MySqlDbType.Text).Value = "R1 & R2 had established keys respectively";
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                RecordReader = MySQLQuery.ExecuteReader();
                while (RecordReader.Read())
                {
                    Requestor_1 = RecordReader.GetValue(0).ToString();
                    OtherUserList.Add(Requestor_1);
                    IDList.Add(RecordReader.GetValue(1).ToString());
                }
                MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
                MySQLQuery = new MySqlCommand();
                MySQLQuery.CommandText = "SELECT `Requestor_2`,`ID` FROM `DF_Public_Key` WHERE `Requestor_2`=@Current_User AND `Status`=@Status LIMIT 50 OFFSET " + Chat_OFFSET.ToString();
                MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                MySQLQuery.Parameters.Add("@Status", MySqlDbType.Text).Value = "R1 & R2 had established keys respectively";
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                RecordReader = MySQLQuery.ExecuteReader();
                while (RecordReader.Read())
                {
                    Requestor_1 = RecordReader.GetValue(0).ToString();
                    OtherUserList.Add(Requestor_1);
                    IDList.Add(RecordReader.GetValue(1).ToString());
                }
                MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                HttpContext.Session.SetString("Chat_OFFSET", Chat_OFFSET.ToString());
            }
        }

        public void OnPostSearch() 
        {
            String Search_User = Request.Form["Search_User"];
            String Exception = "";
            Boolean CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
            MySqlCommand MySQLQuery = new MySqlCommand();
            MySqlDataReader RecordReader;
            String Requestor_1 = "";
            String Current_User = HttpContext.Session.GetString("User_Name");
            OtherUserList = new List<String> { };
            IDList = new List<String> { };
            if (Search_User != null)
            {
                MySQLQuery.CommandText = "SELECT `Requestor_1`,`ID` FROM `DF_Public_Key` WHERE `Requestor_1`=@Current_User AND `Status`=@Status AND `Requestor_2` LIKE '%@Search_User%' LIMIT 50";
                MySQLQuery.Parameters.Add("@Search_User", MySqlDbType.Text).Value = Search_User;
                MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                MySQLQuery.Parameters.Add("@Status", MySqlDbType.Text).Value = "R1 & R2 had established keys respectively";
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                RecordReader = MySQLQuery.ExecuteReader();
                while (RecordReader.Read())
                {
                    Requestor_1 = RecordReader.GetValue(0).ToString();
                    OtherUserList.Add(Requestor_1);
                    IDList.Add(RecordReader.GetValue(1).ToString());
                }
                MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                CheckConnection = MyOwnMySQLConnectionClass.LoadConnection(ref Exception);
                MySQLQuery = new MySqlCommand();
                MySQLQuery.CommandText = "SELECT `Requestor_2`,`ID` FROM `DF_Public_Key` WHERE `Requestor_2`=@Current_User AND `Status`=@Status AND `Requestor_1` LIKE '%@Search_User%' LIMIT 50";
                MySQLQuery.Parameters.Add("@Search_User", MySqlDbType.Text).Value = Search_User;
                MySQLQuery.Parameters.Add("@Current_User", MySqlDbType.Text).Value = Current_User;
                MySQLQuery.Parameters.Add("@Status", MySqlDbType.Text).Value = "R1 & R2 had established keys respectively";
                MySQLQuery.Connection = MyOwnMySQLConnectionClass.MyMySQLConnection;
                MySQLQuery.Prepare();
                RecordReader = MySQLQuery.ExecuteReader();
                while (RecordReader.Read())
                {
                    Requestor_1 = RecordReader.GetValue(0).ToString();
                    OtherUserList.Add(Requestor_1);
                    IDList.Add(RecordReader.GetValue(1).ToString());
                }
                MyOwnMySQLConnectionClass.MyMySQLConnection.Close();
                HttpContext.Session.SetString("Search_User", Search_User);
                HttpContext.Session.SetString("Chat_OFFSET", (50).ToString());
            }
        }

        public void OnPostClearSearchSession() 
        {
            String Search_User = HttpContext.Session.GetString("Search_User");
            String Chat_OFFSET_String = HttpContext.Session.GetString("Chat_OFFSET");
            if (Search_User!=null && Chat_OFFSET_String!=null) 
            {
                HttpContext.Session.Remove("Search_User");
                HttpContext.Session.Remove("Chat_OFFSET");
                Response.Redirect("Chat_List");
            }
        }
    }
}