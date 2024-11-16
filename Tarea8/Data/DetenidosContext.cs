using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

public class DetenidosContext : DbContext
{
    public DetenidosContext(DbContextOptions<DetenidosContext> options) : base(options) { }

    public DbSet<Detenido> Detenidos { get; set; }
    
}