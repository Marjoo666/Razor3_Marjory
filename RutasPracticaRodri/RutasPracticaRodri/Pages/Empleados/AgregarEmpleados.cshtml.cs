using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RutasPracticaRodri.Models;

namespace RutasPracticaRodri.Pages.Empleados
{
    public class AgregarEmpleadosModel : PageModel
    {
        [BindProperty]
        public Empleado Empleado { get; set; }
        
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            return RedirectToPage("/Empleados/Index1", new { Empleado.Nombre });
        }
    }
}
