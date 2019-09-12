using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

using Modelo;

namespace Controlador
{
    public class ControladorDatosLiberacion
    {
        Informacion inf = new Informacion();

        public string Cadena(string query, string campo)
        {
            return inf.Cadena(query, campo);
        }

        public DataTable ObtenerInfo(string consulta, string campo)
        {
            return inf.ObtenerInfo(consulta, campo);
        }

        public int LiberarFianza(string query)
        {
            return new ModeloDatosLiberacion().LiberarFianza(query);
        }
    }
}
