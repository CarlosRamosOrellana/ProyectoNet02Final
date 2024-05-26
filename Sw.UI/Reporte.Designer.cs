namespace Sw.UI
{
    partial class Reporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet31 = new Sw.UI.DataSet3();
            this.dataSet31BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Sw.UI.DataSet2();
            this.dataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet4 = new Sw.UI.DataSet4();
            this.dataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.okBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.okTableAdapter = new Sw.UI.DataSet4TableAdapters.okTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet31BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "we";
            reportDataSource1.Value = this.okBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Sw.UI.Informes.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(621, 311);
            this.reportViewer2.TabIndex = 0;
            // 
            // dataSet31
            // 
            this.dataSet31.DataSetName = "DataSet3";
            this.dataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet31BindingSource
            // 
            this.dataSet31BindingSource.DataSource = this.dataSet31;
            this.dataSet31BindingSource.Position = 0;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet2BindingSource
            // 
            this.dataSet2BindingSource.DataSource = this.dataSet2;
            this.dataSet2BindingSource.Position = 0;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet4BindingSource
            // 
            this.dataSet4BindingSource.DataSource = this.dataSet4;
            this.dataSet4BindingSource.Position = 0;
            // 
            // okBindingSource
            // 
            this.okBindingSource.DataMember = "ok";
            this.okBindingSource.DataSource = this.dataSet4;
            // 
            // okTableAdapter
            // 
            this.okTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte
            // 
            this.ClientSize = new System.Drawing.Size(621, 311);
            this.Controls.Add(this.reportViewer2);
            this.Name = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet31BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource dataSet2BindingSource;
        private DataSet2 dataSet2;
        private DataSet3 dataSet31;
        private System.Windows.Forms.BindingSource dataSet31BindingSource;
        private DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource dataSet4BindingSource;
        private System.Windows.Forms.BindingSource okBindingSource;
        private DataSet4TableAdapters.okTableAdapter okTableAdapter;
    }
}