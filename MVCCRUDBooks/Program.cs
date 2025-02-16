using Microsoft.EntityFrameworkCore;
using MVCCRUDBooks.Controllers.Data;
using Microsoft.Extensions.DependencyInjection;
using MVCCRUDBooks.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MVCCRUDBooksContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MVCCRUDBooksContext") ?? throw new InvalidOperationException("Connection string 'MVCCRUDBooksContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<MVCCRUDBooksDbContext>(p => p.UseSqlServer(builder.Configuration.GetConnectionString("MVCCRUDBooksStrConnection")));

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
