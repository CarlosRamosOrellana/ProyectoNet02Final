using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sw.UI
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet3.DataTable1' Puede moverla o quitarla según sea necesario.
            

            this.reportViewer1.RefreshReport();
        }

        private void Reporte_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet4.ok' Puede moverla o quitarla según sea necesario.
            this.okTableAdapter.Fill(this.dataSet4.ok);

            this.reportViewer2.RefreshReport();
        }
    }
}
