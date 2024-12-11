using Curiosity_Voyage_Library_Management_System_1.Models;
using Microsoft.EntityFrameworkCore;

namespace BookBorrower.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

        if (context.BookBorrower.Any())
        {
            return;
        }

        List<Borrowers> Name = new List<Borrowers>
        {
            new Borrowers { BorrowersID = 123, Name = "George", Email = "George@gmail.com", PhoneNumber = "Number", },
            new Borrowers { BorrowersID = 145, Name = "Eric", Email = "Eric@gmail.com", PhoneNumber = "Number", },
            new Borrowers { BorrowersID = 798, Name = "Jacob", Email = "Jacob@gmail.com", PhoneNumber = "Number", },
            new Borrowers { BorrowersID = 467, Name = "Bear", Email = "Bear@gmail.com", PhoneNumber = "Number", },
            new Borrowers { BorrowersID = 987, Name = "Lolly", Email = "Lolly@gmail.com", PhoneNumber = "Number", },
            new Borrowers { BorrowersID = 567, Name = "Aris", Email = "Aris@gmail.com", PhoneNumber = "Number", },
            new Borrowers { BorrowersID = 673, Name = "Xander", Email = "Xander@gmail.com", PhoneNumber = "Number", },
            new Borrowers { BorrowersID = 413, Name = "William", Email = "William@gmail.com", PhoneNumber = "Number", },
            new Borrowers { BorrowersID = 879, Name = "Tim", Email = "Tim@gmail.com", PhoneNumber = "Number", },
            new Borrowers { BorrowersID = 908, Name = "Jim", Email = "Jim@gmail.com", PhoneNumber = "Number", },
            new Borrowers { BorrowersID = 675, Name = "Quinn", Email = "Quinn@gmail.com", PhoneNumber = "Number", },
            new Borrowers { BorrowersID = 324, Name = "Zach", Email = "Zach@gmail.com", PhoneNumber = "Number", },
            new Borrowers { BorrowersID = 222, Name = "Danny", Email = "Danny@gmail.com", PhoneNumber = "Number", },
            new Borrowers { BorrowersID = 539, Name = "Larry", Email = "Larry@gmail.com", PhoneNumber = "Number", },
            new Borrowers { BorrowersID = 893, Name = "Hammond", Email = "Hammond@gmail.com", PhoneNumber = "Number", },
            new Borrowers { BorrowersID = 243, Name = "Jeremy", Email = "Jeremy@gmail.com", PhoneNumber = "Number", },
            new Borrowers { BorrowersID = 104, Name = "Richard", Email = "Richard@gmail.com", PhoneNumber = "Number", },
            new Borrowers { BorrowersID = 922, Name = "Perry", Email = "Perry@gmail.com", PhoneNumber = "Number", },
            new Borrowers { BorrowersID = 555, Name = "Naomi", Email = "Naomi@gmail.com", PhoneNumber = "Number", },
            new Borrowers { BorrowersID = 111, Name = "Kim", Email = "Kim@gmail.com", PhoneNumber = "Number", },
            new Borrowers { BorrowersID = 277, Name = "Azazel", Email = "Azazel@gmail.com", PhoneNumber = "Number", },
            new Borrowers { BorrowersID = 947, Name = "Amber", Email = "Amber@gmail.com", PhoneNumber = "Number", },
            new Borrowers { BorrowersID = 639, Name = "Esther", Email = "Esther@gmail.com", PhoneNumber = "Number", },
            new Borrowers { BorrowersID = 753, Name = "Calvin", Email = "Calvin@gmail.com", PhoneNumber = "Number", },
            new Borrowers { BorrowersID = 282, Name = "Sally", Email = "Sally@gmail.com", PhoneNumber = "Number", },
            
        };
        context.AddRange(Name);
        context.SaveChanges();

        List<Books> Title = new List<Books>
        {
            new Books { BooksID = 1,  Title = "Charlotte's Web", Author = "E.B. White", ISBN = "13243546890", PublishedYear = 1952, },
            new Books { BooksID = 2,  Title = "Old Yeller", Author = "Fred Gipson", ISBN = "2468954710", PublishedYear = 1942, },
            new Books { BooksID = 3,  Title = "The Stand", Author = "Stephen King", ISBN = "3564829107", PublishedYear = 1978, },
            new Books { BooksID = 4,  Title = "Calvin and Hobbes", Author = "Bill Watterson", ISBN = "4657832901", PublishedYear = 1985, },
            new Books { BooksID = 5,  Title = "Hatchet", Author = "Gary Paulsen", ISBN = "4657829130", PublishedYear = 1986, },
            new Books { BooksID = 6,  Title = "Road Map", Author = "Danny Brooks", ISBN = "8912345983", PublishedYear = 2020, },
            new Books { BooksID = 7,  Title = "The Road", Author = "Cormac McCarthy", ISBN = "1928375841", PublishedYear = 2009, },
            new Books { BooksID = 8,  Title = "Big Red", Author = "Jim Kjelgaard", ISBN = "0193567294", PublishedYear = 2011, },
            new Books { BooksID = 9,  Title = "Animal Farm", Author = "George Orwell", ISBN = "7924314206", PublishedYear = 1945, },
            new Books { BooksID = 10,  Title = "To Kill a Mocking Bird", Author = "Harper Lee", ISBN = "7102573910", PublishedYear = 1958, },
        };
        context.AddRange(Title);
        context.SaveChanges();

        List<BookBorrowers> bookborrowers = new List<BookBorrowers>
        {
            new BookBorrowers {BorrowersID = 145, BooksID = 9, Names = "Animal Farm", BorrowerName = "Eric", },
            new BookBorrowers {BorrowersID = 555, BooksID = 2, Names = "Old Yeller", BorrowerName = "Naomi", },
            new BookBorrowers {BorrowersID = 753, BooksID = 7, Names = "The Road", BorrowerName = "Calvin", },
            new BookBorrowers {BorrowersID = 277, BooksID = 4, Names = "Calvin and Hobbes", BorrowerName = "Azazel", },
            new BookBorrowers {BorrowersID = 282, BooksID = 3, Names = "The Stand", BorrowerName = "Sally", },
        };
    }
}
