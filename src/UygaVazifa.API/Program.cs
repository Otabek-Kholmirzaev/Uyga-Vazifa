using FurnitureShop.Common.Helpers;
using Microsoft.EntityFrameworkCore;
using UygaVazifa.API.Data;
using UygaVazifa.API.Entities;
using UygaVazifa.API.Repositories;
using UygaVazifa.API.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection"));
});

builder.Services.AddScoped<IGenericRepository<Homework>, GenericRepository<Homework>>();
builder.Services.AddScoped<IGenericRepository<Comment>, GenericRepository<Comment>>();
builder.Services.AddScoped<IGenericRepository<Group>, GenericRepository<Group>>();
builder.Services.AddScoped<IGenericRepository<StudentAnswer>, GenericRepository<StudentAnswer>>();
builder.Services.AddScoped<IGenericRepository<UserGroup>, GenericRepository<UserGroup>>();

builder.Services.AddIdentity<User, Role>(options =>
    {
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequiredLength = 6;
        options.Password.RequireUppercase = false;
        options.Password.RequireDigit = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireLowercase = false;
    })
    .AddEntityFrameworkStores<AppDbContext>();

var app = builder.Build();

if (((IApplicationBuilder)app).ApplicationServices.GetService<IHttpContextAccessor>() != null)
    HttpContextHelper.Accessor =
        ((IApplicationBuilder)app).ApplicationServices.GetRequiredService<IHttpContextAccessor>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();