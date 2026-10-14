using LAB5_Alonso.Application.DTOs;
using LAB5_Alonso.Application.Interfaces;

namespace LAB5_Alonso.Application.UseCases.Estudiantes;

public class ObtenerEstudiantesUseCase
{
    private readonly IEstudianteRepository _repository;

    public ObtenerEstudiantesUseCase(
        IEstudianteRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<EstudianteDto>> EjecutarAsync()
    {
        var estudiantes =
            await _repository.ObtenerTodosAsync();

        return estudiantes.Select(e => new EstudianteDto
        {
            IdEstudiante = e.IdEstudiante,
            Nombre = e.Nombre,
            Edad = e.Edad,
            Direccion = e.Direccion,
            Telefono = e.Telefono,
            Correo = e.Correo
        }).ToList();
    }
}