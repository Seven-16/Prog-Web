public class Personaje
{
    public int Id {get; set;}
    public string? Nombre {get; set;}
    public string? Alias {get; set;}
    public string? Role {get; set;}
    public string? HabilidadEspecial {get; set;}
    public string? ArmaFavorita {get; set;}
    public int PowerLevel {get; set;}
    public string? PersonajeImg {get; set;}
    public int VideojuegoId {get; set;}
    public Videojuego? Videojuego {get; set;}
}