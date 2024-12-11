using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Curiosity_Voyage_Library_Management_System_1.Models;

namespace Curiosity_Voyage_Library_Management_System_1.Pages.Borrowers
{
    public class EditModel : PageModel
    {
        private readonly Curiosity_Voyage_Library_Management_System_1.Models.AppDbContext _context;

        public EditModel(Curiosity_Voyage_Library_Management_System_1.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Borrowers Borrowers { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var borrowers =  await _context.Borrowers.FirstOrDefaultAsync(m => m.BorrowersID == id);
            if (borrowers == null)
            {
                return NotFound();
            }
            Borrowers = borrowers;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Borrowers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BorrowersExists(Borrowers.BorrowersID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BorrowersExists(int id)
        {
            return _context.Borrowers.Any(e => e.BorrowersID == id);
        }
    }
}
