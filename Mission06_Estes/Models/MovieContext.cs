using Microsoft.EntityFrameworkCore;

namespace Mission06_Estes.Models;

public class MovieContext: DbContext
{
    // Ctor
    public MovieContext(DbContextOptions<MovieContext> options) : base(options)
    {
        
    }
    
    // This helps build our database table when migrating
    public DbSet<Movie> Movies { get; set; }
}