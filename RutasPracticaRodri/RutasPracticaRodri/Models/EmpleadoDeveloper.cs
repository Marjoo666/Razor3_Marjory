using System;
using System.ComponentModel.DataAnnotations;
namespace Razorr3_10266464.Pages.Empleados
{
    public class EmpleadoDeveloper : Empleado
    {
        [Display(Name = "Bugs Reparados")]
        public int BugsReparados { get; set; }

        [Display(Name = "Aplicaciones Creadas")]
        public int AplicacionesCreadas { get; set; }
    }
}
