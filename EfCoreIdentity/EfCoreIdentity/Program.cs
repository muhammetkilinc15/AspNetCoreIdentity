using DataAccessLayer.Abstract;
using DataAccessLayer.Concreate;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<IAppUserDal,EfAppUserDal>();

// DbContext için baðlantý dizesini ekleyin
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// AutoMapper'ý hizmetlere ekleyin
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

// Identity hizmetlerini ekleyin
builder.Services.AddIdentity<AppUser, IdentityRole<Guid>>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 8;

    options.User.RequireUniqueEmail = true;

}).AddEntityFrameworkStores<ApplicationDbContext>() // DbContext ile kullanmak için
.AddDefaultTokenProviders(); // Giriþ bilgileri sýfýrlama vb. için varsayýlan token saðlayýcýlarýný ekler

builder.Services.AddScoped<IAppUserDal, EfAppUserDal>();

// MVC hizmetlerini ekleyin
builder.Services.AddControllers();

// API belgeleri için Swagger'ý ekleyin
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// MapControllers() metodunu buraya taþýyýn
app.MapControllers();

app.Run();
