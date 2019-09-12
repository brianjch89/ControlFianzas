using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

namespace Modelo
{
    public class ModeloDatosLiberacion
    {
        private Conexion_BDD conexion = new Conexion_BDD();
        OleDbCommand cmd = new OleDbCommand();

        public int LiberarFianza(string query)
        {
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;

                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
