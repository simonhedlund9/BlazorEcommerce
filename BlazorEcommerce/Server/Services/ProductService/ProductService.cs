using BlazorEcommerce.Server.Data;
using BlazorEcommerce.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorEcommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        public ProductService(DataContext context )
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Product>>> GetProducts()
        {
            var products = await _context.Products.ToListAsync();
            var response = new ServiceResponse<List<Product>>
            {
                Data = products
            };
            return response;
        }
    }
}
