using Microsoft.EntityFrameworkCore;
using Repository.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DataAccess.Context;

public class ProductDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public ProductDbContext(DbContextOptions<ProductDbContext> options): base(options)
    {
        
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
}
