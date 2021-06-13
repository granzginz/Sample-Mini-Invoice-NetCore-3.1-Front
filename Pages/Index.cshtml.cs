using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MiniInvoice.Pages
{
    public class IndexModel : PageModel
    {
        
        public string Username { get; set; }
        public string Password { get; set; }
        
        public void OnGet()
        {
            

        }
    }
}
