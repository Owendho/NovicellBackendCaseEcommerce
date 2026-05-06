using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ProductCatalogue.Models
{
    public class ERPProduct
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [Required]

        [JsonPropertyName("title")]
        public string Title { get; set; }
        [Required]

        [JsonPropertyName("price")]
        public double Price { get; set; }
        [Required]

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [Required]

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [Required]

        [JsonPropertyName("image")]
        public string Image { get; set; } 
    }
}
