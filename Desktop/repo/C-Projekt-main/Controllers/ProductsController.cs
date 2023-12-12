using Microsoft.AspNetCore.Mvc;

namespace _4Ballers.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
