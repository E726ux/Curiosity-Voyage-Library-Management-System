using System.ComponentModel.DataAnnotations;

namespace Curiosity_Voyage_Library_Management_System_1;

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
}