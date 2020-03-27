using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BME77.Models;

namespace BME77.Pages.PaperPage
{
    public class DeleteModel : PageModel
    {
        private readonly BME77.Models.PaperContext _context;

        public DeleteModel(BME77.Models.PaperContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Paper Paper { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Paper = await _context.Papers
                .Include(p => p.Session).FirstOrDefaultAsync(m => m.ID == id);

            if (Paper == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Paper = await _context.Papers.FindAsync(id);

            if (Paper != null)
            {
                _context.Papers.Remove(Paper);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
