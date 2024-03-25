using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StoreApp.Data.Abstract;
using StoreApp.Data.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<StoreDbContext>(Options => Options.UseSqlite(builder.Configuration["ConnectionStrings:Sqlite"], b=> b.MigrationsAssembly("StoreApp.Web")));
builder.Services.AddScoped<IStoreRepository, EFStoreRepository>();

var app = builder.Build();

app.UseStaticFiles();
app.MapDefaultControllerRoute();

app.Run();
