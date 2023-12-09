using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;

namespace _4Ballers.Pages
{
    public class HistoryModel : PageModel
    {
        [BindProperty]
        public IFormFile FileInput { get; set; }

        public void OnGet()
        {
            // Kod obsługi dla żądania GET
        }

        public void OnPost()
        {
            // Kod obsługi dla żądania POST
            if (FileInput != null && FileInput.Length > 0)
            {
                // Tutaj możesz przetworzyć przesłane zdjęcie, np. zapisać je na dysku
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", FileInput.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    FileInput.CopyTo(stream);
                }

                // Pamiętaj o sprawdzeniu typu pliku, wielkości itp., aby zabezpieczyć aplikację
            }
        }
    }
}
