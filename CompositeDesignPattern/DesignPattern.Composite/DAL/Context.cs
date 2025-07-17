using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Composite.DAL;

public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=BPODSHGM74\MSSQLSERVER2025; initial Catalog=Composite; integrated security=true;TrustServerCertificate=True;");

    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}
