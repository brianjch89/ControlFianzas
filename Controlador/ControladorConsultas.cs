using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Modelo;

namespace Controlador
{
    public class ControladorConsultas
    {
        private ModeloConsultas m_Consultas = new ModeloConsultas();

        public DataTable ObtenerCantidadFianzas(int año)
        {
            return m_Consultas.ObtenerCantidadFianzas(año);
        }

        public DataTable ObtenerInformacionNroFianza(string NroFianza)
        {
            return m_Consultas.ObtenerInformacionNroFianza(NroFianza);
        }

        public DataTable ObtenerDatosLiberación(string idNroFianza, int año) // Botones "Consulta" y "Liberación"
        {
            return m_Consultas.ObtenerDatosLiberación(idNroFianza, año);
        }
    }
}
