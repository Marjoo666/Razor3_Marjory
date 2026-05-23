using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razorr3_10266464.Models;

namespace Razorr3_10266464.Pages.Empleados
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
