using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Downloads.Pages;

public class CarsModel : PageModel
{
    private readonly ILogger<CarsModel> _logger;

    public CarsModel(ILogger<CarsModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

