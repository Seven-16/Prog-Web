public class Media
{
    public int Id {get; set;}
    public string Nombre {get; set;} = string.Empty;
    public string Pais {get; set;} = string.Empty;
    public string Idioma {get; set;} = string.Empty;
    public string FotoUrl {get; set;} = string.Empty;
    public string Resumen {get; set;} = string.Empty;
    public List<Personaje> Personajes {get; set;} = new();
}