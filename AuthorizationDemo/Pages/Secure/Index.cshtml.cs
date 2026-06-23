using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AuthorizationDemo.Pages.Secure;

[Authorize]
public class IndexModel : PageModel
{
    public void OnGet()
    {
    }
}
