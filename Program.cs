using Microsoft.EntityFrameworkCore;
using Curiosity_Voyage_Library_Management_System_1.Models;
using BookBorrower.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<Borrower>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("BookBorrowerConnection")));

var app = builder.Build();

// Seed Data
using (var scope = app.Services.CreateScope())
{
    SeedData.Initialize(scope.ServiceProvider);
}

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
