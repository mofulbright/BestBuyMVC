using BestBuyMVC.bestbuy;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using BestBuyMVC.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IDbConnection>((s) =>
    {
        IDbConnection conn = new MySqlConnection(builder.Configuration.GetConnectionString("bestbuy"));
        conn.Open();
        return conn;
    });

builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<ISaleRepository, SaleRepository>();
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();


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
