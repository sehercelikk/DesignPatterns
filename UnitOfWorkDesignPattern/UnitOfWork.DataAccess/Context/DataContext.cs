using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Entity.Concrete;

namespace UnitOfWork.DataAccess.Context;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Process> Processes { get; set; }
}
