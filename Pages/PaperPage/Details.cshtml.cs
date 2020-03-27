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
    public class DetailsModel : PageModel
    {
        private readonly BME77.Models.PaperContext _context;

        public DetailsModel(BME77.Models.PaperContext context)
        {
            _context = context;
        }

        public Paper Paper { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Statistic statistic = new Statistic() { Time = DateTime.Now, Route = id == null ? "NULL" : id.ToString(), Page = "PaperDetails" };
            _context.Statistics.Add(statistic);
            await _context.SaveChangesAsync();
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
    }
}
