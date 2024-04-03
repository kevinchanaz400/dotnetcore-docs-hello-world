using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dotnetcoresample.Pages;

public class ThrowErrorModel : PageModel
{
    private readonly ILogger<ThrowErrorModel> _logger;

    public ThrowErrorModel(ILogger<ThrowErrorModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        throw new Exception("Attempting to generate error page...");
    }
}

