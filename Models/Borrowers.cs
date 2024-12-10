using System.ComponentModel.DataAnnotations;

namespace Curiosity_Voyage_Library_Management_System_1.Models;

public class Borrowers
{
    [Required]
    public int BorrowersID {get; set;}

    [Required]
    [StringLength(30)]
    public string Name {get; set;} = string.Empty;

    [StringLength(50)]
    public string Email {get; set;} = string.Empty;

    [StringLength(10)]
    public string PhoneNumber {get; set;} = string.Empty;

    // This property is optional (?) because Books can exist without being Borrowed. Borrowers can exist without Books.
public List<BookBorrower>? BookBorrowers {get; set;} = default!; // Navigation property. A Borrower can get many Books.
}

public class BookBorrower
{
    public int BorrowersID {get; set;}
    public int BooksID {get; set;}
    public Books Books {get; set;} = default!;
    public Borrowers Borrowers {get; set;} = default!;
}