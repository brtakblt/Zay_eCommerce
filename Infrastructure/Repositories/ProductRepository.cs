using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.products.ToListAsync();
        }
    }
}
