using crud_products.Entity;
using Microsoft.EntityFrameworkCore;

namespace crud_products.Data;

public class AppDbContext : DbContext
{
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    
    public DbSet<ProductEntity> Products { get; set; }
    
}