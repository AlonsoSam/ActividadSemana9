using LAB5_Alonso.Application.DTOs;
using LAB5_Alonso.Application.Interfaces;
using LAB5_Alonso.Domain.Entities;

namespace LAB5_Alonso.Application.UseCases.Estudiantes;

public class CrearEstudianteUseCase
{
    private readonly IEstudianteRepository _repository;

    public CrearEstudianteUseCase(
        IEstudianteRepository repository)
    {
        _repository = repository;
    }

    public async Task<EstudianteDto> EjecutarAsync(
        CrearEstudianteDto dto)
    {
        var estudiante = new Estudiante
        {
            Nombre = dto.Nombre,
            Edad = dto.Edad,
            Direccion = dto.Direccion,
            Telefono = dto.Telefono,
            Correo = dto.Correo
        };

        var creado =
            await _repository.CrearAsync(estudiante);

        return new EstudianteDto
        {
            IdEstudiante = creado.IdEstudiante,
            Nombre = creado.Nombre,
            Edad = creado.Edad,
            Direccion = creado.Direccion,
            Telefono = creado.Telefono,
            Correo = creado.Correo
        };
    }
}