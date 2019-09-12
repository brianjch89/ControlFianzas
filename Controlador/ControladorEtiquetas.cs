using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Modelo;

namespace Controlador
{
    public class ControladorEtiquetas
    {
        ModeloEtiquetas m_Etiquetas = new ModeloEtiquetas();

        public DataTable ObtenerFianza(string query)
        {
            return m_Etiquetas.ObtenerFianza(query);
        }
    }
}
