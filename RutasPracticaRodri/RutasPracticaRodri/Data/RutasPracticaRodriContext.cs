using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RutasPracticaRodri.Models;

namespace RutasPracticaRodri.Data
{
    public class RutasPracticaRodriContext : DbContext
    {
        public RutasPracticaRodriContext (DbContextOptions<RutasPracticaRodriContext> options)
            : base(options)
        {
        }

        public DbSet<RutasPracticaRodri.Models.Empleado> Empleado { get; set; } = default!;
        public DbSet<RutasPracticaRodri.Models.Oficina> Oficina { get; set; } = default!;
        public DbSet<RutasPracticaRodri.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<RutasPracticaRodri.Models.EmpleadoContable> EmpleadoContable { get; set; }
        public DbSet<RutasPracticaRodri.Models.EmpleadoDeveloper> EmpleadoDeveloper { get; set; }
    }
}
