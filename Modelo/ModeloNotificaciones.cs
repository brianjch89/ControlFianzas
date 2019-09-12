using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

namespace Modelo
{
    public class ModeloNotificaciones
    {
        public DataTable ObtenerFianzasPorVencer(int mes)
        {
            Conexion_BDD conexion = new Conexion_BDD();
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                DataTable f = new DataTable();
                DateTime fechaActual = DateTime.Today.Date;
                cmd.Connection = conexion.AbrirConexion();
                if (mes < 10)
                {
                    cmd.CommandText = "SELECT [Nro de Fianza], [Nro Archivo], [Fecha de Vencimiento], Ano, g.Nombre_Garante, a.Nombre_Agente " +
                                      "FROM ((Fianzas AS f LEFT JOIN Garantes AS g ON (g.Rif_Garante = f.Garante)) " +
                                      "LEFT JOIN Agentes AS a ON (a.Rif_Agentes = f.[Rif Agente])) " +
                                      "WHERE YEAR([Fecha de Vencimiento]) = " + fechaActual.Year + " AND (MONTH([Fecha de Vencimiento]) - " + mes + ") = 3";
                    cmd.CommandType = CommandType.Text;

                    OleDbDataReader reader = cmd.ExecuteReader();
                    f.Load(reader);
                }
                else
                {
                    if (mes == 10)
                        cmd.CommandText = "SELECT [Nro de Fianza], [Nro Archivo], [Fecha de Vencimiento], Ano, g.Nombre_Garante, a.Nombre_Agente " +
                                          "FROM ((Fianzas AS f LEFT JOIN Garantes AS g ON (g.Rif_Garante = f.Garante)) " +
                                          "LEFT JOIN Agentes AS a ON (a.Rif_Agentes = f.[Rif Agente])) " +
                                          "WHERE YEAR([Fecha de Vencimiento]) = " + (fechaActual.Year + 1) + " AND MONTH([Fecha de Vencimiento]) = 1";
                    else if (mes == 11)
                        cmd.CommandText = "SELECT [Nro de Fianza], [Nro Archivo], [Fecha de Vencimiento], Ano, g.Nombre_Garante, a.Nombre_Agente " +
                                          "FROM ((Fianzas AS f LEFT JOIN Garantes AS g ON (g.Rif_Garante = f.Garante)) " +
                                          "LEFT JOIN Agentes AS a ON (a.Rif_Agentes = f.[Rif Agente])) " +
                                          "WHERE YEAR([Fecha de Vencimiento]) = " + (fechaActual.Year + 1) + " AND MONTH([Fecha de Vencimiento]) = 2";
                    else if (mes == 12)
                        cmd.CommandText = "SELECT [Nro de Fianza], [Nro Archivo], [Fecha de Vencimiento], Ano, g.Nombre_Garante, a.Nombre_Agente " +
                                          "FROM ((Fianzas AS f LEFT JOIN Garantes AS g ON (g.Rif_Garante = f.Garante)) " +
                                          "LEFT JOIN Agentes AS a ON (a.Rif_Agentes = f.[Rif Agente])) " +
                                          "WHERE YEAR([Fecha de Vencimiento]) = " + (fechaActual.Year + 1) + " AND MONTH([Fecha de Vencimiento]) = 3";
                    cmd.CommandType = CommandType.Text;

                    OleDbDataReader reader = cmd.ExecuteReader();
                    f.Load(reader);
                }

                return f;
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
