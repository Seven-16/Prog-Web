public class Videojuego
{
    public int id {get; set;}
    public string? Nombre {get; set;}
    public string? Desarrollador {get; set;}
    public int PlatformId {get; set;}
    public Plataforma? Plataforma {get; set;}
    public string? Genero {get; set;}
    public DateTime Fecha {get; set;}
    public string? CoverImage {get; set;}
    public string? Descripcion {get; set;}
    public List<Personaje> Personajes {get; set;} = new List<Personaje>();
}