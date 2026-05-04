using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ReportingSystem.Services;

namespace ReportingSystem.Pages;

public class IndexModel : PageModel
{
    private readonly ReportService _reportService;

    public IndexModel(ReportService reportService)
    {
        _reportService = reportService;
    }

    public string Result { get; set; }

    // Default page load
    public void OnGet()
    {
    }

    // Button click
    public void OnPost()
    {
        Result = _reportService.ProcessAndReturn();
    }
}