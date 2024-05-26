using Sw.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sw.BLL.interfaces
{
    public interface IEstudianteRepositorio
    {
        List<Estudiante> ObtenerEstudiantes();
        void AgregarEstudiante(Estudiante estudiante);
        void EliminarEstudiante(int id);
        Estudiante ObtenerEstudiantePorId(int id);
    }
}
