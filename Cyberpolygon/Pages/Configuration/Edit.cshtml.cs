using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cyberpolygon.Data;
using Cyberpolygon.Models;

namespace Cyberpolygon.Pages.Configuration
{
    public class EditModel : PageModel
    {
        private readonly Cyberpolygon.Data.ConfigurationContext _context;

        public EditModel(Cyberpolygon.Data.ConfigurationContext context)
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

            var configuration =  await _context.Configuration.FirstOrDefaultAsync(m => m.Id == id);
            if (configuration == null)
            {
                return NotFound();
            }
            Configuration = configuration;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Configuration).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConfigurationExists(Configuration.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ConfigurationExists(int id)
        {
          return (_context.Configuration?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
