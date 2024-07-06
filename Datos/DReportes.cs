using Datos.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DReportes
    {
        public List<ReporteSolicitudes> ObtenerSolicitudesEnRangoDeFechasPorTipoDeSolicitud(
           DateTime fechaInicio, DateTime fechaFin, String tipoSolicitud)
        {
            List<ReporteSolicitudes> reporte = new List<ReporteSolicitudes>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    reporte = context.Solicitud
                        .Where(s =>
                        s.FechaHoraSolicitud >= fechaInicio &&
                        s.FechaHoraSolicitud <= fechaFin &&
                        s.TipoSolicitud.Equals(tipoSolicitud)
                        )
                        .Select(r => new ReporteSolicitudes()
                        {
                            FechaHoraSolicitud = r.FechaHoraSolicitud,
                            NombreCompletoProgramador = r.Programador.NombreCompleto,
                            CodigoApp = r.App.IDE
                        }
                        )
                        .ToList();
                    return reporte;
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return reporte;
            }
        }

        public List<ReporteCantidad> ObtenerCantidadSolicitudsAtendidosPorProgramador()
        {
            List<ReporteCantidad> reporte = new List<ReporteCantidad>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    reporte = context.Solicitud
                        .Where(s => s.Atendido == true)
                        .GroupBy(s => s.Programador.NombreCompleto)
                        .Select(r => new ReporteCantidad()
                        {
                            NombreCompletoProgramador = r.Key,
                            Cantidad = r.Count(),
                        })
                        .ToList();
                    return reporte;
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return reporte;
            }


        }
    }
}
