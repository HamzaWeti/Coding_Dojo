#pragma warning disable CS8618
using Microsoft.EntityFrameworkCore;
using ProductAndCategories.Models;

namespace ProductAndCategories.Data;


public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options){}

    // Our Database Tables 
    // public DbSet<User> Users { get; set; }
    // public DbSet<Order> Orders { get; set; }
    // public DbSet<Product> Products { get; set; }

    public DbSet<Product> Products { get; set; }
    public DbSet<Categorie> Categories { get; set; }
    public DbSet<Association> Associations { get; set; }
}