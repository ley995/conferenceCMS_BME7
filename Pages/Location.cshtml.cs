using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BME77.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BME77.Pages
{
    public class LocationModel : PageModel
    {
        private readonly BME77.Models.PaperContext _context;
        

        public LocationModel(BME77.Models.PaperContext context)
        {
            _context = context;
        }
        public async Task OnGetAsync()
        {
            Statistic statistic = new Statistic() { Time = DateTime.Now, Route =  "NULL" , Page = "Location" };
            _context.Statistics.Add(statistic);
            await _context.SaveChangesAsync();
        }
    }
}