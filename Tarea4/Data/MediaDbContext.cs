using Microsoft.EntityFrameworkCore;

public class MediaDbContext : DbContext
{
    public DbSet<Media> Medias {get; set;}
    public DbSet<Personaje> Personajes {get; set;}

    public MediaDbContext(DbContextOptions<MediaDbContext> options) : base(options){
    }
    
}