using LAB5_Alonso.Application.Interfaces;

namespace LAB5_Alonso.Application.UseCases.Estudiantes;

public class EliminarEstudianteUseCase
{
    private readonly IEstudianteRepository _repository;

    public EliminarEstudianteUseCase(
        IEstudianteRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> EjecutarAsync(int id)
    {
        var estudiante =
            await _repository.ObtenerPorIdAsync(id);

        if (estudiante == null)
            return false;

        await _repository.EliminarAsync(estudiante);

        return true;
    }
}