using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using _4Ballers.Data;
using _4Ballers.Models;

namespace _4Ballers.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public ProductsController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // Metoda Index wyświetlająca listę produktów
        public async Task<IActionResult> Index()
        {
            var products = _context.Products.ToList();
            var user = await _userManager.GetUserAsync(User);
            bool isAdmin = user?.Email == "piotrkubis1989@gmail.com";
            ViewData["IsAdmin"] = isAdmin; // Przekazanie flagi do widoku
            return View("~/Views/Private/Shoes.cshtml", products);
        }

        // Metoda Details do wyświetlania szczegółów produktu
        public IActionResult Details(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // GET: Metoda do wyświetlania formularza dodawania nowego produktu
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Metoda do przetwarzania danych formularza dodawania nowego produktu
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(Product product)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user?.Email != "piotrkubis1989@gmail.com")
            {
                return Forbid();
            }

            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Metoda do wyświetlania formularza edycji produktu
        [Authorize]
        public IActionResult Edit(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Metoda do przetwarzania danych formularza edycji produktu
        [HttpPost]
        [Authorize]
        public IActionResult Edit(int id, Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Update(product);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Metoda do wyświetlania formularza usuwania produktu
        [Authorize]
        public IActionResult Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Metoda do potwierdzenia usuwania produktu
        [HttpPost, ActionName("Delete")]
        [Authorize]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> AddToBasket(int productId, int size)
        {
            var user = await _userManager.GetUserAsync(User);
            var product = _context.Products.FirstOrDefault(p => p.Id == productId);

            if (product != null && user != null)
            {
                var orderItem = new OrderItem
                {
                    ProductId = productId,
                    UserId = user.Id,
                    Size = size,
                    Quantity = 1,
                    TotalPrice = product.Price // Założenie, że cena jest za sztukę
                };

                _context.OrderItems.Add(orderItem);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index", "Products");
        }
        }
}
