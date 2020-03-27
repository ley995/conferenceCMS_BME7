using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BME77.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BME77.Pages
{
    public class RoomModel : PageModel
    {
        private readonly BME77.Models.PaperContext _context;
        public RoomModel(BME77.Models.PaperContext context)
        {
            _context = context;
        }

        public string Room { get; set; }
        public async Task OnGetAsync(int? id)
        {
            Statistic statistic = new Statistic() { Time = DateTime.Now, Route = id == null ? "NULL" : id.ToString(), Page = "Room" };
            _context.Statistics.Add(statistic);
            await _context.SaveChangesAsync();
            Room = "4F.png";
            if(id!=null)
            {
                if (id == 410)
                {
                    Room = "410.png";
                }else if (id == 409)
                {
                    Room = "409.png";
                }
                else if (id == 411)
                {
                    Room = "411.png";
                }
                else if (id == 412)
                {
                    Room = "412.png";
                }
                else if (id == 413)
                {
                    Room = "413.png";
                }
                else if (id == 104)
                {
                    Room = "104.png";
                }
                else if (id == 100)
                {
                    Room = "1F.png";
                }
                else if (id == 400)
                {
                    Room = "4F.png";
                }
                else if (id == 507)
                {
                    Room = "507.png";
                }
                else if (id == 1409)
                {
                    Room = "1409.png";
                }
                else if (id == 401)
                {
                    Room = "401.png";
                }
                else if (id == 402)
                {
                    Room = "402.png";
                }

            }
        }
    }
}