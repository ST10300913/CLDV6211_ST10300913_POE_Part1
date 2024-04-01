using Microsoft.AspNetCore.Mvc;

namespace KhumaloCraft_Part_One.Controllers
{
    public class MyWorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
