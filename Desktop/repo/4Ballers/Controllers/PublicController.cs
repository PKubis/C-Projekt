using Microsoft.AspNetCore.Mvc;
using _4Ballers.Models; // Dodaj przestrzeń nazw modelu

namespace _4Ballers.Controllers
{
    public class PublicController : Controller
    {
        public IActionResult History()
        {
            ViewData["Title"] = "Historia";
            return View();
        }

        public IActionResult Teams()
        {
            List<Team> teams = GetTeamsData();
            ViewData["Title"] = "Drużyny";
            return View("~/Views/Public/Teams/Team.cshtml", teams);
        }


        public IActionResult Contact()
        {
            ViewData["Title"] = "Kontakt";
            return View();
        }

        private List<Team> GetTeamsData()
        {

            return new List<Team>
        {
                
            new Team { Id = 1,  ImageUrl = "/images/PhilLogo.jpg" },
            new Team { Id = 2,  ImageUrl = "/images/CeltLogo.jpg" },
            new Team { Id = 3,  ImageUrl = "/images/NetLogo.jpg" },
            new Team { Id = 4,  ImageUrl = "/images/KnicksLogo.jpg" },
            new Team { Id = 5,  ImageUrl = "/images/DinoLogo.jpg" },
            new Team { Id = 6,  ImageUrl = "/images/BullsLogo.jpg" },
            new Team { Id = 7,  ImageUrl = "/images/CavsLogo.jpg" },
            new Team { Id = 8,  ImageUrl = "/images/DetLogo.jpg" },
            new Team { Id = 9,  ImageUrl = "/images/PacersLogo.jpg" },
            new Team { Id = 10,  ImageUrl = "/images/MillLogo.jpg" },
            new Team { Id = 11,  ImageUrl = "/images/AtlLogo.jpg" },
            new Team { Id = 12,  ImageUrl = "/images/HornetLogo.jpg" },
            new Team { Id = 13,  ImageUrl = "/images/HeatsLogo.jpg" },
            new Team { Id = 14,  ImageUrl = "/images/OrlandoLogo.jpg" },
            new Team { Id = 15,  ImageUrl = "/images/WasLogo.jpg" },
            new Team { Id = 16,  ImageUrl = "/images/DenLogo.jpg" },
            new Team { Id = 17,  ImageUrl = "/images/MinLogo.jpg" },
            new Team { Id = 18,  ImageUrl = "/images/ThunderLogo.jpg" },
            new Team { Id = 19,  ImageUrl = "/images/BlazersLogo.jpg" },
            new Team { Id = 20,  ImageUrl = "/images/UtaLogo.jpg" },
            new Team { Id = 21,  ImageUrl = "/images/GswLogo.jpg" },
            new Team { Id = 22,  ImageUrl = "/images/ClipersLogo.jpg" },
            new Team { Id = 23,  ImageUrl = "/images/LalLogo.jpg" },
            new Team { Id = 24,  ImageUrl = "/images/SunsLogo.jpg" },
            new Team { Id = 25,  ImageUrl = "/images/SacrLogo.jpg" },
            new Team { Id = 26,  ImageUrl = "/images/MinLogo.jpg" },
            new Team { Id = 27,  ImageUrl = "/images/RocketsLogo.jpg" },
            new Team { Id = 28,  ImageUrl = "/images/GrizzlyLogo.jpg" },
            new Team { Id = 29,  ImageUrl = "/images/PelicansLogo.jpg" },
            new Team { Id = 30,  ImageUrl = "/images/SpursLogo.jpg" },
        };
        }
    }
}