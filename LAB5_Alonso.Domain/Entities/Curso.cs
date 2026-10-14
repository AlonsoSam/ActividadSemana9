namespace LAB5_Alonso.Domain.Entities;

public class Curso
{
    public int IdCurso { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int Creditos { get; set; }

    public ICollection<Asistencia> Asistencia { get; set; }
        = new List<Asistencia>();

    public ICollection<Evaluacione> Evaluaciones { get; set; }
        = new List<Evaluacione>();

    public ICollection<Materia> Materia { get; set; }
        = new List<Materia>();

    public ICollection<Matricula> Matriculas { get; set; }
        = new List<Matricula>();
}