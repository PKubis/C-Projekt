using Microsoft.AspNetCore.Mvc;

namespace _4Ballers.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
