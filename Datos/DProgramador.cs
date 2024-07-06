using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DProgramador
    {
        public List<Programador> ListarTodo()
        {
            List<Programador> programadores = new List<Programador>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    programadores = context.Programador.Where(m => m.Eliminado == false).ToList();
                }
                return programadores;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return programadores;
            }
        }
    }
}
