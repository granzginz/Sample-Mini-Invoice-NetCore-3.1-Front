using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MiniInvoice.Pages.Main
{
    public class InvoiceModel : PageModel
    {

        public string StartDate { get; set; }
        public void OnGet()
        {
        }
    }
}
