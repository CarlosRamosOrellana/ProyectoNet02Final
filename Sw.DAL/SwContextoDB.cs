using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sw.Entities;

namespace Sw.DAL
{
    public class SwContextoDB : DbContext
    {
        public SwContextoDB() : base("CadenaConexion1") { }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Asistencia> Asistencias { get; set; }
    }
}
