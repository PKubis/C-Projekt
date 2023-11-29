using Microsoft.AspNetCore.Mvc;

public class PublicController : Controller
{
    public IActionResult History()
    {
        ViewData["Title"] = "Historia";
        return View();
    }

    public IActionResult Team()
    {
        ViewData["Title"] = "Drużyny";
        return View();
    }

    public IActionResult Contact()
    {
        ViewData["Title"] = "Kontakt";
        return View();
    }
}
