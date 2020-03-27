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
    public class IndexModel : PageModel
    {
        public int SessionID { get; set; }
        private readonly BME77.Models.PaperContext _context;

        public IQueryable<Paper> PapersIQ { get; set; }
        public IndexModel(BME77.Models.PaperContext context)
        {
            _context = context;
        }
        public string searchString;
        public IList<Paper> Paper { get; set; }

        public async Task OnGetAsync(string search, string searchType)
        {
            searchString = search;
            Statistic statistic = new Statistic() { Time = DateTime.Now, Route = search == null ? "NULL" : search.ToString(), Page = "Paper" };
            _context.Statistics.Add(statistic);
            await _context.SaveChangesAsync();
            //Paper = await _context.Papers
            //    .Include(p => p.Session).ToListAsync();
            var papers = from m in _context.Papers select m;
            //string[] searchs = search.Split(' ');
            if (!String.IsNullOrEmpty(searchType))
            {
                if (searchType.Contains("title"))
                {
                    if (!String.IsNullOrEmpty(search))
                    {
                        papers = papers.Where(s => s.Title.Contains(search) || s.Author.Contains(search));
                    }
                }
                else
                {
                    if (!String.IsNullOrEmpty(searchType))
                    {
                        papers = papers.Where(s => s.Abstract.Contains(search));
                    }
                }
            }
            Paper = await papers.Include(p => p.Session).OrderBy(m=>m.TimeStart).ToListAsync();
        }
    }
}
