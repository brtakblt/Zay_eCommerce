using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.Product;
using Application.Interfaces;

namespace Application.Services
{
    public class ProductService
    {

        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<ProductListDto>> GetAllProductsAsync()
        {
            var products = await _productRepository.GetAllAsync();

            return products.Select(p => new ProductListDto
            {
                Id = p.Id,
                Price = p.Price,
                Name = p.ProductName,
                ProductImage = p.ProductImage
            }).ToList();
        }

    }
}
