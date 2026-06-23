using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AuthorizationDemo.Pages;

public class IndexModel : PageModel
{
    [TempData]
    public string? StatusMessage { get; set; }

    public void OnGet()
    {
    }

    [Authorize]
    public IActionResult OnPost()
    {
        StatusMessage = "Authorized action completed successfully.";
        return RedirectToPage();
    }
}
