using Microsoft.AspNetCore.Mvc;

namespace FormApp.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Submit(string name, string address, string email)
        {
            ViewData["name"] = name;
            ViewData["address"] = address;
            ViewData["email"] = email;
            return View();
        }
    }
}
