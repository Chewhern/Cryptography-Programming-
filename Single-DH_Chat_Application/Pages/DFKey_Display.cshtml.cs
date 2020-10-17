using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace EncryptedChatApplication
{
    public class DFKey_DisplayModel : PageModel
    {
        public void OnGet()
        {
            String Current_User = HttpContext.Session.GetString("User_Name");
            String Chosen_User = HttpContext.Session.GetString("Chosen_User");
            String Public_Key_String = HttpContext.Session.GetString("User_PK");
            String Private_Key_String = HttpContext.Session.GetString("User_SK");
            if (Current_User != null && Chosen_User != null && Public_Key_String != null && Private_Key_String != null) 
            {
                ViewData["Current_User"] = Current_User;
                ViewData["Chosen_User"] = Chosen_User;
                ViewData["Public_Key_String"] = Public_Key_String;
                ViewData["Private_Key_String"] = Private_Key_String;
                HttpContext.Session.Remove("Chosen_User");
                HttpContext.Session.Remove("User_PK");
                HttpContext.Session.Remove("User_SK");
            }
        }
    }
}