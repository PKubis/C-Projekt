using Microsoft.AspNetCore.Identity;

namespace _4Ballers.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string UserId { get; set; } // Id użytkownika
        public int Size { get; set; } // Rozmiar buta
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual IdentityUser User { get; set; } // Właściwość nawigacyjna dla użytkownika

        public Product Product { get; set; } // Powiązanie z produktem
    }
}
