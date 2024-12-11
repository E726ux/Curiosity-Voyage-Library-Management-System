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
    public class IndexModel : PageModel
    {
        private readonly Curiosity_Voyage_Library_Management_System_1.Models.AppDbContext _context;

        public IndexModel(Curiosity_Voyage_Library_Management_System_1.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Borrowers> Borrowers { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Borrowers = await _context.Borrowers.ToListAsync();
        }

        [BindProperty(SupportsGet = true)]
public int PageNum {get; set;} = 1;
public int PageSize {get; set;} = 10;
public int TotalPages {get; set;}
    }
}
