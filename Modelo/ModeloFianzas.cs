using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

namespace Modelo
{
    public class ModeloFianzas
    {
        public DataTable ObtenerFianza(string query)
        {
            return new Informacion().ObtenerFianza(query);
        }

        public DataTable ObtenerCantidadFianzas(int año)
        {
            return new Informacion().ObtenerCantidadFianzas(año);
        }

        public int GestionarFianza(DataTable dt, int opc, int año)
        {
            int n = int.MinValue;
            Conexion_BDD conexion = new Conexion_BDD();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conexion.AbrirConexion();

            DataRow f = dt.Rows[0];

            try
            {
                if (opc == 1)
                {
                    if (año >= 1996 && año <= 2003)
                        cmd.CommandText = "INSERT INTO [Copia de Fianzas]([Nro de Fianza], [Fecha de Emision], [Nro Archivo], [Fecha de Vencimiento], [Fecha Recibida], Ano, Garante, [Rif Contribuyente], [Rif Agente], Cod_Tf, Asunto, Monto, Notaria, Tomo, Nro, [Fecha de Reg], NroOficio, [Ingreso al Sistema]) " +
                                          "VALUES('" + f["Nro de Fianza"].ToString() + "', '" + Convert.ToDateTime(f["Fecha de Emision"].ToString()).Date + "', " + long.Parse(f["Nro Archivo"].ToString()) + ", '" + Convert.ToDateTime(f["Fecha de Vencimiento"].ToString()).Date + "', '" + Convert.ToDateTime(f["Fecha Recibida"].ToString()).Date + "', " + Convert.ToInt32(f["Ano"].ToString()) + ", '" + f["Nombre_Garante"].ToString() + "', '" + f["Nombre_Consignatario"].ToString() + "', '" + f["Nombre_Agente"].ToString() + "', '" + Convert.ToByte(f["NaturalezaOperacion"].ToString()) + "', '" + f["Asunto"].ToString() + "', " + f["Monto"].ToString() + ", '" + f["Notaria"].ToString() + "', '" + f["Tomo"].ToString() + "', '" + f["Nro"].ToString() + "', '" + Convert.ToDateTime(f["Fecha de Reg"].ToString()).Date + "', " + long.Parse(f["NroOficio"].ToString()) + ", '" + Convert.ToDateTime(f["Ingreso al Sistema"].ToString()) + "')";
                    if (año >= 2004)
                        cmd.CommandText = "INSERT INTO Fianzas([Nro de Fianza], [Fecha de Emision], [Nro Archivo], [Fecha de Vencimiento], [Fecha Recibida], Ano, Garante, [Rif Contribuyente], [Rif Agente], Cod_Tf, Asunto, Monto, Notaria, Tomo, Nro, [Fecha de Reg], NroOficio, [Ingreso al Sistema]) " +
                                          "VALUES('" + f["Nro de Fianza"].ToString() + "', '" + Convert.ToDateTime(f["Fecha de Emision"].ToString()).Date + "', " + long.Parse(f["Nro Archivo"].ToString()) + ", '" + Convert.ToDateTime(f["Fecha de Vencimiento"].ToString()).Date + "', '" + Convert.ToDateTime(f["Fecha Recibida"].ToString()).Date + "', " + Convert.ToInt32(f["Ano"].ToString()) + ", '" + f["Nombre_Garante"].ToString() + "', '" + f["Nombre_Consignatario"].ToString() + "', '" + f["Nombre_Agente"].ToString() + "', '" + Convert.ToByte(f["NaturalezaOperacion"].ToString()) + "', '" + f["Asunto"].ToString() + "', " + f["Monto"].ToString() + ", '" + f["Notaria"].ToString() + "', '" + f["Tomo"].ToString() + "', '" + f["Nro"].ToString() + "', '" + Convert.ToDateTime(f["Fecha de Reg"].ToString()).Date + "', " + long.Parse(f["NroOficio"].ToString()) + ", '" + Convert.ToDateTime(f["Ingreso al Sistema"].ToString()) + "')";
                    cmd.CommandType = CommandType.Text;
                    n = cmd.ExecuteNonQuery();
                }
                else
                {
                    int filasAfectadas = int.MinValue;
                    if (año >= 1996 && año <= 2005)
                    {
                        cmd.CommandText = "UPDATE [Copia de Fianzas] SET [Nro de Fianza] = '" + f["Nro de Fianza"].ToString() + "', [Fecha de Emision] = '" + Convert.ToDateTime(f["Fecha de Emision"].ToString()).Date + "', [Nro Archivo] = " + long.Parse(f["Nro Archivo"].ToString()) + ", [Fecha de Vencimiento] = '" + Convert.ToDateTime(f["Fecha de Vencimiento"].ToString()).Date + "', [Fecha Recibida] = '" + Convert.ToDateTime(f["Fecha Recibida"].ToString()).Date + "', Garante = '" + f["Nombre_Garante"].ToString() + "' , [Rif Contribuyente] = '" + f["Nombre_Consignatario"].ToString() + "', [Rif Agente] = '" + f["Nombre_Agente"].ToString() + "'," +
                                          "Cod_Tf = '" + Convert.ToByte(f["NaturalezaOperacion"].ToString()) + "', Asunto = '" + f["Asunto"].ToString() + "', Monto = " + f["Monto"].ToString() + ", Notaria = '" + f["Notaria"].ToString() + "', Tomo = '" + f["Tomo"].ToString() + "', Nro = '" + f["Nro"].ToString() + "', [Fecha de Reg] = '" + Convert.ToDateTime(f["Fecha de Reg"].ToString()).Date + "', NroOficio = " + long.Parse(f["NroOficio"].ToString()) + " " +
                                          "WHERE idNroFianza = " + Convert.ToInt32(f["idNroFianza"].ToString()); // "WHERE [Nro de Fianza] = '" + f["Nro de Fianza"].ToString() + "' AND Ano = " + Convert.ToInt32(f["Ano"].ToString());
                        cmd.CommandType = CommandType.Text;
                        filasAfectadas = cmd.ExecuteNonQuery();
                        n = filasAfectadas;
                    }
                    if (año == 2004 || año == 2005)
                        if (filasAfectadas == 0)
                        {
                            cmd.CommandText = "UPDATE Fianzas SET [Nro de Fianza] = '" + f["Nro de Fianza"].ToString() + "', [Fecha de Emision] = '" + Convert.ToDateTime(f["Fecha de Emision"].ToString()).Date + "', [Nro Archivo] = " + long.Parse(f["Nro Archivo"].ToString()) + ", [Fecha de Vencimiento] = '" + Convert.ToDateTime(f["Fecha de Vencimiento"].ToString()).Date + "', [Fecha Recibida] = '" + Convert.ToDateTime(f["Fecha Recibida"].ToString()).Date + "', Garante = '" + f["Nombre_Garante"].ToString() + "' , [Rif Contribuyente] = '" + f["Nombre_Consignatario"].ToString() + "', [Rif Agente] = '" + f["Nombre_Agente"].ToString() + "'," +
                                              "Cod_Tf = '" + Convert.ToByte(f["NaturalezaOperacion"].ToString()) + "', Asunto = '" + f["Asunto"].ToString() + "', Monto = " + f["Monto"].ToString() + ", Notaria = '" + f["Notaria"].ToString() + "', Tomo = '" + f["Tomo"].ToString() + "', Nro = '" + f["Nro"].ToString() + "', [Fecha de Reg] = '" + Convert.ToDateTime(f["Fecha de Reg"].ToString()).Date + "', NroOficio = " + long.Parse(f["NroOficio"].ToString()) + " " +
                                              "WHERE idNroFianza = " + Convert.ToInt32(f["idNroFianza"].ToString()); // "WHERE [Nro de Fianza] = '" + f["Nro de Fianza"].ToString() + "' AND Ano = " + Convert.ToInt32(f["Ano"].ToString());
                            cmd.CommandType = CommandType.Text;
                            n = cmd.ExecuteNonQuery();
                        }
                    if (año >= 2006)
                    {
                        cmd.CommandText = "UPDATE Fianzas SET [Nro de Fianza] = '" + f["Nro de Fianza"].ToString() + "', [Fecha de Emision] = '" + Convert.ToDateTime(f["Fecha de Emision"].ToString()).Date + "', [Nro Archivo] = " + long.Parse(f["Nro Archivo"].ToString()) + ", [Fecha de Vencimiento] = '" + Convert.ToDateTime(f["Fecha de Vencimiento"].ToString()).Date + "', [Fecha Recibida] = '" + Convert.ToDateTime(f["Fecha Recibida"].ToString()).Date + "', Garante = '" + f["Nombre_Garante"].ToString() + "' , [Rif Contribuyente] = '" + f["Nombre_Consignatario"].ToString() + "', [Rif Agente] = '" + f["Nombre_Agente"].ToString() + "'," +
                                          "Cod_Tf = '" + Convert.ToByte(f["NaturalezaOperacion"].ToString()) + "', Asunto = '" + f["Asunto"].ToString() + "', Monto = " + f["Monto"].ToString() + ", Notaria = '" + f["Notaria"].ToString() + "', Tomo = '" + f["Tomo"].ToString() + "', Nro = '" + f["Nro"].ToString() + "', [Fecha de Reg] = '" + Convert.ToDateTime(f["Fecha de Reg"].ToString()).Date + "', NroOficio = " + long.Parse(f["NroOficio"].ToString()) + " " +
                                          "WHERE idNroFianza = " + Convert.ToInt32(f["idNroFianza"].ToString()); // "WHERE [Nro de Fianza] = '" + f["Nro de Fianza"].ToString() + "' AND Ano = " + Convert.ToInt32(f["Ano"].ToString());
                        cmd.CommandType = CommandType.Text;
                        n = cmd.ExecuteNonQuery();
                    }
                }
                return n;
            }
            catch (Exception)
            {
                return n;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
