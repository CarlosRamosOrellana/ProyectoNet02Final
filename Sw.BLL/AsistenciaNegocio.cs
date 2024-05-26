using Sw.BLL.interfaces;
using Sw.DAL;
using Sw.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sw.BLL
{
    public class AsistenciaNegocio : IAsistenciaRepositorio
    {
        SwContextoDB db = new SwContextoDB();

        public void AgregarAsistencia(Asistencia asistencia)
        {
            db.Asistencias.Add(asistencia);
            db.SaveChanges();
        }

        public void EliminarAsistencia(int id)
        {
            var asistencia = db.Asistencias.Find(id);
            if (asistencia != null)
            {
                db.Asistencias.Remove(asistencia);
                db.SaveChanges();
            }
        }

        public List<Asistencia> ObtenerAsistencias()
        {
            return db.Asistencias.Include("Estudiante").ToList();
        }
        public Asistencia ObtenerAsistenciaPorId(int id)
        {
            return db.Asistencias.Include("Estudiante").FirstOrDefault(a => a.IdAsistencia == id);
        }

        public void ActualizarHoraSalida(int id, string nuevaHoraSalida)
        {
            var asistencia = db.Asistencias.FirstOrDefault(a => a.IdAsistencia == id);
            if (asistencia != null)
            {
                asistencia.HoraSalida = nuevaHoraSalida;
                db.SaveChanges();
            }
        }


    }
}
