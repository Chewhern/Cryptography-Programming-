﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace EncryptedChatApplication
{
    public class Log_OutModel : PageModel
    {
        public void OnGet()
        {
            HttpContext.Session.Clear();
            Response.Redirect("Index");
        }
    }
}