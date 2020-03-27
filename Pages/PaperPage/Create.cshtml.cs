using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BME77.Models;

namespace BME77.Pages.PaperPage
{
    public class CreateModel : PageModel
    {
        private readonly BME77.Models.PaperContext _context;

        public CreateModel(BME77.Models.PaperContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {

            ViewData["SessionID"] = new SelectList(_context.Sections, "ID", "ID_C");
            return Page();
        }

        [BindProperty]
        public Paper Paper { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
        

            _context.Papers.Add(Paper);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}