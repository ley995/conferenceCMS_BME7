using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BME77.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BME77.Pages
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
        public IQueryable<Session> SessionsIQ { get; set; }
        public IQueryable<Paper> PapersIQ { get; set; }
        public IList<Paper> OnGoingPaper { get; set; }
        
        public async Task OnGetAsync(int? id)
        {
            Statistic statistic = new Statistic() { Time = DateTime.Now, Route = id == null ? "NULL" : id.ToString(), Page = "Index" };
            _context.Statistics.Add(statistic);
            await _context.SaveChangesAsync();
            //Session = await _context.Sections.Where(m=>m.TimeStart.Day==DateTime.Now.Day).ToListAsync();
            int day = DateTime.Now.Day;
            SessionsIQ = _context.Sections.Where(m => m.TimeStart.Day==(day < 27?27: day)).OrderBy(m => m.TimeStart);
            Session =await SessionsIQ.AsNoTracking().ToListAsync();          
            if (id != null)
            {
                SessionID = id.Value;
                PapersIQ = from m in _context.Papers.Where(m => m.SessionID == id.Value).OrderBy(m=>m.TimeStart) select m;
                Papers = await PapersIQ.AsNoTracking().ToListAsync();
            }
            //OnGoingPaper = await _context.Papers.Where(m => (m.TimeStart < DateTime.Now && m.TimeEnd > DateTime.Now)).ToListAsync();
        }
    }
   
}
