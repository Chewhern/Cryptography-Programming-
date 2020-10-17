using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace EncryptedChatApplication
{
    public class Register_RedirectModel : PageModel
    {
        public List<String> SaltsList = new List<String> { };
        public void OnGet()
        {
            String Password = "";
            String AESIVString = "";
            String SaltsSessionConst = "Salts ";
            if (HttpContext.Session.GetString("UserPassword")!=null) 
            {
                Password = HttpContext.Session.GetString("UserPassword");
                AESIVString = HttpContext.Session.GetString("UserAESIVString");
                if (HttpContext.Session.GetString(SaltsSessionConst + "1")!=null) 
                {
                    SaltsList.Add(HttpContext.Session.GetString(SaltsSessionConst + "1".ToString()));
                }
                ViewData["Password"] = Password;
                ViewData["AESIVString"] = AESIVString;
            }

        }

        public void OnPost() 
        {
            String SaltsSessionConst = "Salts ";
            if (HttpContext.Session.GetString(SaltsSessionConst + "1") != null)
            {
                HttpContext.Session.Remove(SaltsSessionConst + "1");
            }
            HttpContext.Session.Remove("UserPassword");
            HttpContext.Session.Remove("UserAESIVString");
            HttpContext.Session.Remove("ActualSaltsAmount");
            Response.Redirect("Users");
        }
    }
}