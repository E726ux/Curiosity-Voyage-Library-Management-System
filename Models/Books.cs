using System.ComponentModel.DataAnnotations;

namespace Curiosity_Voyage_Library_Management_System_1.Models;

public class Books
{
    public int BooksID {get; set;} //Primary Key
    
    [StringLength(20)]
    public string Title {get; set;} = string.Empty;

    [StringLength(50)]
    public string Author {get; set;} = string.Empty;

    [StringLength(20, MinimumLength = 10)]
    public string ISBN {get; set;} = string.Empty;
    
    [Range(00, 99)]
    public int PublishedYear {get; set;}

    // This property is optional (?) because Books can exist without being Borrowed. Borrowers can exist without Books.
public List<BookBorrowers>? BookBorrowers {get; set;} = default!; // Navigation property. A Borrower can get many Books.

    public static implicit operator Books(string v)
    {
        throw new NotImplementedException();
    }
}