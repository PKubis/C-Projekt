using _4Ballers.Data;
using _4Ballers.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews();

// Rejestrowanie TeamInfoProvider i IConfiguration w kontenerze DI
builder.Services.AddScoped<TeamInfoProvider>();
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

// Konfiguracja ciasteczek logowania
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Identity/Account/Login";
});

var app = builder.Build();


// Konfiguracja potoku ¿¹dañ HTTP
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();
app.MapControllerRoute(
    name: "public",
    pattern: "Public/{**page}",
    defaults: new { controller = "Public", action = "Index" });
app.MapControllerRoute(
    name: "private",
    pattern: "Private/{**page}",
    defaults: new { controller = "Private", action = "Index" });
app.MapControllerRoute(
    name: "teams",
    pattern: "Public/Teams",
    defaults: new { controller = "Public", action = "Teams" });

app.MapControllerRoute(
    name: "productDetails",
    pattern: "Private/Details/{id}",
    defaults: new { controller = "Products", action = "Details" });

app.MapControllerRoute(
    name: "products",
    pattern: "Products/{action=Index}/{id?}",
    defaults: new { controller = "Products" });
app.MapControllerRoute(
    name: "orders",
    pattern: "Orders/{action=Index}/{id?}",
    defaults: new { controller = "Orders" });


app.Run();
