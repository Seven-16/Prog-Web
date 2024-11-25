using Microsoft.EntityFrameworkCore;

public class VivenciaContext : DbContext
{
    public VivenciaContext(DbContextOptions<VivenciaContext> options) : base(options) {}
    public DbSet<Menol> Menores {get; set;}
    public DbSet<Vivencia> Vivencias {get; set;}
}