using Microsoft.EntityFrameworkCore;
using NET105_Bai1.Models;
using System.Numerics;

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
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
        public DbSet<Class> Classes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // thiet lap quan he 1-1 giua Student va StudentAddress
            modelBuilder.Entity<Student>()
                .HasOne(s => s.StudentAddress)
                .WithOne(sa => sa.Student)
                .HasForeignKey<StudentAddress>(ad => ad.StudentId);

            // thiet lap quan he 1-n giua Student va Class
            modelBuilder.Entity<Class>()
                .HasMany(c => c.Students)
                .WithOne(s => s.Class)
                .HasForeignKey(s => s.ClassId);

            // thiet lap quan he n-n giua Student va Course
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Courses)
                .WithMany(c => c.Students)
                .UsingEntity(a => a.ToTable("BangTrungGian"));

            modelBuilder.Entity<Student>()
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
