using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

[Authorize]
public class PrivateController : Controller
{
    public IActionResult Shoes()
    {
        ViewData["Title"] = "Obuwie";
        return View();
    }

    public IActionResult Basket()
    {
        ViewData["Title"] = "Koszyk";
        return View();
    }
}
