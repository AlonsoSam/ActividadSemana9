namespace LAB5_Alonso.Domain.Entities;

public class Estudiante
{
    public int IdEstudiante { get; set; }

    public string Nombre { get; set; } = null!;

    public int Edad { get; set; }

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public string? Correo { get; set; }

    public ICollection<Asistencia> Asistencia { get; set; }
        = new List<Asistencia>();

    public ICollection<Evaluacione> Evaluaciones { get; set; }
        = new List<Evaluacione>();

    public ICollection<Matricula> Matriculas { get; set; }
        = new List<Matricula>();
}