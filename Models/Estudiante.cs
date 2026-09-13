using System.ComponentModel.DataAnnotations;

namespace ProgramacionV.Api.Models;

public class Estudiante
{
    public int Id { get; set; }

    public string Documento { get; set; } = string.Empty;

    public string Nombre { get; set; } = string.Empty;

    public string Correo { get; set; } = string.Empty;

    public int ProgramaAcademicoId { get; set; }

    [Required(ErrorMessage = "El teléfono es obligatorio.")]
    [Phone(ErrorMessage = "El teléfono no tiene un formato válido.")]
    public string? Telefono { get; set; }

    public ProgramaAcademico? ProgramaAcademico { get; set; }
}
