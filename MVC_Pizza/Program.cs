using Microsoft.EntityFrameworkCore;
using MVC_Pizza.DataBase;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllersWithViews();
    builder.Services.AddDbContext<PizzaDBContext>(options =>
    {
        options.UseSqlite("Data source = pizza.db");
    });
}
var app = builder.Build();
{
    app.UseStaticFiles();
    app.MapControllerRoute("default", "{controller=Pizza}/{action=Order}/{id?}");
    app.Run(); 
}
