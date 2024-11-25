using System.ComponentModel.DataAnnotations;

public class Vivencia
{
    public int Id {get; set;}
    public string? Titulo {get; set;}
    public string? Descripcion {get; set;}
    public DateTime Fecha {get; set;}
    public string? Imagen {get; set;}
    public int UsuarioId {get; set;}

}