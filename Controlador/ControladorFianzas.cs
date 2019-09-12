using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
using Modelo;

namespace Controlador
{
    public class ControladorFianzas
    {
        public ModeloFianzas m_Fianzas = new ModeloFianzas();

        public DataTable ObtenerCantidadFianzas(int año)
        {
            return m_Fianzas.ObtenerCantidadFianzas(año);
        }

        public DataTable ObtenerFianza(string query)
        {
            return m_Fianzas.ObtenerFianza(query);
        }

        public int GestionarFianza(DataTable f, int opc, int año)
        {
            return m_Fianzas.GestionarFianza(f, opc, año);
        }
    }
}
