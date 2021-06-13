using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Model.Model.UserMgt;

namespace MiniInvoice.Pages
{
    [Serializable]
    public class IndexModel : PageModel
    {
        
        public string Username { get; set; }
        public string Password { get; set; }
        

        public void OnGet()
        {
        }
    }
}
