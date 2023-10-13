using Microsoft.EntityFrameworkCore;
using MyWebAppTK.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MyWebAppTKDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyWebAppTK_DBCS"));
});
   
//this is my web app
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=AboutUs}/{action=About}/{id?}");

app.Run();
