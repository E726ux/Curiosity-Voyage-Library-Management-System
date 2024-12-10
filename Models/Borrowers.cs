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
}