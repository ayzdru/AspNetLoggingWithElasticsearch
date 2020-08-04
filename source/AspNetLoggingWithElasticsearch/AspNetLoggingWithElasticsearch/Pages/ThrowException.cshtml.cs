using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AspNetLoggingWithElasticsearch.Pages
{
    public class ThrowExceptionModel : PageModel
    {
        private readonly ILogger<ThrowExceptionModel> _logger;

        public ThrowExceptionModel(ILogger<ThrowExceptionModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            throw new Exception("Bilerek hata yazdırıyorum.");
        }
    }
}
