using _4Ballers.Data;
using _4Ballers.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class OrdersController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<IdentityUser> _userManager;

    public OrdersController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
        var user = await _userManager.GetUserAsync(User);
        var isAdmin = user?.Email == "piotrkubis1989@gmail.com";

        var orderItems = _context.OrderItems
                                 .Include(oi => oi.Product)
                                 .Include(oi => oi.User) // Załaduj informacje o użytkowniku
                                 .ToList();

        if (isAdmin)
        {
            // Jeśli jesteś adminem, zwróć wszystkie pozycje zamówień
            return View("AdminIndex", orderItems); // Użyj innego widoku dla admina
        }

        // Filtrowanie zamówień dla zalogowanego użytkownika
        orderItems = orderItems.Where(oi => oi.UserId == user.Id).ToList();

        return View(orderItems);
    }



    [HttpPost]
    public async Task<IActionResult> AddToBasket(int productId, int size)
    {
        var user = await _userManager.GetUserAsync(User);
        var product = _context.Products.FirstOrDefault(p => p.Id == productId);

        if (product != null && user != null)
        {
            var existingItem = _context.OrderItems.FirstOrDefault(oi => oi.ProductId == productId && oi.Size == size && oi.UserId == user.Id);

            if (existingItem != null)
            {
                existingItem.Quantity++;
                existingItem.TotalPrice += product.Price;
            }
            else
            {
                var orderItem = new OrderItem
                {
                    ProductId = productId,
                    UserId = user.Id,
                    Size = size,
                    Quantity = 1,
                    TotalPrice = product.Price
                };
                _context.OrderItems.Add(orderItem);
            }

            await _context.SaveChangesAsync();
        }

        return RedirectToAction("Index", "Orders");
    }

    public async Task<IActionResult> RemoveFromBasket(int orderItemId)
    {
        var user = await _userManager.GetUserAsync(User);
        var orderItem = _context.OrderItems.FirstOrDefault(oi => oi.Id == orderItemId && oi.UserId == user.Id);

        if (orderItem != null)
        {
            _context.OrderItems.Remove(orderItem);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction("Index");
    }
    [HttpPost]
    public async Task<IActionResult> DeleteOrder(int orderId)
    {
        var user = await _userManager.GetUserAsync(User);
        var isAdmin = user?.Email == "piotrkubis1989@gmail.com";
        if (!isAdmin) return Forbid(); // Sprawdź, czy użytkownik jest administratorem

        var orderItem = await _context.OrderItems.FindAsync(orderId);
        if (orderItem != null)
        {
            _context.OrderItems.Remove(orderItem);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction("Index", "Orders");
    }

}
