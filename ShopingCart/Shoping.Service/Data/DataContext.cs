using Microsoft.EntityFrameworkCore;
using Shoping.Model.Entities;

namespace Shoping.Service.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
