using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Razorr3_10266464.Models;

namespace Razorr3_10266464.Pages.Empleados
{
    public class Razorr3_10266464Context : DbContext
    {
        public Razorr3_10266464Context (DbContextOptions<Razorr3_10266464Context> options)
            : base(options)
        {
        }

        public DbSet<Razorr3_10266464.Models.Empleado> Empleado { get; set; } = default!;
        public DbSet<Razorr3_10266464.Models.Oficina> Oficina { get; set; } = default!;
        public DbSet<Razorr3_10266464.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<Razorr3_10266464.Models.EmpleadoContable> EmpleadoContable { get; set; }
        public DbSet<Razorr3_10266464.Models.EmpleadoDeveloper> EmpleadoDeveloper { get; set; }
    }
}
