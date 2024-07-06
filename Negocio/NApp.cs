using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NApp
    {
        private DApp dApp = new DApp();

        public List<App> ListarTodo()
        {
            return dApp.ListarTodo();
        }
    }
}
