using LAB5_Alonso.Application.DTOs;
using LAB5_Alonso.Application.UseCases.Estudiantes;
using Microsoft.AspNetCore.Mvc;

namespace LAB5_Alonso.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EstudianteController : ControllerBase
{
    private readonly ObtenerEstudiantesUseCase
        _obtenerEstudiantes;

    private readonly ObtenerEstudiantePorIdUseCase
        _obtenerPorId;

    private readonly CrearEstudianteUseCase
        _crearEstudiante;

    private readonly EliminarEstudianteUseCase
        _eliminarEstudiante;

    public EstudianteController(
        ObtenerEstudiantesUseCase obtenerEstudiantes,
        ObtenerEstudiantePorIdUseCase obtenerPorId,
        CrearEstudianteUseCase crearEstudiante,
        EliminarEstudianteUseCase eliminarEstudiante)
    {
        _obtenerEstudiantes = obtenerEstudiantes;
        _obtenerPorId = obtenerPorId;
        _crearEstudiante = crearEstudiante;
        _eliminarEstudiante = eliminarEstudiante;
    }

    [HttpGet]
    public async Task<IActionResult> ObtenerTodos()
    {
        return Ok(
            await _obtenerEstudiantes.EjecutarAsync()
        );
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> ObtenerPorId(int id)
    {
        var estudiante =
            await _obtenerPorId.EjecutarAsync(id);

        if (estudiante == null)
            return NotFound();

        return Ok(estudiante);
    }

    [HttpPost]
    public async Task<IActionResult> Crear(
        CrearEstudianteDto dto)
    {
        var estudiante =
            await _crearEstudiante.EjecutarAsync(dto);

        return Ok(estudiante);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Eliminar(int id)
    {
        var eliminado =
            await _eliminarEstudiante.EjecutarAsync(id);

        if (!eliminado)
            return NotFound();

        return NoContent();
    }
}