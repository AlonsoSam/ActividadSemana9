namespace LAB5_Alonso.Domain.Entities;

public class Asistencia
{
    public int IdAsistencia { get; set; }

    public int? IdEstudiante { get; set; }

    public int? IdCurso { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Estado { get; set; }

    public Curso? IdCursoNavigation { get; set; }

    public Estudiante? IdEstudianteNavigation { get; set; }
}