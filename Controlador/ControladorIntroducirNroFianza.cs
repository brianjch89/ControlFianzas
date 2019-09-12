using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Modelo;

namespace Controlador
{
    public class ControladorIntroducirNroFianza
    {
        Informacion inf = new Informacion();

        public DataTable ObtenerFianza(string query)
        {
            return inf.ObtenerFianza(query);
        }
    }
}
