using _4Ballers.Data;
using _4Ballers.Models;  // Dodaj ten using
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

// Dodaj tê linijkê, aby zarejestrowaæ TeamInfoProvider w kontenerze DI
builder.Services.AddScoped<TeamInfoProvider, TeamInfoProvider>();

// Ustaw domyœln¹ œcie¿kê logowania
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Identity/Account/Login";
});

// Configure the HTTP request pipeline.
var app = builder.Build();

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

app.Run();