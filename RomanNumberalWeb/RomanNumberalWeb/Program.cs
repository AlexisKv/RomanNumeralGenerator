using RomanNumeral.Core.Models;
using Microsoft.EntityFrameworkCore;
using RomanNumeral.Core.Services;
using RomanNumeral.Data;
using RomanNumeral.Services;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<RomanNumberalWebContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("RomanNumberalWebContext") ?? throw new InvalidOperationException("Connection string 'RomanNumberalWebContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IRomanNumeralDbContext, RomanNumberalWebContext>();
builder.Services.AddScoped<IDbService, DbService>();
builder.Services.AddScoped<IEntityService<Logs>, EntityService<Logs>>();
builder.Services.AddScoped<ILogsServices, LogsServices>();
builder.Services.AddScoped<IRomanNumeralGenerator, GeneratorServices>();

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
    pattern: "{controller=RomanConverter}/{action=Create}/{id?}");

app.Run();
