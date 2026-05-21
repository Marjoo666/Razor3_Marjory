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
    public class CrearEmpleadosModel : PageModel
    {
        private readonly RutasPracticaRodri.Data.RutasPracticaRodriContext _context;

        public CrearEmpleadosModel(RutasPracticaRodri.Data.RutasPracticaRodriContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Empleado Empleado { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Empleado.Add(Empleado);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index1");
        }
    }
}
