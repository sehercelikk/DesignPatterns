using Microsoft.EntityFrameworkCore;

namespace DesignPattern.Decorator.DAL;

public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=BPODSHGM74\MSSQLSERVER2025; initial Catalog=Decorator; integrated security=true;TrustServerCertificate=True;");
    }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Notifier> Notifiers { get; set; }
}
