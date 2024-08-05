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
    public class IndexModel : PageModel
    {
        private readonly Cyberpolygon.Data.ConfigurationContext _context;

        public IndexModel(Cyberpolygon.Data.ConfigurationContext context)
        {
            _context = context;
        }

        public IList<Cyberpolygon.Models.Configuration> Configuration { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Configuration != null)
            {
                Configuration = await _context.Configuration.ToListAsync();
            }
        }

        public async Task<IActionResult> OnGetConfigurations()
        {
            var configurations = await _context.Configuration.ToListAsync();
            return new JsonResult(configurations);
        }

        public async Task<IActionResult> OnGetConfigurationById(int id)
        {
            var configuration = await _context.Configuration.FindAsync(id);
            return new JsonResult(configuration);
        }
    }
}
