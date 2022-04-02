using BlazorEcommerce.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEcommerce.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Task GetProducts();

        Task<ServiceResponse<Product>> GetProductById(int id);
    }
}
