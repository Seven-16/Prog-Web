using Microsoft.EntityFrameworkCore;

public class MediaDbContext : DbContext
{
    public DbSet<Media> Media {get; set;}
    public DbSet<Personaje> Personajes {get; set;}

    public MediaDbContext(DbContextOptions<MediaDbContext> options) : base(options){
    }
    
}