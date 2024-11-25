public class Servicio
{
    private readonly VivenciaContext _context;

    public Servicio(VivenciaContext context)
    {
        _context = context;
    }

    //Crear Usuario
    public void CrearUsuario(Menol usuario)
    {
        _context.Menores.AddAsync(usuario);
        _context.SaveChangesAsync();
    }

    //Obtener Usuario
    public Menol? ObtenerUsuario(string usuario, string clave)
    {
        return _context.Menores.FirstOrDefault(u => u.Usuario == usuario && u.Clave == clave);
    }

    //Crear Vivencia
    public void CrearVivencia(Vivencia vivencia)
    {
        _context.Vivencias.AddAsync(vivencia);
        _context.SaveChangesAsync();
    }

    //Obtener Vivencia
    public List<Vivencia> ObtenerVivencias(int usuarioId)
    {
        return _context.Vivencias.Where(v => v.UsuarioId == usuarioId).ToList();
    }

    //Borrar todas las vivencias
    public void BorrarVivencias(int usuarioId)
    {
        var vivencias = _context.Vivencias.Where(v => v.UsuarioId == usuarioId).ToList();
        _context.Vivencias.RemoveRange(vivencias);
        _context.SaveChangesAsync();
    }


}