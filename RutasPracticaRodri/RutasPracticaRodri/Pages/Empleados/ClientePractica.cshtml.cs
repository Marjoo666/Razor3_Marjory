using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Razorr3_10266464.Data;
using Razorr3_10266464.Models;

namespace Razorr3_10266464.Pages.Empleados
{
    public class ClientePracticaModel : PageModel
    {
        private readonly Razorr3_10266464.Data.Razorr3_10266464Context _context;

        public ClientePracticaModel(Razorr3_10266464.Data.Razorr3_10266464Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Cliente Cliente { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cliente.Add(Cliente);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index1");
        }
    }
}
