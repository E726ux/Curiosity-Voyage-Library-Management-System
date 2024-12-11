using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Curiosity_Voyage_Library_Management_System_1.Models;

namespace Curiosity_Voyage_Library_Management_System_1.Pages.Borrower
{
    public class CreateModel : PageModel
    {
        private readonly Curiosity_Voyage_Library_Management_System_1.Models.AppDbContext _context;

        public CreateModel(Curiosity_Voyage_Library_Management_System_1.Models.AppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Borrowers Borrowers { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Borrowers.Add(Borrowers);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
