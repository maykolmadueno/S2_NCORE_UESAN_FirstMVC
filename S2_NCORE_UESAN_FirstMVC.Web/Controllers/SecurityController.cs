using Microsoft.AspNetCore.Mvc;

namespace S2_NCORE_UESAN_FirstMVC.Web.Controllers
{
    public class SecurityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email,string password)
        {
            if (email=="20100843@ue.edu.pe" && password=="123456")
            {
                //return View("Login");
                return RedirectToAction("Index", "Home",new {area ="Marketing"});

            }
            return RedirectToAction("Login");
        }
    }
}
