public class Tardanza
{
    public int Id {get; set;}
    public Estudiante ?Estudiante {get; set;}
    public DateTime FechaHora {get; set;}
    public string ?Motivo {get; set;}
}