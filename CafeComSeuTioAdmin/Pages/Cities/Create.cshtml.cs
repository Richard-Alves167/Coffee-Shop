using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CafeteriaKwai.Data;
using CafeteriaKwai.Data.Models;
using Microsoft.AspNetCore.Authorization;

namespace CafeteriaKwai.Pages.Cities
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly CafeteriaKwai.Data.CafeContext _context;

        public CreateModel(CafeteriaKwai.Data.CafeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CountryId"] = new SelectList(_context.Countries, "CountryId", "CountryId");
            return Page();
        }

        [BindProperty]
        public City City { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cities.Add(City);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
