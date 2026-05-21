using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RutasPracticaRodri.Data;
using RutasPracticaRodri.Models;

namespace RutasPracticaRodri.Pages.Empleados
{
    public class OficinaPracticaModel : PageModel
    {
        private readonly RutasPracticaRodri.Data.RutasPracticaRodriContext _context;

        public OficinaPracticaModel(RutasPracticaRodri.Data.RutasPracticaRodriContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Oficina Oficina { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Oficina.Add(Oficina);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index1");
        }
    }
}
