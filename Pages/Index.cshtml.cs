using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeriLogLearn.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation("you requested the index page");

            try
            {
                for(int i = 0; i<100; i++)
                {
                    if (i == 56)
                    {
                        throw new Exception("this is our demo exception");
                    }
                    else
                    {
                        _logger.LogInformation("the value of the i is {loopCountValue}", i);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "we cought this exception in the index is call");
            }
        }
    }
}
