using Datos.util;
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
    public partial class FormReportes : Form
    {
        private NReportes nReporte = new NReportes();
        public FormReportes()
        {
            InitializeComponent();
        }

        private void MostrarReporteSolicitud(List<ReporteSolicitudes> reporteSolicitud)
        {
            dgvReporteSolicitudes.DataSource = null;
            if (reporteSolicitud.Count == 0)
            {
                return;
            }
            else
            {
                dgvReporteSolicitudes.DataSource = reporteSolicitud;
            }
        }

        private void MostrarReporteCantidad(List<ReporteCantidad> reporteCantidad)
        {
            dgvReporteCantidad.DataSource = null;
            if (reporteCantidad.Count == 0)
            {
                return;
            }
            else
            {
                dgvReporteCantidad.DataSource = reporteCantidad;
            }
        }


        private void btnObtenerSolicitudesEnRangoDeFechasPorTipoDeSolicitud_Click(object sender, EventArgs e)
        {
            if (dtpFechaInicio.Text == "" || dtpFechaFin.Text == "" || cbTipoSolicitud.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

          
            if (dtpFechaInicio.Value > dtpFechaFin.Value)
            {
                MessageBox.Show("La Fecha Inicio no puede ser mayopr a la Fecha Fin");
                return;
            }

            MostrarReporteSolicitud(nReporte.ObtenerSolicitudesEnRangoDeFechasPorTipoDeSolicitud(
                dtpFechaInicio.Value, dtpFechaFin.Value, cbTipoSolicitud.Text));
        }

        private void btnObtenerCantidadSolicitudsAtendidosPorProgramador_Click(object sender, EventArgs e)
        {
            MostrarReporteCantidad(nReporte.ObtenerCantidadSolicitudsAtendidosPorProgramador());
        }
    }
}
