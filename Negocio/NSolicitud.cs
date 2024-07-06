using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NSolicitud
    {
        private DSolicitud dSolicitud = new DSolicitud();
        public String Registrar(Solicitud solicitud)
        {
            return dSolicitud.Registrar(solicitud);
        }

        public String Modificar(Solicitud solicitud)
        {
            return dSolicitud.Modificar(solicitud);
        }

        public String Atender(Solicitud solicitud)
        {
            return dSolicitud.Atender(solicitud);
        }

        public String Eliminar(int solicitudId)
        {
            return dSolicitud.Eliminar(solicitudId);  
        }

        public List<Solicitud> ListarTodo()
        {
            return dSolicitud.ListarTodo();
        }
    }
}
