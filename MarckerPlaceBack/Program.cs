using MarckerPlaceBack.BLL.Services.Implementations;
using MarckerPlaceBack.BLL.Services.Interfaces;
using MarckerPlaceBack.Core.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Options;
using System;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DbConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(
        connectionString,
        sqlOptions => sqlOptions.MigrationsAssembly("MarckerPlaceBack")
        );
    options.ConfigureWarnings(x => x.Ignore(RelationalEventId.PendingModelChangesWarning));
 });

builder.Services.AddControllers();
builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<ICategoriesService, CategoriesService>();

var app = builder.Build();

app.Services.CreateScope().ServiceProvider.GetRequiredService<ApplicationDbContext>();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
