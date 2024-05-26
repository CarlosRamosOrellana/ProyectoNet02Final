using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sw.Entities
{
    public class Estudiante
    {
        [Key]
        public int IdEstudiante { get; set; }
        public string NumDoc { get; set; }
        public string Nombre { get; set; }
        public ICollection<Asistencia> Asistencias { get; set; }
    }
}
