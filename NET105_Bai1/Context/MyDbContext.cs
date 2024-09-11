using Microsoft.EntityFrameworkCore;
using NET105_Bai1.Models;

namespace NET105_Bai1.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) 
            : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
    }
}
