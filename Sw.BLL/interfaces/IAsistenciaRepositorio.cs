using Sw.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sw.BLL.interfaces
{
    public interface IAsistenciaRepositorio
    {
        List<Asistencia> ObtenerAsistencias();
        void AgregarAsistencia(Asistencia asistencia);
        void EliminarAsistencia(int id);
        void ActualizarHoraSalida(int id, string nuevaHoraSalida);
    }
}
