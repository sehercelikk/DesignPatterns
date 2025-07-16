using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRS.DAL;

public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=YoureServerName; initial Catalog=CQRS; integrated security=true;TrustServerCertificate=True;");
    }

    public DbSet<Product> Products { get; set; }
}
