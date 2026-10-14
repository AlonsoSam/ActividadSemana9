using LAB5_Alonso.Domain.Entities;

namespace LAB5_Alonso.Application.Interfaces;

public interface IEstudianteRepository
{
    Task<List<Estudiante>> ObtenerTodosAsync();

    Task<Estudiante?> ObtenerPorIdAsync(int id);

    Task<Estudiante> CrearAsync(Estudiante estudiante);

    Task EliminarAsync(Estudiante estudiante);
}