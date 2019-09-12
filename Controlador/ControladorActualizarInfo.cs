using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Modelo;

namespace Controlador
{
    public class ControladorActualizarInfo
    {
        private Informacion inf = new Informacion();

        public DataTable ObtenerInfoTablaConsignatarios()
        {
            return inf.ObtenerInfoTablaConsignatarios();
        }


        public int GestionarPredeterminados(string query)
        {
            return inf.GestionarPredeterminados(query);
        }

        public DataTable BuscarPredeterminado(string query, int opc)
        {
            return inf.BuscarPredeterminado(query, opc);
        }


        public DataTable ObtenerInfoTablaAgentes()
        {
            return inf.ObtenerInfoTablaAgentes();
        }

        public DataTable ObtenerInfoTablaGarantes()
        {
            return inf.ObtenerInfoTablaGarantes();
        }

        public DataTable ObtenerInfoTablaTipoFianza()
        {
            return inf.ObtenerInfoTablaTipoFianza();
        }

        public DataTable ObtenerInfoTablaOficios()
        {
            return inf.ObtenerInfoTablaOficios();
        }

        public DataTable ObtenerInfoTablaGerente()
        {
            return inf.ObtenerInfoTablaGerente();
        }

        public DataTable ObtenerInfoTablaMotivos()
        {
            return inf.ObtenerInfoTablaMotivos();
        }
    }
}
