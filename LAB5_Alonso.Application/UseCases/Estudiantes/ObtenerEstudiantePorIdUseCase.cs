using LAB5_Alonso.Application.DTOs;
using LAB5_Alonso.Application.Interfaces;

namespace LAB5_Alonso.Application.UseCases.Estudiantes;

public class ObtenerEstudiantePorIdUseCase
{
    private readonly IEstudianteRepository _repository;

    public ObtenerEstudiantePorIdUseCase(
        IEstudianteRepository repository)
    {
        _repository = repository;
    }

    public async Task<EstudianteDto?> EjecutarAsync(int id)
    {
        var estudiante =
            await _repository.ObtenerPorIdAsync(id);

        if (estudiante == null)
            return null;

        return new EstudianteDto
        {
            IdEstudiante = estudiante.IdEstudiante,
            Nombre = estudiante.Nombre,
            Edad = estudiante.Edad,
            Direccion = estudiante.Direccion,
            Telefono = estudiante.Telefono,
            Correo = estudiante.Correo
        };
    }
}