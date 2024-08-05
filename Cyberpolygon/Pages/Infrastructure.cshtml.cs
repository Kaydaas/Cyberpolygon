using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cyberpolygon.Pages
{
    public class InfrastructureModel : PageModel
    {
        private readonly ILogger<InfrastructureModel> _logger;

        public InfrastructureModel(ILogger<InfrastructureModel> logger)
        {
            _logger = logger;
        }
    }
}