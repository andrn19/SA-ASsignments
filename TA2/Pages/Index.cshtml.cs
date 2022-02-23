using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TA2.DTOs;
using TA2.Services;

namespace TA2.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly DataService _dataService;
    
    public IEnumerable<ProductDTO> Products { get; private set;  }
    public IndexModel(ILogger<IndexModel> logger, DataService dataService)
    {
        _logger = logger;
        _dataService = dataService;
    }

    public void OnGet()
    {
        Products = _dataService.GetProducts();
    }
}
