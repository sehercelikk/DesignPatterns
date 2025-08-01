﻿using DesignPattern.ChainOfResponsibility.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibility.DAL.Context;

public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=YoureServerName; initial Catalog=ChainRespons; integrated security=true;TrustServerCertificate=True;");
    }

    public DbSet<CustomerProcess> CustomerProcesses { get; set; }
}
