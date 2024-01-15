using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace mph_converter_webapp.Pages;

public class LogModel : PageModel
{
    private readonly ILogger<LogModel> _logger;

    public LogModel(ILogger<LogModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

