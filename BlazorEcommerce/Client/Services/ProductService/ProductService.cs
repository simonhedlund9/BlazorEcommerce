using BlazorEcommerce.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorEcommerce.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;
        public ProductService(HttpClient http)
        {
            _http = http;
        }
        public List<Product> Products { get; set; } = new List<Product>();

        public Task<ServiceResponse<Product>> GetProductById(int id)
        {
            var result = _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/product/{id}");
            return result;
        }

        public async Task GetProducts()
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/Product");
            Products = result.Data;
        }
    }
}
