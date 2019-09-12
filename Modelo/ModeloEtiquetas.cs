using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

namespace Modelo
{
    public class ModeloEtiquetas
    {
        public DataTable ObtenerFianza(string query)
        {
            return new Informacion().ObtenerFianza(query);
        }
    }
}
