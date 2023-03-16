using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using SPAECom.Api.Catalog.Data;
using SPAECom.Api.Catalog.Repository;
using SPAECom.Api.Catalog.Repository.Provider;


    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    builder.Services.AddDbContext<DatabaseContext>(options => {
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    });

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Services.AddTransient<IProductRepository, ProductRepository>();

    var app = builder.Build();

    if (app.Environment.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SPAECom.Api.Catalog v1"));
    }

    app.UseRouting();
    app.UseHttpsRedirection();

    var summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    app.MapGet("/weatherforecast", () =>
    {
        var forecast = Enumerable.Range(1, 5).Select(index =>
            new WeatherForecast
            (
                DateTime.Now.AddDays(index),
                Random.Shared.Next(-20, 55),
                summaries[Random.Shared.Next(summaries.Length)]
            ))
            .ToArray();
        return forecast;
    })
    .WithName("GetWeatherForecast");

    app.Run();

    internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
    {
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }