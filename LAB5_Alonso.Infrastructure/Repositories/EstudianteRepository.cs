using LAB5_Alonso.Application.Interfaces;
using LAB5_Alonso.Domain.Entities;
using LAB5_Alonso.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LAB5_Alonso.Infrastructure.Repositories;

public class EstudianteRepository : IEstudianteRepository
{
    private readonly Lab5Context _context;

    public EstudianteRepository(Lab5Context context)
    {
        _context = context;
    }

    public async Task<List<Estudiante>> ObtenerTodosAsync()
    {
        return await _context.Estudiantes
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Estudiante?> ObtenerPorIdAsync(int id)
    {
        return await _context.Estudiantes
            .FirstOrDefaultAsync(e =>
                e.IdEstudiante == id);
    }

    public async Task<Estudiante> CrearAsync(
        Estudiante estudiante)
    {
        _context.Estudiantes.Add(estudiante);

        await _context.SaveChangesAsync();

        return estudiante;
    }

    public async Task EliminarAsync(
        Estudiante estudiante)
    {
        _context.Estudiantes.Remove(estudiante);

        await _context.SaveChangesAsync();
    }
}