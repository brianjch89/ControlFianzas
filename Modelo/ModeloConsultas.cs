using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

namespace Modelo
{
    public class ModeloConsultas
    {

        public DataTable ObtenerCantidadFianzas(int año)
        {
            return new Informacion().ObtenerCantidadFianzas(año);
        }

        public DataTable ObtenerInformacionNroFianza(string NroFianza)
        {
            Conexion_BDD conexion = new Conexion_BDD();
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "SELECT [Nro de Fianza], [Fecha de Emision], [Nro Archivo], [Fecha de Vencimiento], [Fecha Recibida], Ano, Garante, [Rif Contribuyente], [Rif Agente], Cod_Tf, Asunto, Monto, Notaria, Tomo, Nro, [Fecha de Reg], NvoOficio FROM Fianzas WHERE [Nro de Fianza] = '" + NroFianza + "'";
                cmd.CommandType = CommandType.Text;

                OleDbDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("Nro de Fianza");
                dt.Columns.Add("Fecha de Emision");
                dt.Columns.Add("Nro Archivo");
                dt.Columns.Add("Fecha de Vencimiento");
                dt.Columns.Add("Fecha Recibida");
                dt.Columns.Add("Ano");
                dt.Columns.Add("Nombre_Garante");
                dt.Columns.Add("Nombre_Consignatario");
                dt.Columns.Add("Nombre_Agente");
                dt.Columns.Add("NaturalezaOperacion");
                dt.Columns.Add("Asunto");
                dt.Columns.Add("Monto");
                dt.Columns.Add("Notaria");
                dt.Columns.Add("Tomo");
                dt.Columns.Add("Nro");
                dt.Columns.Add("Fecha de Reg");
                dt.Columns.Add("NroOficio");

                Informacion inf = new Informacion();
                DataRow fi = null;
                while (reader.Read())
                {
                    fi = dt.NewRow();

                    fi["Nro de Fianza"] = reader["Nro de Fianza"].ToString();


                    string fecha = reader["Fecha de Emision"].ToString();
                    if (fecha == string.Empty)
                        fi["Fecha de Emision"] = DateTime.MinValue;
                    else
                        fi["Fecha de Emision"] = Convert.ToDateTime(reader["Fecha de Emision"].ToString());


                    fi["Nro Archivo"] = long.Parse(reader["Nro Archivo"].ToString());


                    fecha = reader["Fecha de Vencimiento"].ToString();
                    if (fecha == string.Empty)
                        fi["Fecha de Vencimiento"] = DateTime.MinValue;
                    else
                        fi["Fecha de Vencimiento"] = Convert.ToDateTime(reader["Fecha de Vencimiento"].ToString());


                    fecha = reader["Fecha Recibida"].ToString();
                    if (fecha == string.Empty)
                        fi["Fecha Recibida"] = DateTime.MinValue;
                    else
                        fi["Fecha Recibida"] = Convert.ToDateTime(reader["Fecha Recibida"].ToString());


                    fi["Ano"] = Convert.ToInt32(reader["Ano"].ToString());
                    fi["Nombre_Garante"] = Convert.ToString(inf.ObtenerInfo("SELECT Nombre_Garante FROM Garantes WHERE Rif_Garante = '" + reader["Garante"].ToString() + "'", "Nombre_Garante"));
                    fi["Nombre_Consignatario"] = Convert.ToString(inf.ObtenerInfo("SELECT Nombre_Consignatario FROM Consignatarios WHERE Rif_Consignatario = '" + reader["Rif Contribuyente"].ToString() + "'", "Nombre_Consignatario"));
                    fi["Nombre_Agente"] = Convert.ToString(inf.ObtenerInfo("SELECT Nombre_Agente FROM [Agentes Aduanales] WHERE Rif_Agentes = '" + reader["Rif Agente"].ToString() + "'", "Nombre_Agente"));
                    fi["NaturalezaOperacion"] = Convert.ToString(inf.ObtenerInfo("SELECT DesTipFian FROM [Tipo de Fianzas] WHERE Cod_Tf = " + Convert.ToInt32(reader["Cod_Tf"].ToString()), "DesTipFian"));
                    fi["Asunto"] = reader["Asunto"].ToString();
                    fi["Monto"] = Convert.ToDouble(reader["Monto"].ToString());
                    fi["Notaria"] = reader["Notaria"].ToString();
                    fi["Tomo"] = reader["Tomo"].ToString();
                    fi["Nro"] = reader["Nro"].ToString();


                    fecha = reader["Fecha de Reg"].ToString();
                    if (fecha == string.Empty)
                        fi["Fecha de Reg"] = DateTime.MinValue;
                    else
                        fi["Fecha de Reg"] = Convert.ToDateTime(reader["Fecha de Reg"].ToString());


                    fi["NroOficio"] = reader["NvoOficio"].ToString();
                }
                dt.Rows.Add(fi);
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

        public DataTable ObtenerDatosLiberación(string NroFianza, int año) // Botones "Consulta" y "Liberación"
        {
            Conexion_BDD conexion = new Conexion_BDD();
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                DataTable dt = CrearColumnasTabla();
                cmd.Connection = conexion.AbrirConexion();
                if (año >= 0 && año <= 2005)
                {
                    cmd.CommandText = "SELECT [Fecha Liberacion], Cod_Lib FROM [Copia de Fianzas] WHERE [Nro de Fianza] = '" + NroFianza + "'";
                    cmd.CommandType = CommandType.Text;
                    OleDbDataReader reader = cmd.ExecuteReader();
                    dt = CargarTabla(reader, dt);
                    reader.Close();
                }
                if (año == 2004 || año == 2005)
                    if (dt.Rows.Count == 0)
                    {
                        cmd.CommandText = "SELECT [Fecha Liberacion], Cod_Lib FROM Fianzas WHERE [Nro de Fianza] = '" + NroFianza + "'";
                        cmd.CommandType = CommandType.Text;
                        OleDbDataReader reader = cmd.ExecuteReader();
                        dt = CargarTabla(reader, dt);
                        reader.Close();
                    }
                if (año >= 2006)
                {
                    cmd.CommandText = "SELECT [Fecha Liberacion], Cod_Lib FROM Fianzas WHERE [Nro de Fianza] = '" + NroFianza + "'";
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

        public DataTable CrearColumnasTabla()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Fecha Liberacion");
            dt.Columns.Add("Cod_Lib");

            return dt;
        }

        public DataTable CargarTabla(OleDbDataReader reader, DataTable dt)
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
