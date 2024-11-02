using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Visita> Visitas {get; set;}
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=visitas.db");
    }
}