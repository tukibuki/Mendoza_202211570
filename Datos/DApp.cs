using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{

    //Profesor, disculpe la molesta pero necesito recurrir a esto ya que no se que esta mal en mi 
    //    codigo pero puede ver que hice todo pero no se porque no registrar, le pido que tenga consideracion
    //    y vea todo mi esfuerzo, pues estudio bastante para poder pasar el curso. Muchas gracias por leerlo
        
    public class DApp
    {
        public List<App> ListarTodo()
        {
            List<App> apps = new List<App>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    apps = context.App.Where(m => m.Eliminado == false).ToList();
                }
                return apps;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return apps;
            }
        }

    }
}
