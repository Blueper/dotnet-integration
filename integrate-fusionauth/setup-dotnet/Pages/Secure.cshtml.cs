using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace setup_dotnet.Pages
{
    [Authorize]
    public class SecureModel : PageModel
    {
        private readonly ILogger<SecureModel> _logger;

        public SecureModel(ILogger<SecureModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}