using System.Web.Mvc;

namespace VulnerableApp.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult UpdateEmail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateEmail(string email)
        {
            // 🔓 No CSRF protection
            ViewBag.Message = "Email updated to: " + email;
            return View();
        }
    }
}
