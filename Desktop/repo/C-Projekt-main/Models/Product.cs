namespace _4Ballers.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } // URL do zdjęcia produktu
        public string Description { get; set; } // Opis produktu
        // Możesz także dodać inne właściwości, takie jak dostępne rozmiary, itp.
    }
}
