using Microsoft.EntityFrameworkCore;
using WebAppassignment14.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<InstituteDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("InstituteConStr")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
