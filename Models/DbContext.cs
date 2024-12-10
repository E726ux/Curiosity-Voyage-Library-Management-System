using Microsoft.EntityFrameworkCore;

namespace Curiosity_Voyage_Library_Management_System_1.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
    {

    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BookBorrower>().HasKey(s => new {s.BooksID, s.BorrowersID});
    }

    public DbSet<Books>? Books {get; set;}
    public DbSet<Borrowers>? Borrowers {get; set;}
    public DbSet<BookBorrowers>? BookBorrowers {get; set;}
}

public class BookBorrowers
{
}