using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Modelo;

namespace Controlador
{
    public class ControladorLiberacion
    {
        private ModeloLiberacion m_Liberacion = new ModeloLiberacion();

        public DataTable ObtenerFianzas()
        {
            return m_Liberacion.ObtenerFianzas();
        }

        public DataTable ObtenerDatosLiberación(string NroFianza, int año) // Botones "Consulta" y "Liberación"
        {
            return m_Liberacion.ObtenerDatosLiberación(NroFianza, año);
        }
    }
}
