using Datos;
using Datos.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NReportes
    {
        private DReportes dReportes = new DReportes();

        public List<ReporteSolicitudes> ObtenerSolicitudesEnRangoDeFechasPorTipoDeSolicitud(
            DateTime fechaInicio, DateTime fechaFin, String tipoSolicitud)
        {
            return dReportes.ObtenerSolicitudesEnRangoDeFechasPorTipoDeSolicitud(fechaInicio, fechaFin, tipoSolicitud);
        }

        public List<ReporteCantidad> ObtenerCantidadSolicitudsAtendidosPorProgramador()
        {
            return dReportes.ObtenerCantidadSolicitudsAtendidosPorProgramador();
        }

    }
}
