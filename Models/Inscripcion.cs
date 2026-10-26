using System.ComponentModel.DataAnnotations;

namespace AquaVida.Models;

public class Inscripcion
{
    [Display(Name = "Nombre completo")]
    [Required(ErrorMessage = "Escribe tu nombre completo.")]
    [StringLength(80, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 80 caracteres.")]
    public string Nombre { get; set; } = string.Empty;

    [Display(Name = "Documento de identidad")]
    [Required(ErrorMessage = "Escribe tu documento de identidad.")]
    [StringLength(20, MinimumLength = 5, ErrorMessage = "Escribe un documento válido.")]
    public string Documento { get; set; } = string.Empty;

    [Display(Name = "Edad")]
    [Required(ErrorMessage = "Indica tu edad.")]
    [Range(4, 100, ErrorMessage = "La edad debe estar entre 4 y 100 años.")]
    public int? Edad { get; set; }

    [Display(Name = "Correo electrónico")]
    [Required(ErrorMessage = "Escribe tu correo electrónico.")]
    [EmailAddress(ErrorMessage = "Escribe una dirección de correo válida.")]
    public string Correo { get; set; } = string.Empty;

    [Display(Name = "Nivel de natación")]
    [Required(ErrorMessage = "Selecciona un nivel.")]
    [RegularExpression("^(Principiante|Intermedio|Avanzado)$", ErrorMessage = "Selecciona uno de los niveles disponibles.")]
    public string Nivel { get; set; } = string.Empty;

    [Display(Name = "Horario preferido")]
    [Required(ErrorMessage = "Selecciona un horario.")]
    [RegularExpression("^(Mañana|Tarde|Fin de semana)$", ErrorMessage = "Selecciona uno de los horarios disponibles.")]
    public string Horario { get; set; } = string.Empty;

    [Display(Name = "Comentarios adicionales")]
    [StringLength(300, ErrorMessage = "Los comentarios no pueden superar los 300 caracteres.")]
    public string? Comentarios { get; set; }
}
