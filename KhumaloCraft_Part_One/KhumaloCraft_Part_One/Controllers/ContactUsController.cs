using Microsoft.AspNetCore.Mvc;

namespace KhumaloCraft_Part_One.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
