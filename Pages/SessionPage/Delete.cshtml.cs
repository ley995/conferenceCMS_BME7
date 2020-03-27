using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BME77.Models;

namespace BME77.Pages.SessionPage
{
    public class DeleteModel : PageModel
    {
        private readonly BME77.Models.PaperContext _context;

        public DeleteModel(BME77.Models.PaperContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Session Session { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Session = await _context.Sections.FirstOrDefaultAsync(m => m.ID == id);

            if (Session == null)
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

            Session = await _context.Sections.FindAsync(id);

            if (Session != null)
            {
                _context.Sections.Remove(Session);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
