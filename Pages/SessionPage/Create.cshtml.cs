using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BME77.Models;

namespace BME77.Pages.SessionPage
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
            return Page();
        }

        [BindProperty]
        public Session Session { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Sections.Add(Session);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Create");
        }
    }
}