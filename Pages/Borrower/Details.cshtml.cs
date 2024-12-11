using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Curiosity_Voyage_Library_Management_System_1.Models;

namespace Curiosity_Voyage_Library_Management_System_1.Pages.Borrower
{
    public class DetailsModel : PageModel
    {
        private readonly Curiosity_Voyage_Library_Management_System_1.Models.AppDbContext _context;

        public DetailsModel(Curiosity_Voyage_Library_Management_System_1.Models.AppDbContext context)
        {
            _context = context;
        }

        public Borrowers Borrowers { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var borrowers = await _context.Borrowers.FirstOrDefaultAsync(m => m.BorrowersID == id);

            if (borrowers is not null)
            {
                Borrowers = borrowers;

                return Page();
            }

            return NotFound();
        }
    }
}
