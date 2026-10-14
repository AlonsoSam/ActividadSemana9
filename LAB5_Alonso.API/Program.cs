using LAB5_Alonso.Application.Interfaces;
using LAB5_Alonso.Application.UseCases.Estudiantes;
using LAB5_Alonso.Infrastructure.Data;
using LAB5_Alonso.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<Lab5Context>(options =>
    options.UseNpgsql(
        builder.Configuration
            .GetConnectionString("DefaultConnection")
    )
);

builder.Services.AddScoped<
    IEstudianteRepository,
    EstudianteRepository>();

builder.Services.AddScoped<
    ObtenerEstudiantesUseCase>();

builder.Services.AddScoped<
    ObtenerEstudiantePorIdUseCase>();

builder.Services.AddScoped<
    CrearEstudianteUseCase>();

builder.Services.AddScoped<
    EliminarEstudianteUseCase>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();