public class Plataforma
{
    public int Id {get; set;}
    public string? Nombre {get; set;}
    public bool Activa {get; set;}
    public List<Videojuego> Videojuegos {get; set;} = new List<Videojuego>();
}