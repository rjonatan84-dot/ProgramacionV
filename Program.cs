using Microsoft.EntityFrameworkCore;
using ProgramacionV.Api.Data;
using ProgramacionV.Api.Repositories;
using Scalar.AspNetCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Habilita los controladores.
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler =
            ReferenceHandler.IgnoreCycles;
    });

// Habilita OpenAPI.
builder.Services.AddOpenApi();

// Configura SQLite.
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlite(
        builder.Configuration.GetConnectionString(
            "DefaultConnection"));
});

// Registra los repositorios.
builder.Services.AddScoped<ProgramaRepository>();
builder.Services.AddScoped<EstudianteRepository>();

var app = builder.Build();

app.MapOpenApi();

app.MapScalarApiReference(options =>
{
    options.WithTitle(
        "Programación V - API Gestión Académica");
});

app.MapGet("/", () =>
    Results.Redirect("/scalar/v1"));

//app.UseHttpsRedirection();

app.MapControllers();

app.Run();