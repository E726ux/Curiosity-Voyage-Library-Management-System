using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyModel;

namespace Curiosity_Voyage_Library_Management_System_1.Models;

public class LibraryDbContext : DbContext
{
public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
                : base(options)
                {

                }  

    public DbSet<Library>? Books {get; set;} 
}

