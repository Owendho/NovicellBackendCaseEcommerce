using ProductCatalogue.Models;
using System.Text.Json;
using Microsoft.Extensions.Configuration;

namespace ProductCatalogue
{
    public class ERPSync
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _config;


        public ERPSync(HttpClient httpClient, IConfiguration config) //dependency inject httpClient using builder services
        {
            _httpClient = httpClient;
            _config = config;
        }

        public async Task<List<ERPProduct>> GetAsyncEcommerceProducts() 
        {
            try
            {
                var baseUrl = _config["ErpSettings:BaseUrl"];
                var path = _config["ErpSettings:ProductsPath"];

                using HttpResponseMessage response = await _httpClient.GetAsync($"{baseUrl}{path}");

                response.EnsureSuccessStatusCode();

                using var contentStream = await response.Content.ReadAsStreamAsync();

                var products = await JsonSerializer.DeserializeAsync<List<ERPProduct>>(contentStream);

                return products;
            }
            catch (HttpRequestException ex) {
                throw new Exception("Failed to reach ERP system", ex);
            }

        }


        public async Task<List<ERPCategory>> GetAsyncEcommerceCategories()
        {
            try
            {
                var baseUrl = _config["ErpSettings:BaseUrl"];
                var path = _config["ErpSettings:CategoriesPath"];

                using HttpResponseMessage response = await _httpClient.GetAsync($"{baseUrl}{path}");

                response.EnsureSuccessStatusCode();

                using var contentStream = await response.Content.ReadAsStreamAsync();

                var categories = await JsonSerializer.DeserializeAsync<List<ERPCategory>>(contentStream);

                return categories;
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Failed to reach ERP system", ex);
            }

        }




    }
}
