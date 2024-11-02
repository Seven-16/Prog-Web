using System.ComponentModel.DataAnnotations;
public class Visita
{
    public int Id {get; set;}

    //Validacion del numero de telefono.
    [Required(ErrorMessage = "Número de teléfono obligatorio")]
    [Phone(ErrorMessage = "Ingrese número de teléfono válido")]
    public string ?Telefono {get; set;}

    //Validacion de Nombre
    [Required(ErrorMessage = "Nombre obligatorio")]
    [StringLength(50, ErrorMessage = "El nombre debe tener un máximo de 50 caracteres")]
    public string ?Nombre {get; set;}

    //Validacion de Apellido
    [Required(ErrorMessage = "Apellido Obligatorio")]
    [StringLength(50, ErrorMessage = "El apellido debe tener un máximo de 50 carácteres")]
    public string ?Apellido {get; set;}

    //Validacion de Correo Electrónico
    [Required(ErrorMessage = "Correo obligatorio")]
    [EmailAddress(ErrorMessage = "Ingrese un correo electrónico válido")]
    public string ?Correo {get; set;}

}