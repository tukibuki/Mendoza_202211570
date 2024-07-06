
namespace Presentacion
{
    partial class FormSolicitud
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
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnAtendido = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaHoraSolicitud = new System.Windows.Forms.DateTimePicker();
            this.cbTipoSolicitud = new System.Windows.Forms.ComboBox();
            this.cbApp = new System.Windows.Forms.ComboBox();
            this.cbProgramador = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Location = new System.Drawing.Point(17, 155);
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.Size = new System.Drawing.Size(685, 215);
            this.dgvSolicitudes.TabIndex = 0;
            this.dgvSolicitudes.SelectionChanged += new System.EventHandler(this.dgvSolicitudes_SelectionChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(17, 120);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnAtendido
            // 
            this.btnAtendido.Location = new System.Drawing.Point(107, 120);
            this.btnAtendido.Name = "btnAtendido";
            this.btnAtendido.Size = new System.Drawing.Size(75, 23);
            this.btnAtendido.TabIndex = 2;
            this.btnAtendido.Text = "Atendido";
            this.btnAtendido.UseVisualStyleBackColor = true;
            this.btnAtendido.Click += new System.EventHandler(this.btnAtendido_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(200, 120);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(290, 120);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(478, 120);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(382, 120);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(75, 23);
            this.btnReportes.TabIndex = 6;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "AppId:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ProgramadorId:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo de Solicitud:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha y hora de solicitud:";
            // 
            // dtpFechaHoraSolicitud
            // 
            this.dtpFechaHoraSolicitud.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dtpFechaHoraSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHoraSolicitud.Location = new System.Drawing.Point(498, 83);
            this.dtpFechaHoraSolicitud.Name = "dtpFechaHoraSolicitud";
            this.dtpFechaHoraSolicitud.Size = new System.Drawing.Size(165, 20);
            this.dtpFechaHoraSolicitud.TabIndex = 12;
            // 
            // cbTipoSolicitud
            // 
            this.cbTipoSolicitud.FormattingEnabled = true;
            this.cbTipoSolicitud.Items.AddRange(new object[] {
            "Desarrollo",
            "Actualización",
            "Corrección de errores",
            "Migración"});
            this.cbTipoSolicitud.Location = new System.Drawing.Point(459, 40);
            this.cbTipoSolicitud.Name = "cbTipoSolicitud";
            this.cbTipoSolicitud.Size = new System.Drawing.Size(121, 21);
            this.cbTipoSolicitud.TabIndex = 14;
            // 
            // cbApp
            // 
            this.cbApp.FormattingEnabled = true;
            this.cbApp.Location = new System.Drawing.Point(117, 40);
            this.cbApp.Name = "cbApp";
            this.cbApp.Size = new System.Drawing.Size(121, 21);
            this.cbApp.TabIndex = 15;
            // 
            // cbProgramador
            // 
            this.cbProgramador.FormattingEnabled = true;
            this.cbProgramador.Location = new System.Drawing.Point(117, 82);
            this.cbProgramador.Name = "cbProgramador";
            this.cbProgramador.Size = new System.Drawing.Size(121, 21);
            this.cbProgramador.TabIndex = 16;
            // 
            // FormSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 400);
            this.Controls.Add(this.cbProgramador);
            this.Controls.Add(this.cbApp);
            this.Controls.Add(this.cbTipoSolicitud);
            this.Controls.Add(this.dtpFechaHoraSolicitud);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAtendido);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgvSolicitudes);
            this.Name = "FormSolicitud";
            this.Text = "Salir";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAtendido;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraSolicitud;
        private System.Windows.Forms.ComboBox cbTipoSolicitud;
        private System.Windows.Forms.ComboBox cbApp;
        private System.Windows.Forms.ComboBox cbProgramador;
    }
}