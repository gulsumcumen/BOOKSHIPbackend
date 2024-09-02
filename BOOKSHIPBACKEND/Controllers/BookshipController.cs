using BOOKSHIPBACKEND.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace BOOKSHIP.Controllers
{
    public class BookshipController : Controller
    {
        Context c = new Context();

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Forum()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveUser(char username, char password)
        {
            var person = new UserInfoClass
            {
                UserName = username,
                Password = password
            };

            c.People.Add(person);
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult SignUp() 
        {
        return View();
        }
        public IActionResult Swap()
        {
            return View();
        }
        public IActionResult UserSettings()
        {
            return View();
        }
    }
}

