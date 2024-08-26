using BOOKSHIPBACKEND.Models;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult Swap()
        {
            return View();
        }
    }
}
