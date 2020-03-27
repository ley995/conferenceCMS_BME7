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
    public class IndexModel : PageModel
    {
        private readonly BME77.Models.PaperContext _context;
        public int SessionID { get; set; }
        public IList<Paper> Papers { get; set; }
        public IndexModel(BME77.Models.PaperContext context)
        {
            _context = context;
        }

        public IList<Session> Session { get; set; }

        public async Task OnGetAsync(int? id, int? date, string type)
        {
            Statistic statistic = new Statistic() { Time = DateTime.Now, Route = id == null ? "NULL" : id.ToString() + "/" + date == null ? "DATE" : date.ToString(), Page = "Session" };
            _context.Statistics.Add(statistic);
            await _context.SaveChangesAsync();
            if (!String.IsNullOrEmpty(type))
            {
                if (type == "poster")
                {
                    if (date != null)
                    {
                        Session = await _context.Sections.Where(m => !m.IsBreak && m.TimeStart.Day == date && m.IsOral).ToListAsync();
                    }
                    else
                    {
                        Session = await _context.Sections.Where(m => !m.IsBreak && m.IsOral).ToListAsync();
                    }
                }
            }
            else
            {
                if (date != null)
                {
                    Session = await _context.Sections.Where(m => !m.IsBreak && m.TimeStart.Day == date).ToListAsync();
                }
                else
                {
                    Session = await _context.Sections.Where(m => !m.IsBreak).ToListAsync();
                }
            }



            if (id != null)
            {
                SessionID = id.Value;
                var papers = from m in _context.Papers.Where(m => m.SessionID == id.Value) select m;
                Papers = await papers.ToListAsync();
            }
        }
    }
}
