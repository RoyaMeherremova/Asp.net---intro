using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;
using System;

namespace Asp_net.intro_homework.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            //2)Account controllerin index action-dan onun view-na userlerin list sekilinde adlarini gonderib ekranda li - taglarinda gostermek.
            List<string> users = new List<string>() {"Roya","Konul","Cinare","Elekber"};
            return View(users);
        }
    }
}
