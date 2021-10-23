using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

namespace Modelo
{
    public class ModeloLiberacion
    {
        Informacion inf = new Informacion();

        public DataTable ObtenerFianzas()
        {
            Conexion_BDD conexion = new Conexion_BDD();
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                Informacion inf = new Informacion();
                DataTable dt = inf.CrearColumnasTabla();
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "SELECT idNroFianza, [Nro de Fianza], [Fecha de Emision], [Nro Archivo], [Fecha de Vencimiento], [Fecha Recibida], Ano, g.Nombre_Garante, c.Nombre_Consignatario, a.Nombre_Agente, tf.DesTipFian AS NaturalezaOperacion, Asunto, Monto, Notaria, Tomo, Nro, [Fecha de Reg], o.NroOficio " +
                                  "FROM (((((Fianzas AS f LEFT JOIN Garantes AS g ON (g.Rif_Garante = f.Garante)) " +
                                  "LEFT JOIN Consignatarios AS c ON (c.Rif_Consignatario = f.[Rif Contribuyente])) " +
                                  "LEFT JOIN Agentes AS a ON (a.Rif_Agentes = f.[Rif Agente])) " +
                                  "LEFT JOIN [Tipo de Fianzas] AS tf ON (tf.Cod_Tf = f.Cod_Tf)) " +
                                  "LEFT JOIN Oficios AS o ON (o.Id = f.NroOficio)) " +
                                  "ORDER BY Ano DESC, [Nro Archivo] DESC";
                cmd.CommandType = CommandType.Text;
                OleDbDataReader reader = cmd.ExecuteReader();
                dt = inf.CargarTabla(reader, dt);
                reader.Close();

                cmd.CommandText = "SELECT idNroFianza, [Nro de Fianza], [Fecha de Emision], [Nro Archivo], [Fecha de Vencimiento], [Fecha Recibida], Ano, g.Nombre_Garante, c.Nombre_Consignatario, a.Nombre_Agente, tf.DesTipFian AS NaturalezaOperacion, Asunto, Monto, Notaria, Tomo, Nro, [Fecha de Reg], o.NroOficio " +
                                  "FROM ((((([Copia de Fianzas] AS f LEFT JOIN Garantes AS g ON (g.Rif_Garante = f.Garante)) " +
                                  "LEFT JOIN Consignatarios AS c ON (c.Rif_Consignatario = f.[Rif Contribuyente])) " +
                                  "LEFT JOIN Agentes AS a ON (a.Rif_Agentes = f.[Rif Agente])) " +
                                  "LEFT JOIN [Tipo de Fianzas] AS tf ON (tf.Cod_Tf = f.Cod_Tf)) " +
                                  "LEFT JOIN Oficios AS o ON (o.Id = f.NroOficio)) " +
                                  "ORDER BY Ano DESC, [Nro Archivo] DESC";
                cmd.CommandType = CommandType.Text;
                OleDbDataReader reader1 = cmd.ExecuteReader();
                dt = inf.CargarTabla(reader1, dt);
                reader1.Close();

                return dt;
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

        public DataTable ObtenerDatosLiberación(string idNroFianza, int año) // Botones "Consulta" y "Liberación"
        {
            Conexion_BDD conexion = new Conexion_BDD();
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                DataTable dt = CrearColumnasTabla();
                cmd.Connection = conexion.AbrirConexion();
                if (año >= 0 && año <= 2005)
                {
                    cmd.CommandText = "SELECT [Fecha Liberacion], Cod_Lib FROM [Copia de Fianzas] WHERE idNroFianza = " + Convert.ToInt32(idNroFianza);
                    cmd.CommandType = CommandType.Text;
                    OleDbDataReader reader = cmd.ExecuteReader();
                    dt = CargarTabla(reader, dt);
                    reader.Close();
                }
                if (año == 2004 || año == 2005)
                    if (dt.Rows.Count == 0)
                    {
                        cmd.CommandText = "SELECT [Fecha Liberacion], Cod_Lib FROM Fianzas WHERE idNroFianza = " + Convert.ToInt32(idNroFianza);
                        cmd.CommandType = CommandType.Text;
                        OleDbDataReader reader = cmd.ExecuteReader();
                        dt = CargarTabla(reader, dt);
                        reader.Close();
                    }
                if (año >= 2006)
                {
                    cmd.CommandText = "SELECT [Fecha Liberacion], Cod_Lib FROM Fianzas WHERE idNroFianza = " + Convert.ToInt32(idNroFianza);
                    cmd.CommandType = CommandType.Text;
                    OleDbDataReader reader = cmd.ExecuteReader();
                    dt = CargarTabla(reader, dt);
                    reader.Close();
                }

                return dt;
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

        private DataTable CrearColumnasTabla()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Fecha Liberacion");
            dt.Columns.Add("Cod_Lib");

            return dt;
        }

        private DataTable CargarTabla(OleDbDataReader reader, DataTable dt)
        {
            DataRow fi = null;
            if (reader.Read())
            {
                fi = dt.NewRow();

                string fecha = reader["Fecha Liberacion"].ToString();
                if (fecha == string.Empty)
                    fi["Fecha Liberacion"] = DateTime.MinValue;
                else
                    fi["Fecha Liberacion"] = Convert.ToDateTime(reader["Fecha Liberacion"].ToString());

                if (reader["Cod_Lib"].ToString().Equals(string.Empty))
                    fi["Cod_Lib"] = 0;
                else
                    fi["Cod_Lib"] = Convert.ToByte(reader["Cod_Lib"].ToString());

                dt.Rows.Add(fi);
            }

            return dt;
        }
    }
}
