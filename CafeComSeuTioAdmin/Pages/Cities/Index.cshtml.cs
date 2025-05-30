using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CafeteriaKwai.Data;
using CafeteriaKwai.Data.Models;

namespace CafeteriaKwai.Pages.Cities
{
    public class IndexModel : PageModel
    {
        private readonly CafeteriaKwai.Data.CafeContext _context;

        public IndexModel(CafeteriaKwai.Data.CafeContext context)
        {
            _context = context;
        }

        public IList<City> City { get;set; } = default!;

        public async Task OnGetAsync()
        {
            City = await _context.Cities
                .Include(c => c.Country).ToListAsync();
        }
    }
}
