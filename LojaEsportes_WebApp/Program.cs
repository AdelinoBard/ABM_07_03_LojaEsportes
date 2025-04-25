using Microsoft.EntityFrameworkCore;
using LojaEsportes_WebApp.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<StoreDbContext>(opts => 
{
    opts.UseSqlServer(
        builder.Configuration["ConnectionStrings:LojaEsportesConnection"] 
        ?? throw new InvalidOperationException("Connection string 'LojaEsportesConnection' not found."));
});

builder.Services.AddScoped<IStoreRepository, EFStoreRepository>();

builder.Services.AddScoped<IOrderRepository, EFOrderRepository>();      // Adicionado

builder.Services.AddRazorPages();

builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession();

builder.Services.AddScoped<Cart>(sp => SessionCart.GetCart(sp));            // adicionado

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); // adicionado

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseSession();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute("catpage",
    "{category}/Page{productPage:int}",
    new { Controller = "Home", action = "Index" });

app.MapControllerRoute("page", "Page{productPage:int}",
    new { Controller = "Home", action = "Index", productPage = 1 });

app.MapControllerRoute("category", "{category}",
    new { Controller = "Home", action = "Index", productPage = 1 });

app.MapControllerRoute("pagination",
    "Products/Page{productPage}",
    new { Controller = "Home", action = "Index", productPage = 1 });

app.MapDefaultControllerRoute();

app.MapRazorPages();

SeedData.EnsurePopulated(app);

app.Run();