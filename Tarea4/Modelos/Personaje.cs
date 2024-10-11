public class Personaje
{
    public int Id {get; set;}
    public string Nombre {get; set;} = string.Empty;
    public string Apodo {get; set;} = string.Empty;
    public string Raza {get; set;} = string.Empty;
    public string FotoUrl {get; set;} = string.Empty;
    public int Edad {get; set;}
    public string Poder {get; set;} = string.Empty;

    public int MediaId {get; set;}
    public Media Media {get; set;} 
}