using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BME77.Models;

namespace BME77.Pages
{
    public class WorkshopModel : PageModel
    {
        private readonly BME77.Models.PaperContext _context;
        public int SessionID { get; set; }
        public IList<Paper> Papers { get; set; }
        public WorkshopModel(BME77.Models.PaperContext context)
        {
            _context = context;
        }

        public IList<Session> Session { get;set; }
        public IQueryable<Session> SessionsIQ { get; set; }
       
        public async Task OnGetAsync(int? id)
        {
           
            Statistic statistic = new Statistic() {Time=DateTime.Now, Route = id == null ? "NULL":id.ToString(),Page="Workshop" };
            _context.Statistics.Add(statistic);
            await    _context.SaveChangesAsync();
           
           
            SessionsIQ = _context.Sections.Where(m => m.IsWorkshop).OrderBy(m => m.TimeStart);
            Session = await SessionsIQ.AsNoTracking().ToListAsync();

            if (id != null)
            {
                SessionID = id.Value;
                var papers = from m in _context.Papers.Where(m => m.SessionID == id.Value) select m;
                Papers = await papers.ToListAsync();
            }
        }
    }
}
