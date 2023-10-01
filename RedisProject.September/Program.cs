using Microsoft.EntityFrameworkCore;
using RedisProject.September.Concrete;
using RedisProject.September.Data.Context;
using RedisProject.September.Interfaces;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

IConfiguration configuration = builder.Configuration;
var multiplexer = ConnectionMultiplexer.Connect(configuration.GetConnectionString("Redis"));
builder.Services.AddSingleton<IConnectionMultiplexer>(multiplexer);
builder.Services.AddSingleton<ICacheServices, CacheService>();
builder.Services.AddSingleton<ICategoryService, CategoryService>();
builder.Services.AddTransient<IProductService, ProductService>();

builder.Services.AddStackExchangeRedisCache(
    options =>
    {
        string? conneciton = builder.Configuration.GetConnectionString("Redis");
        options.Configuration = conneciton;
    });

builder.Services.AddDbContext<MyDBContext>(options =>
{
    string? connection1 = builder.Configuration.GetConnectionString("DB");
    options.UseSqlServer(connection1);
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
