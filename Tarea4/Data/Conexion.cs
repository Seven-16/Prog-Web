using Microsoft.Data.Sqlite;
using System.Data.SqlClient;

public class Conexion{
    private string Media;
    private static Conexion Con = null;

    private Conexion(){
        this.Media = "./Media.db";
    }
    public SqliteConnection CrearConexion(){
        SqliteConnection Cadena = new SqliteConnection();
        return Cadena;
    }
}