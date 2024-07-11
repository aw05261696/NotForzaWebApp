using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Downloads.Pages;

public class CarCustomisationModel : PageModel
{
    private readonly ILogger<CarCustomisationModel> _logger;

    public CarCustomisationModel(ILogger<CarCustomisationModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}