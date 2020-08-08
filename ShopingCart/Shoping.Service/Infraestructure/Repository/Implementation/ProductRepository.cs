using Microsoft.EntityFrameworkCore;
using Shoping.Model.Entities;
using Shoping.Service.Data;
using Shoping.Service.Infraestructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;

namespace Shoping.Service.Infraestructure.Implementation
{
    public class ProductRepository : IProduct
    {
        private readonly DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }

        public void DeleteProrduct(Product product)
        {
            _context.Products.Remove(product);
        }

        public async Task<List<Product>> GetAllProduct()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProductById(int? Id)
        {
            return await _context.Products.Where(x => x.Id == Id).FirstOrDefaultAsync();
        }

        public void InsertProduct(Product product)
        {
            _context.Products.Add(product);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
        }
    }
}
