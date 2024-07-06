
namespace Presentacion
{
    partial class FormReportes
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
            this.btnObtenerSolicitudesEnRangoDeFechasPorTipoDeSolicitud = new System.Windows.Forms.Button();
            this.btnObtenerCantidadSolicitudsAtendidosPorProgramador = new System.Windows.Forms.Button();
            this.dgvReporteSolicitudes = new System.Windows.Forms.DataGridView();
            this.dgvReporteCantidad = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoSolicitud = new System.Windows.Forms.ComboBox();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObtenerSolicitudesEnRangoDeFechasPorTipoDeSolicitud
            // 
            this.btnObtenerSolicitudesEnRangoDeFechasPorTipoDeSolicitud.Location = new System.Drawing.Point(32, 138);
            this.btnObtenerSolicitudesEnRangoDeFechasPorTipoDeSolicitud.Name = "btnObtenerSolicitudesEnRangoDeFechasPorTipoDeSolicitud";
            this.btnObtenerSolicitudesEnRangoDeFechasPorTipoDeSolicitud.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnObtenerSolicitudesEnRangoDeFechasPorTipoDeSolicitud.Size = new System.Drawing.Size(297, 50);
            this.btnObtenerSolicitudesEnRangoDeFechasPorTipoDeSolicitud.TabIndex = 0;
            this.btnObtenerSolicitudesEnRangoDeFechasPorTipoDeSolicitud.Text = "ObtenerSolicitudesEnRangoDeFechasPorTipoDeSolicitud";
            this.btnObtenerSolicitudesEnRangoDeFechasPorTipoDeSolicitud.UseVisualStyleBackColor = true;
            this.btnObtenerSolicitudesEnRangoDeFechasPorTipoDeSolicitud.Click += new System.EventHandler(this.btnObtenerSolicitudesEnRangoDeFechasPorTipoDeSolicitud_Click);
            // 
            // btnObtenerCantidadSolicitudsAtendidosPorProgramador
            // 
            this.btnObtenerCantidadSolicitudsAtendidosPorProgramador.Location = new System.Drawing.Point(32, 239);
            this.btnObtenerCantidadSolicitudsAtendidosPorProgramador.Name = "btnObtenerCantidadSolicitudsAtendidosPorProgramador";
            this.btnObtenerCantidadSolicitudsAtendidosPorProgramador.Size = new System.Drawing.Size(312, 60);
            this.btnObtenerCantidadSolicitudsAtendidosPorProgramador.TabIndex = 1;
            this.btnObtenerCantidadSolicitudsAtendidosPorProgramador.Text = "ObtenerCantidadSolicitudsAtendidosPorProgramador";
            this.btnObtenerCantidadSolicitudsAtendidosPorProgramador.UseVisualStyleBackColor = true;
            this.btnObtenerCantidadSolicitudsAtendidosPorProgramador.Click += new System.EventHandler(this.btnObtenerCantidadSolicitudsAtendidosPorProgramador_Click);
            // 
            // dgvReporteSolicitudes
            // 
            this.dgvReporteSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteSolicitudes.Location = new System.Drawing.Point(402, 23);
            this.dgvReporteSolicitudes.Name = "dgvReporteSolicitudes";
            this.dgvReporteSolicitudes.Size = new System.Drawing.Size(332, 181);
            this.dgvReporteSolicitudes.TabIndex = 2;
            // 
            // dgvReporteCantidad
            // 
            this.dgvReporteCantidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteCantidad.Location = new System.Drawing.Point(402, 225);
            this.dgvReporteCantidad.Name = "dgvReporteCantidad";
            this.dgvReporteCantidad.Size = new System.Drawing.Size(332, 186);
            this.dgvReporteCantidad.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(659, 417);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha de inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha de fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo de Solicitud";
            // 
            // cbTipoSolicitud
            // 
            this.cbTipoSolicitud.FormattingEnabled = true;
            this.cbTipoSolicitud.Items.AddRange(new object[] {
            "Desarrollo",
            "Actualización",
            "Corrección de errores",
            "Migración"});
            this.cbTipoSolicitud.Location = new System.Drawing.Point(120, 92);
            this.cbTipoSolicitud.Name = "cbTipoSolicitud";
            this.cbTipoSolicitud.Size = new System.Drawing.Size(121, 21);
            this.cbTipoSolicitud.TabIndex = 10;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(120, 31);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(165, 20);
            this.dtpFechaInicio.TabIndex = 13;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(119, 59);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(165, 20);
            this.dtpFechaFin.TabIndex = 14;
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.cbTipoSolicitud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvReporteCantidad);
            this.Controls.Add(this.dgvReporteSolicitudes);
            this.Controls.Add(this.btnObtenerCantidadSolicitudsAtendidosPorProgramador);
            this.Controls.Add(this.btnObtenerSolicitudesEnRangoDeFechasPorTipoDeSolicitud);
            this.Name = "FormReportes";
            this.Text = "FormReportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObtenerSolicitudesEnRangoDeFechasPorTipoDeSolicitud;
        private System.Windows.Forms.Button btnObtenerCantidadSolicitudsAtendidosPorProgramador;
        private System.Windows.Forms.DataGridView dgvReporteSolicitudes;
        private System.Windows.Forms.DataGridView dgvReporteCantidad;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipoSolicitud;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
    }
}