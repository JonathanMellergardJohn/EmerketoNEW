using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Emerketo.Areas.Identity.Data;
using Emerketo.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("EmerketoDbContextConnection") ?? throw new InvalidOperationException("Connection string 'EmerketoDbContextConnection' not found.");

builder.Services.AddDbContext<EmerketoDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<EmerketoUser>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<EmerketoDbContext>();

builder.Services.AddScoped<IProductRepository, ProductRepository>();
// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.MapRazorPages();

DbInitializer.Seed(app);

app.Run();
