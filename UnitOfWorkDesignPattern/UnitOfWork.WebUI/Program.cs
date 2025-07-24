using Microsoft.EntityFrameworkCore;
using UnitOfWork.Business.Abstract;
using UnitOfWork.Business.Concrete;
using UnitOfWork.DataAccess.Abstract;
using UnitOfWork.DataAccess.Context;
using UnitOfWork.DataAccess.EntityFramework;
using UnitOfWork.DataAccess.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICustomerDal, EfCustomerDal>();
builder.Services.AddScoped<ICustomerService, CustomerManager>();
builder.Services.AddScoped<IUnitOfWorkDal, UnitOfWorkDal>();

builder.Services.AddDbContext<DataContext>(opt=>
opt.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
