using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cyberpolygon.Data;
using Cyberpolygon.Models;

namespace Cyberpolygon.Pages.Configuration
{
    public class DeleteModel : PageModel
    {
        private readonly Cyberpolygon.Data.ConfigurationContext _context;

        public DeleteModel(Cyberpolygon.Data.ConfigurationContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Cyberpolygon.Models.Configuration Configuration { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Configuration == null)
            {
                return NotFound();
            }

            var configuration = await _context.Configuration.FirstOrDefaultAsync(m => m.Id == id);

            if (configuration == null)
            {
                return NotFound();
            }
            else 
            {
                Configuration = configuration;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Configuration == null)
            {
                return NotFound();
            }
            var configuration = await _context.Configuration.FindAsync(id);

            if (configuration != null)
            {
                Configuration = configuration;
                _context.Configuration.Remove(Configuration);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
