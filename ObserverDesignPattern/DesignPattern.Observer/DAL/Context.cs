using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DesignPattern.Observer.DAL;

public class Context : IdentityDbContext<AppUser,AppRole,int>
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=BPODSHGM74\MSSQLSERVER2025; initial Catalog=Observer; integrated security=true;TrustServerCertificate=True;");
    }
    public DbSet<Discount> Discounts { get; set; }
    public DbSet<WelcomeMessage> WelcomeMessages { get; set; }
    public DbSet<UserProcess> UserProcesses { get; set; }
}
