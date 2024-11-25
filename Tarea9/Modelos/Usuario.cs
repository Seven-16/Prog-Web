using System.ComponentModel.DataAnnotations;
public class Menol
{
    public int Id {get; set;}

    [Required(ErrorMessage = "Ingresar nombre de usuario")]
    public string? Usuario {get; set;}

    [EmailAddress(ErrorMessage = "Correo no válido")]
    [Required(ErrorMessage = "Ingresar correo ")]
    public string? Correo {get; set;}

    [Required(ErrorMessage = "Ingresar Clave")]
    [MinLength(6, ErrorMessage = "La clave debe tener al menos 6 caracteres")]
    public string? Clave {get; set;}

}