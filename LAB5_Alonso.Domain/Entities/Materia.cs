namespace LAB5_Alonso.Domain.Entities;

public class Materia
{
    public int IdMateria { get; set; }

    public int? IdCurso { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public Curso? IdCursoNavigation { get; set; }
}