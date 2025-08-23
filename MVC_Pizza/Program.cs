using Microsoft.EntityFrameworkCore;
using MVC_Pizza.DataBase;
using MVC_Pizza.Services;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddScoped<PizzaService>();
    builder.Services.AddControllersWithViews();
    builder.Services.AddDbContext<PizzaDBContext>(options =>
    {
        options.UseSqlite(builder.Configuration.GetConnectionString("Data source = pizza.db"));
    });
}
var app = builder.Build();
{
    app.UseStaticFiles();
    app.MapControllerRoute("default", "{controller=Pizza}/{action=Order}/{id?}");
    app.Run(); 
}
