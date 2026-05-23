using System;
using System.ComponentModel.DataAnnotations;
namespace Razorr3_10266464.Pages.Empleados
{
    public class EmpleadoContable : Empleado
    {
        
        [Display(Name = "Registros Creados")]
        public int RegistrosCreados { get; set; }

        [Display(Name = "Facturas Creadas")]
        public int FacturasCreadas { get; set; }
    }
}
