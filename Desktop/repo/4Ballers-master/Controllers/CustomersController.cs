using Microsoft.AspNetCore.Mvc;

namespace _4Ballers.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
