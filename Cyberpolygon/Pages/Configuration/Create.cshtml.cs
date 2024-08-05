using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Cyberpolygon.Data;
using Cyberpolygon.Models;

namespace Cyberpolygon.Pages.Configuration
{
    public class CreateModel : PageModel
    {
        private readonly Cyberpolygon.Data.ConfigurationContext _context;

        public CreateModel(Cyberpolygon.Data.ConfigurationContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Cyberpolygon.Models.Configuration Configuration { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Configuration == null || Configuration == null)
            {
                return Page();
            }

            _context.Configuration.Add(Configuration);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
