using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BME77.Models;

namespace BME77.Pages.PaperPage
{
    public class EditModel : PageModel
    {
        private readonly BME77.Models.PaperContext _context;

        public EditModel(BME77.Models.PaperContext context)
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
           ViewData["SessionID"] = new SelectList(_context.Sections, "ID", "ID");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Paper).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaperExists(Paper.ID))
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

        private bool PaperExists(int id)
        {
            return _context.Papers.Any(e => e.ID == id);
        }
    }
}
