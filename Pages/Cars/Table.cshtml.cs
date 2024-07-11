using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NotForza.Models;
using NotForza_web_app.Data;

namespace Downloads.Pages_Cars
{
    public class IndexModel : PageModel
    {
        private readonly NotForza_web_app.Data.CarDataContext _context;

        public IndexModel(NotForza_web_app.Data.CarDataContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Car = await _context.Car.ToListAsync();
        }
    }
}
