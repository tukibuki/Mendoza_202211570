using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DSolicitud
    {
        public String Registrar(Solicitud solicitud)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Solicitud.Add(solicitud);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }

        public String Modificar(Solicitud solicitud)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Solicitud solicitudTemp = context.Solicitud.Find(solicitud.SolicitudId);
                    solicitudTemp.FechaHoraSolicitud = solicitud.FechaHoraSolicitud;
                    solicitudTemp.TipoSolicitud = solicitud.TipoSolicitud;
                    solicitudTemp.Programador = solicitud.Programador;
                    solicitudTemp.AppId = solicitud.AppId;

                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }

        public String Atender(Solicitud solicitud)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Solicitud solicitudTemp = context.Solicitud.Find(solicitud.SolicitudId);
                    solicitudTemp.Atendido = solicitud.Atendido;
                    context.SaveChanges();
                }
                return "Atendido correctamente";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }


        public String Eliminar(int solicitudId)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Solicitud solicitudTemp = context.Solicitud.Find(solicitudId);
                    context.Solicitud.Remove(solicitudTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }

        public List<Solicitud> ListarTodo()
        {
            List<Solicitud> solicitudes = new List<Solicitud>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    solicitudes = context.Solicitud.ToList();
                }
                return solicitudes;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return solicitudes;
            }
        }
    }
}
