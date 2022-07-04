using Microsoft.AspNetCore.Mvc;

namespace Authorization.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Authorization()
        {
            return View();
        }


    }
}
