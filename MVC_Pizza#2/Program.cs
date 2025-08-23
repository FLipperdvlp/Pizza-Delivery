using Microsoft.EntityFrameworkCore;
using NeGlovo.Database;
using NeGlovo.Interfaces;
using NeGlovo.Services;

var builder = WebApplication.CreateBuilder(args);
{
    // Реєструємо EF db context
    builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlite("Data source = neglovo.db"));

    // Реєструємо ресторан сервіс через інтерфейс
    builder.Services.AddScoped<IRestaurantsService, RestaurantsService>();
    builder.Services.AddScoped<IOrdersService, OrdersService>();

    builder.Services.AddControllersWithViews();
}

var app = builder.Build();
{
    app.UseStaticFiles();
    app.MapControllerRoute("default", "{controller}/{action}/{id?}");

    app.Run();
}