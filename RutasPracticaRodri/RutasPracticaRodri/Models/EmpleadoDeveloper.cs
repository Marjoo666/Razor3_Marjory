using System;
using System.ComponentModel.DataAnnotations;
namespace RutasPracticaRodri.Models
{
    public class EmpleadoDeveloper : Empleado
    {
        [Display(Name = "Bugs Reparados")]
        public int BugsReparados { get; set; }

        [Display(Name = "Aplicaciones Creadas")]
        public int AplicacionesCreadas { get; set; }
    }
}
