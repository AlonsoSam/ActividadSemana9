namespace LAB5_Alonso.Domain.Entities;

public class Matricula
{
    public int IdMatricula { get; set; }

    public int? IdEstudiante { get; set; }

    public int? IdCurso { get; set; }

    public string? Semestre { get; set; }

    public Curso? IdCursoNavigation { get; set; }

    public Estudiante? IdEstudianteNavigation { get; set; }
}