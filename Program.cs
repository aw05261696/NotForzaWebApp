using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NotForza_web_app.Data;
using Downloads.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<CarDataContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("CarDataContext") ?? throw new InvalidOperationException("Connection string 'CarDataContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();