using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ProductCatalogue.Models
{
    public class ERPCategory
    {
        [Required]

        [JsonPropertyName("id")]
        public string Id { get; set; }
        [Required]

        [JsonPropertyName("name")]
        public string Name { get; set; }
        [Required]
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
