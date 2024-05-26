using Sw.BLL;
using Sw.BLL.interfaces;
using Sw.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sw.UI
{
    public partial class Form1 : Form
    {
        private IAsistenciaRepositorio _asistenciaRepositorio;
        private IEstudianteRepositorio _estudianteRepositorio;
        public Form1()
        {
            InitializeComponent();
            _asistenciaRepositorio = new AsistenciaNegocio();
            _estudianteRepositorio = new EstudianteNegocio();
            CargarAsistencias();
        }


        EstudianteNegocio objNegocio = new EstudianteNegocio();

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.DataSource = objNegocio.ObtenerEstudiantes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet3.DataTable1' Puede moverla o quitarla según sea necesario.
            

        }
        private void CargarAsistencias()
        {
            try
            {
                var estudiantedoc = _estudianteRepositorio.ObtenerEstudiantePorId(1);
                var estudiantnom = _estudianteRepositorio.ObtenerEstudiantePorId(1);
                var asistencias = _asistenciaRepositorio.ObtenerAsistencias()
                    .Select(a => new
                    {
                        a.IdEstudiante,
                        estudiantedoc = _estudianteRepositorio.ObtenerEstudiantePorId(a.IdEstudiante).NumDoc,
                        estudiantenom = _estudianteRepositorio.ObtenerEstudiantePorId(a.IdEstudiante).Nombre,
                        a.Fecha,
                        a.HoraIngreso,
                        a.HoraSalida
                    }).ToList();

                dataGridView1.DataSource = asistencias;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las asistencias: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarAsistencias();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IAsistenciaRepositorio asistenciaRepositorio = new AsistenciaNegocio();

            var idEstudiante = _estudianteRepositorio.ObtenerEstudiantes();
            int id=0;
            foreach (var a in idEstudiante) {
                if (dni.Text.Equals(a.NumDoc))
                {
                    id = a.IdEstudiante;
                }        
                
            }

            DateTime fechaSeleccionada = fecha.Value.Date;
            Console.WriteLine("Waaaaaaaaaaaaaaaaa");
            string fechad = fechaSeleccionada.ToString("dd/MM/yyyy");
            Console.WriteLine("Waaaaaaaaaaaaaaaaa");
            Asistencia nuevaAsistencia = new Asistencia
            {
                IdEstudiante = id,
                Fecha = fechad,
                HoraIngreso = labelHora.Text,
                HoraSalida = "00:00"
            };

            try
            {
                asistenciaRepositorio.AgregarAsistencia(nuevaAsistencia);
                MessageBox.Show("Asistencia agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la asistencia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarAsistencias();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           Reporte reporte = new Reporte();
            reporte.Visible = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var estudiantes = _estudianteRepositorio.ObtenerEstudiantes();
            int idEstudiante = 0;

            foreach (var estudiante in estudiantes)
            {
                if (dni.Text.Equals(estudiante.NumDoc))
                {
                    idEstudiante = estudiante.IdEstudiante;
                    break; // Salir del bucle una vez que se encuentra el estudiante
                }
            }

            if (idEstudiante > 0)
            {
                // Obtener la asistencia más reciente del estudiante
                var asistencia = _asistenciaRepositorio.ObtenerAsistencias()
                                  .Where(a => a.IdEstudiante == idEstudiante)
                                  .OrderByDescending(a => a.IdAsistencia) // Asumiendo que Fecha está en formato YYYY-MM-DD
                                  .FirstOrDefault();

                if (asistencia != null)
                {
                    _asistenciaRepositorio.ActualizarHoraSalida(asistencia.IdAsistencia, labelHora.Text);
                }
            }
            else
            {
                Console.WriteLine("Fail");
            }

            CargarAsistencias();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
