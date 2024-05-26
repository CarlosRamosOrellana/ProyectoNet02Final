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
    public class EstudianteNegocio : IEstudianteRepositorio
    {
        SwContextoDB db = new SwContextoDB();

        public void AgregarEstudiante(Estudiante estudiante)
        {
            db.Estudiantes.Add(estudiante);
            db.SaveChanges();
        }

        public void EliminarEstudiante(int id)
        {
            var estudiante = db.Estudiantes.Find(id);
            if (estudiante != null)
            {
                db.Estudiantes.Remove(estudiante);
                db.SaveChanges();
            }
        }

        public Estudiante ObtenerEstudiantePorId(int id)
        {
            return db.Estudiantes.Find(id);
        }

        public List<Estudiante> ObtenerEstudiantes()
        {
            return db.Estudiantes.ToList();
        }
    }
}
