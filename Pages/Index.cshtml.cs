using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace mph_converter_webapp.Pages;

public class ConvertModel : PageModel
{
    private readonly ILogger<ConvertModel> _logger;

    public ConvertModel(ILogger<ConvertModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
