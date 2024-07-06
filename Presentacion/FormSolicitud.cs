using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormSolicitud : Form
    {
        private NApp nApp = new NApp();
        private NProgramador nProgramador = new NProgramador();
        private NSolicitud nSolicitud = new NSolicitud();
        public FormSolicitud()
        {
            InitializeComponent();
            MostrarApps(nApp.ListarTodo());
            MostrarProgramadores(nProgramador.ListarTodo());
            MostrarSolicitudes(nSolicitud.ListarTodo());

        }

        private void MostrarApps(List<App> apps)
        {
            cbApp.DataSource = null;
            if (apps.Count == 0)
            {
                return;
            }
            else
            {
                cbApp.DataSource = apps;
                cbApp.ValueMember = "AppId";
                cbApp.DisplayMember = "IDE";
            }
        }

        private void MostrarProgramadores(List<Programador> programadores)
        {
            cbProgramador.DataSource = null;
            if (programadores.Count == 0)
            {
                return;
            }
            else
            {
                cbProgramador.DataSource = programadores;
                cbProgramador.ValueMember = "ProgramadorId";
                cbProgramador.DisplayMember = "CodigoProgramador";
            }

        }

        private void MostrarSolicitudes(List<Solicitud> solicitudes)
        {
            dgvSolicitudes.DataSource = null;
            if (solicitudes.Count == 0)
            {
                return;
            }
            else
            {
                dgvSolicitudes.DataSource = solicitudes;
                dgvSolicitudes.Columns["App"].Visible = false;
                dgvSolicitudes.Columns["Programador"].Visible = false;
            }
        }



        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (cbApp.Text == "" || cbProgramador.Text == "" || cbTipoSolicitud.Text == "" || dtpFechaHoraSolicitud.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            
            if (dtpFechaHoraSolicitud.Value < DateTime.Now)
            {
                MessageBox.Show("Ingrese una fecha y hora mayor a la actual");
                return;
            }

            int appId = int.Parse(cbApp.SelectedValue.ToString());
            int programadorId = int.Parse(cbProgramador.SelectedValue.ToString());

            Solicitud solicitud = new Solicitud()
            {
                AppId=appId,
                ProgramadorId = programadorId,
                TipoSolicitud=cbTipoSolicitud.Text,
                FechaHoraSolicitud = dtpFechaHoraSolicitud.Value
            };

            String mensaje = nSolicitud.Registrar(solicitud);
            MessageBox.Show(mensaje);

            MostrarSolicitudes(nSolicitud.ListarTodo());

        }



        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cbApp.Text == "" || cbProgramador.Text == "" || cbTipoSolicitud.Text == "" || dtpFechaHoraSolicitud.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }


            if (dtpFechaHoraSolicitud.Value < DateTime.Now)
            {
                MessageBox.Show("Ingrese una fecha y hora mayor a la actual");
                return;
            }

            if (dgvSolicitudes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a modificar");
                return;
            }

            bool atendido = bool.Parse(dgvSolicitudes.SelectedRows[0].Cells["Atendido"].Value.ToString());

            
            if (atendido)
            {
                MessageBox.Show("No se puede modificar un servicio que ya ha sido atendido");
                return;
            }

            int appId = int.Parse(cbApp.SelectedValue.ToString());
            int programadorId = int.Parse(cbProgramador.SelectedValue.ToString());

            int solicitudId = int.Parse(dgvSolicitudes.SelectedRows[0].Cells["SolicitudId"].Value.ToString());

            Solicitud solicitud = new Solicitud()
            {
                AppId = appId,
                ProgramadorId = programadorId,
                SolicitudId=solicitudId,
                FechaHoraSolicitud = dtpFechaHoraSolicitud.Value
            };

            String mensaje = nSolicitud.Registrar(solicitud);
            MessageBox.Show(mensaje);

            MostrarSolicitudes(nSolicitud.ListarTodo());
        }

        private void btnAtendido_Click(object sender, EventArgs e)
        {

            if (dgvSolicitudes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una solicitud a modificar");
                return;
            }


            int solicitudId = int.Parse(dgvSolicitudes.SelectedRows[0].Cells["SolicituId"].Value.ToString());

            Solicitud solicitud = new Solicitud()
            {
                
                SolicitudId = solicitudId
            };

            String mensaje = nSolicitud.Registrar(solicitud);
            MessageBox.Show(mensaje);

            MostrarSolicitudes(nSolicitud.ListarTodo());
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgvSolicitudes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una solicitud a eliminar");
                return;
            }

            int solicitudId = int.Parse(dgvSolicitudes.SelectedRows[0].Cells["SolicituId"].Value.ToString());

            DialogResult dialog = MessageBox.Show("¿Está seguro de eliminar el registro con SolicitudId: " + solicitudId, "", MessageBoxButtons.YesNo);

            if (dialog.Equals(DialogResult.Yes))
            {
                String mensaje = nSolicitud.Eliminar(solicitudId);
                MessageBox.Show(mensaje);

                MostrarSolicitudes(nSolicitud.ListarTodo());
            }

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReportes form = new FormReportes();
            form.Show();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSolicitudes_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvSolicitudes.SelectedRows.Count == 0)
            {
                return;
            }

            cbApp.SelectedValue = dgvSolicitudes.SelectedRows[0].Cells["AppId"].Value;
            cbProgramador.SelectedValue = dgvSolicitudes.SelectedRows[0].Cells["ProgramadorId"].Value;
            cbTipoSolicitud.Text = dgvSolicitudes.SelectedRows[0].Cells["TipoSolicitud"].Value.ToString();
            dtpFechaHoraSolicitud.Value = (DateTime)dgvSolicitudes.SelectedRows[0].Cells["FechaHoraSolicitud"].Value;
        }
    }
}
