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
    public class DetailsModel : PageModel
    {
        private readonly BME77.Models.PaperContext _context;

        public DetailsModel(BME77.Models.PaperContext context)
        {
            _context = context;
        }

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
    }
}
