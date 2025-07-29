using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Decorator.DAL;

public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"YoureServerName; initial Catalog=Decorator; integrated security=true;TrustServerCertificate=True;");
    }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Notifier> Notifiers { get; set; }
}
