using Microsoft.EntityFrameworkCore;

namespace DesignPatter.Mediator.DAL;

public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=YoureServerName; initial Catalog=Mediator; integrated security=true;TrustServerCertificate=True;");

    }
    public DbSet<Product> Products { get; set; }

}
