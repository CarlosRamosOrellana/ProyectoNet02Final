using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sw.Entities
{
    public class Asistencia
    {
        [Key]
        public int IdAsistencia { get; set; }
        public int IdEstudiante { get; set; }
        public string Fecha { get; set; }
        public string HoraIngreso { get; set; }
        public string HoraSalida { get; set; }
        public Estudiante Estudiante { get; set; }
    }
}
