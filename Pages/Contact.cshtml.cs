using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BME77.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BME77.Pages
{
    public class ContactModel : PageModel
    {
        private readonly BME77.Models.PaperContext _context;
       
        public ContactModel(BME77.Models.PaperContext context)
        {
            _context = context;
        }
        public string Message { get; set; }

        public async Task OnGetAsync()
        {
            Statistic statistic = new Statistic() { Time = DateTime.Now, Route = "NULL" , Page = "Contact" };
            _context.Statistics.Add(statistic);
            await _context.SaveChangesAsync();
            Message = "Your contact page.";
        }
    }
}
