using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWineCellarMVC.Controllers
{
    // Controller to handle the user accounts
    public class AccountController : Controller
    {
        // Method that will redirect the user if they do not have access to a specific page
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
