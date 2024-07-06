using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NProgramador
    {
        
            private DProgramador dProgramador = new DProgramador();

            public List<Programador> ListarTodo()
            {
                return dProgramador.ListarTodo();
            }
        
    }
}
