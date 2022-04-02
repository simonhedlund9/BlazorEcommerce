using BlazorEcommerce.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEcommerce.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProducts();
        Task<ServiceResponse<Product>> GetProductById(int id);
        Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl);
    }
}
