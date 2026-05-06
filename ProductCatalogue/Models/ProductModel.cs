using System.Text.Json.Serialization;

namespace ProductCatalogue.Models
{
    public class ProductModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Image { get; set; } //Maybe use regex to enure it is valid link
    }
}
