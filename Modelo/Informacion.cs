using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

namespace Modelo
{
    public class Informacion
    {
        public Informacion() { }

        public DataTable ObtenerCantidadFianzas(int año)
        {
            DataTable dt = CrearColumnasTabla();
            Conexion_BDD conexion = new Conexion_BDD();
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                if (año >= 0 && año <= 2005)
                {
                    cmd.CommandText = "SELECT [Nro de Fianza], [Fecha de Emision], [Nro Archivo], [Fecha de Vencimiento], [Fecha Recibida], Ano, g.Nombre_Garante, c.Nombre_Consignatario, a.Nombre_Agente, tf.DesTipFian AS NaturalezaOperacion, Asunto, Monto, Notaria, Tomo, Nro, [Fecha de Reg], o.NroOficio " +
                                      "FROM ((((([Copia de Fianzas] AS f LEFT JOIN Garantes AS g ON (g.Rif_Garante = f.Garante)) " +
                                      "LEFT JOIN Consignatarios AS c ON (c.Rif_Consignatario = f.[Rif Contribuyente])) " +
                                      "LEFT JOIN Agentes AS a ON (a.Rif_Agentes = f.[Rif Agente])) " +
                                      "LEFT JOIN [Tipo de Fianzas] AS tf ON (tf.Cod_Tf = f.Cod_Tf)) " +
                                      "LEFT JOIN Oficios AS o ON (o.Id = f.NroOficio)) " +
                                      "WHERE Ano = " + año + " ORDER BY [Nro Archivo]";
                    cmd.CommandType = CommandType.Text;
                    OleDbDataReader reader = cmd.ExecuteReader();
                    dt = CargarTabla(reader, dt);
                    reader.Close();
                }
                if (año == 2004 || año == 2005)
                {
                    cmd.CommandText = "SELECT [Nro de Fianza], [Fecha de Emision], [Nro Archivo], [Fecha de Vencimiento], [Fecha Recibida], Ano, g.Nombre_Garante, c.Nombre_Consignatario, a.Nombre_Agente, tf.DesTipFian AS NaturalezaOperacion, Asunto, Monto, Notaria, Tomo, Nro, [Fecha de Reg], o.NroOficio " +
                                      "FROM (((((Fianzas AS f LEFT JOIN Garantes AS g ON (g.Rif_Garante = f.Garante)) " +
                                      "LEFT JOIN Consignatarios AS c ON (c.Rif_Consignatario = f.[Rif Contribuyente])) " +
                                      "LEFT JOIN Agentes AS a ON (a.Rif_Agentes = f.[Rif Agente])) " +
                                      "LEFT JOIN [Tipo de Fianzas] AS tf ON (tf.Cod_Tf = f.Cod_Tf)) " +
                                      "LEFT JOIN Oficios AS o ON (o.Id = f.NroOficio)) " +
                                      "WHERE Ano = " + año + " ORDER BY [Nro Archivo]";
                    cmd.CommandType = CommandType.Text;
                    OleDbDataReader reader = cmd.ExecuteReader();
                    dt = CargarTabla(reader, dt);
                    reader.Close();
                }

                if (año >= 2006)
                {
                    cmd.CommandText = "SELECT [Nro de Fianza], [Fecha de Emision], [Nro Archivo], [Fecha de Vencimiento], [Fecha Recibida], Ano, g.Nombre_Garante, c.Nombre_Consignatario, a.Nombre_Agente, tf.DesTipFian AS NaturalezaOperacion, Asunto, Monto, Notaria, Tomo, Nro, [Fecha de Reg], o.NroOficio " +
                                      "FROM (((((Fianzas AS f LEFT JOIN Garantes AS g ON (g.Rif_Garante = f.Garante)) " +
                                      "LEFT JOIN Consignatarios AS c ON (c.Rif_Consignatario = f.[Rif Contribuyente])) " +
                                      "LEFT JOIN Agentes AS a ON (a.Rif_Agentes = f.[Rif Agente])) " +
                                      "LEFT JOIN [Tipo de Fianzas] AS tf ON (tf.Cod_Tf = f.Cod_Tf)) " +
                                      "LEFT JOIN Oficios AS o ON (o.Id = f.NroOficio)) " +
                                      "WHERE Ano = " + año + " ORDER BY [Nro Archivo]";
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

            return dt;
        }

        public DataTable CargarTabla(OleDbDataReader reader, DataTable dt)
        {
            DataRow fi;

            while (reader.Read())
            {
                fi = dt.NewRow();

                fi["Nro de Fianza"] = reader["Nro de Fianza"].ToString();


                string fecha = reader["Fecha de Emision"].ToString();
                if (fecha == string.Empty)
                    fi["Fecha de Emision"] = DateTime.MinValue;
                else
                    fi["Fecha de Emision"] = Convert.ToDateTime(reader["Fecha de Emision"].ToString());


                fi["Nro Archivo"] = reader["Nro Archivo"].ToString();


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


                fi["Ano"] = reader["Ano"].ToString();
                fi["Nombre_Garante"] = reader["Nombre_Garante"].ToString(); 
                fi["Nombre_Consignatario"] = reader["Nombre_Consignatario"].ToString();
                fi["Nombre_Agente"] = reader["Nombre_Agente"]; 
                fi["NaturalezaOperacion"] = reader["NaturalezaOperacion"].ToString();
                fi["Asunto"] = reader["Asunto"].ToString();
                fi["Monto"] = reader["Monto"].ToString();
                fi["Notaria"] = reader["Notaria"].ToString();
                fi["Tomo"] = reader["Tomo"].ToString();
                fi["Nro"] = reader["Nro"].ToString();


                fecha = reader["Fecha de Reg"].ToString();
                if (fecha == string.Empty)
                    fi["Fecha de Reg"] = DateTime.MinValue;
                else
                    fi["Fecha de Reg"] = Convert.ToDateTime(reader["Fecha de Reg"].ToString());


                if (reader["NroOficio"].ToString().Equals(string.Empty))
                    fi["NroOficio"] = string.Empty;
                else
                    fi["NroOficio"] = reader["NroOficio"].ToString();

                dt.Rows.Add(fi);
                //fi = null;
            }
            return dt;
        }

        public DataTable ObtenerFianza(string query)
        {
            Conexion_BDD conexion = new Conexion_BDD();
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;

                OleDbDataReader reader = cmd.ExecuteReader();

                // Si lo que se quiere es buscar la información de una fianza almacenada para ser mostrada...
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

                DataRow fi = dt.NewRow();
                if (reader.Read())
                {
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
                    fi["Nombre_Garante"] = reader["Nombre_Garante"].ToString();
                    fi["Nombre_Consignatario"] = reader["Nombre_Consignatario"].ToString();
                    fi["Nombre_Agente"] = reader["Nombre_Agente"];
                    fi["NaturalezaOperacion"] = reader["NaturalezaOperacion"].ToString();
                    fi["Asunto"] = reader["Asunto"].ToString();
                    fi["Monto"] = reader["Monto"].ToString();
                    fi["Notaria"] = reader["Notaria"].ToString();
                    fi["Tomo"] = reader["Tomo"].ToString();
                    fi["Nro"] = reader["Nro"].ToString();


                    fecha = reader["Fecha de Reg"].ToString();
                    if (fecha == string.Empty)
                        fi["Fecha de Reg"] = DateTime.MinValue;
                    else
                        fi["Fecha de Reg"] = Convert.ToDateTime(reader["Fecha de Reg"].ToString());


                    if (reader["NroOficio"].ToString().Equals(string.Empty))
                        fi["NroOficio"] = string.Empty;
                    else
                        fi["NroOficio"] = reader["NroOficio"].ToString();

                    dt.Rows.Add(fi);
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

        public string Cadena(string query, string campo)
        {
            Conexion_BDD conexion = new Conexion_BDD();
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;

                OleDbDataReader reader = cmd.ExecuteReader();

                string registro = string.Empty;

                if (reader.Read())
                    registro = reader[campo].ToString();

                return registro;
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

        public DataTable ObtenerInfo(string consulta, string campo)
        {
            Conexion_BDD conexion = new Conexion_BDD();
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = consulta;
                cmd.CommandType = CommandType.Text;

                OleDbDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add(campo);

                DataRow registro = null;

                while (reader.Read())
                {
                    registro = dt.NewRow();
                    registro[campo] = reader[campo].ToString();
                    dt.Rows.Add(registro);
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


        public int GestionarPredeterminados(string query)
        {
            Conexion_BDD conexion = new Conexion_BDD();
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;

                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return int.MinValue;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public DataTable BuscarPredeterminado(string query, int opc)
        {
            Conexion_BDD conexion = new Conexion_BDD();
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;

                OleDbDataReader reader = cmd.ExecuteReader();

                if (opc == 1)
                {
                    DataTable consignatarios = new DataTable();
                    consignatarios.Load(reader);
                    return consignatarios;
                }
                else if (opc == 2)
                {
                    DataTable agentes = new DataTable();
                    agentes.Load(reader);
                    return agentes;
                }
                else if (opc == 3)
                {
                    DataTable garantes = new DataTable();
                    garantes.Columns.Add("Rif_Garante");
                    garantes.Columns.Add("Nombre_Garante");
                    garantes.Columns.Add("Siglas");
                    garantes.Columns.Add("Direccion");
                    garantes.Columns.Add("Telefono");
                    garantes.Columns.Add("Nro_Aprobacion");
                    garantes.Columns.Add("OficioNro");
                    garantes.Columns.Add("Fecha_Oficio");

                    DataRow ga = garantes.NewRow();
                    if (reader.Read())
                    {
                        ga["Rif_Garante"] = reader["Rif_Garante"].ToString();
                        ga["Nombre_Garante"] = reader["Nombre_Garante"].ToString();
                        ga["Siglas"] = reader["Siglas"].ToString();
                        ga["Direccion"] = reader["Direccion"].ToString();
                        ga["Telefono"] = reader["Telefono"].ToString();
                        ga["Nro_Aprobacion"] = reader["Nro_Aprobacion"].ToString();
                        ga["OficioNro"] = reader["OficioNro"].ToString();

                        string fecha = reader["Fecha_Oficio"].ToString();
                        if (fecha.Equals(string.Empty))
                            ga["Fecha_Oficio"] = DateTime.MinValue;
                        else
                            ga["Fecha_Oficio"] = DateTime.Parse(DateTime.Parse(reader["Fecha_Oficio"].ToString()).ToString("dd/MM/yy"));

                        garantes.Rows.Add(ga);
                    }
                    return garantes;
                }

                else if (opc == 4)
                {
                    DataTable tipoFianzas = new DataTable();
                    tipoFianzas.Load(reader);
                    return tipoFianzas;
                }
                else if (opc == 5)
                {
                    DataTable oficios = new DataTable();
                    oficios.Columns.Add("NroOficio");
                    oficios.Columns.Add("Fecha de Oficio");
                    oficios.Columns.Add("Fecha_Vence");
                    oficios.Columns.Add("TipoDeFianza");
                    oficios.Columns.Add("Nombre_Consignatario");

                    DataRow ofic = oficios.NewRow();
                    if (reader.Read())
                    {
                        ofic["NroOficio"] = reader["NroOficio"].ToString();

                        string fecha = reader["Fecha de Oficio"].ToString();
                        if (fecha.Equals(string.Empty))
                            ofic["Fecha de Oficio"] = DateTime.MinValue;
                        else
                            ofic["Fecha de Oficio"] = Convert.ToDateTime(reader["Fecha de Oficio"].ToString());

                        fecha = reader["Fecha_Vence"].ToString();
                        if (fecha.Equals(string.Empty))
                            ofic["Fecha_Vence"] = DateTime.MinValue;
                        else
                            ofic["Fecha_Vence"] = Convert.ToDateTime(reader["Fecha_Vence"].ToString());

                        ofic["TipoDeFianza"] = reader["TipoDeFianza"].ToString();
                        ofic["Nombre_Consignatario"] = reader["Nombre_Consignatario"].ToString();

                        oficios.Rows.Add(ofic);
                    }
                    return oficios;
                }
                else if (opc == 6)
                {
                    DataTable gerentes = new DataTable();
                    gerentes.Columns.Add("Nombre");
                    gerentes.Columns.Add("Cargo");
                    gerentes.Columns.Add("Providencia_Gerente");
                    gerentes.Columns.Add("FechaProvidencia_Gerente");
                    gerentes.Columns.Add("GO_Gerente");
                    gerentes.Columns.Add("FechaGaceta_Gerente");
                    gerentes.Columns.Add("Providencia");
                    gerentes.Columns.Add("GO");
                    gerentes.Columns.Add("FechaGaceta");
                    gerentes.Columns.Add("Siglas");
                    gerentes.Columns.Add("GerenteActivo");

                    DataRow ge = gerentes.NewRow();
                    if (reader.Read())
                    {
                        ge = gerentes.NewRow();
                        ge["Nombre"] = reader["Nombre"].ToString();
                        ge["Cargo"] = reader["Cargo"].ToString();
                        ge["Providencia_Gerente"] = reader["Providencia_Gerente"].ToString();


                        string fecha = reader["FechaProvidencia_Gerente"].ToString();
                        if (fecha == string.Empty)
                            ge["FechaProvidencia_Gerente"] = DateTime.MinValue;
                        else
                            ge["FechaProvidencia_Gerente"] = Convert.ToDateTime(reader["FechaProvidencia_Gerente"].ToString());


                        ge["GO_Gerente"] = reader["GO_Gerente"].ToString();


                        fecha = reader["FechaGaceta_Gerente"].ToString();
                        if (fecha == string.Empty)
                            ge["FechaGaceta_Gerente"] = DateTime.MinValue;
                        else
                            ge["FechaGaceta_Gerente"] = Convert.ToDateTime(reader["FechaGaceta_Gerente"].ToString());


                        ge["Providencia"] = reader["Providencia"].ToString();
                        ge["GO"] = reader["GO"].ToString();


                        fecha = reader["FechaGaceta"].ToString();
                        if (fecha == string.Empty)
                            ge["FechaGaceta"] = DateTime.MinValue;
                        else
                            ge["FechaGaceta"] = Convert.ToDateTime(reader["FechaGaceta"].ToString());


                        ge["Siglas"] = reader["Siglas"].ToString();
                        ge["GerenteActivo"] = reader["GerenteActivo"].ToString();

                        gerentes.Rows.Add(ge);
                    }
                    return gerentes;
                }
                else
                {
                    DataTable motivos = new DataTable();
                    motivos.Load(reader);

                    return motivos;
                }
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


        public DataTable ObtenerInfoTablaConsignatarios()
        {
            Conexion_BDD conexion = new Conexion_BDD();
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "SELECT Rif_Consignatario, Nombre_Consignatario, Siglas, Representante, Dirección, Telefono, email FROM Consignatarios";
                cmd.CommandType = CommandType.Text;

                OleDbDataReader reader = cmd.ExecuteReader();

                DataTable consignatarios = new DataTable();
                consignatarios.Load(reader);

                return consignatarios;
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

        public DataTable ObtenerInfoTablaAgentes()
        {
            Conexion_BDD conexion = new Conexion_BDD();
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "SELECT Rif_Agentes, Nombre_Agente, Siglas_Agente, Representante, [Domicilio Fiscal], Telefono FROM Agentes";
                cmd.CommandType = CommandType.Text;

                OleDbDataReader reader = cmd.ExecuteReader();

                DataTable agentes = new DataTable();
                agentes.Load(reader);

                return agentes;
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

        public DataTable ObtenerInfoTablaGarantes()
        {
            Conexion_BDD conexion = new Conexion_BDD();
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "SELECT Rif_Garante, Nombre_Garante, Siglas, Direccion, Telefono, Nro_Aprobacion, OficioNro, Fecha_Oficio FROM Garantes";
                cmd.CommandType = CommandType.Text;

                OleDbDataReader reader = cmd.ExecuteReader();

                DataTable garantes = new DataTable();
                garantes.Columns.Add("Rif_Garante");
                garantes.Columns.Add("Nombre_Garante");
                garantes.Columns.Add("Siglas");
                garantes.Columns.Add("Direccion");
                garantes.Columns.Add("Telefono");
                garantes.Columns.Add("Nro_Aprobacion");
                garantes.Columns.Add("OficioNro");
                garantes.Columns.Add("Fecha_Oficio");

                DataRow ga = null;
                while (reader.Read())
                {
                    ga = garantes.NewRow();
                    ga["Rif_Garante"] = reader["Rif_Garante"].ToString();
                    ga["Nombre_Garante"] = reader["Nombre_Garante"].ToString();
                    ga["Siglas"] = reader["Siglas"].ToString();
                    ga["Direccion"] = reader["Direccion"].ToString();
                    ga["Telefono"] = reader["Telefono"].ToString();
                    ga["Nro_Aprobacion"] = reader["Nro_Aprobacion"].ToString();
                    ga["OficioNro"] = reader["OficioNro"].ToString();

                    string fecha = reader["Fecha_Oficio"].ToString();
                    if (fecha == string.Empty)
                        ga["Fecha_Oficio"] = DateTime.MinValue;
                    else
                        ga["Fecha_Oficio"] = DateTime.Parse(DateTime.Parse(reader["Fecha_Oficio"].ToString()).ToString("dd/MM/yy"));

                    garantes.Rows.Add(ga);
                }

                return garantes;
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

        public DataTable ObtenerInfoTablaTipoFianza()
        {
            Conexion_BDD conexion = new Conexion_BDD();
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "SELECT * FROM [Tipo de Fianzas] ORDER BY Cod_Tf";
                cmd.CommandType = CommandType.Text;

                OleDbDataReader reader = cmd.ExecuteReader();

                DataTable tipoFianzas = new DataTable();
                tipoFianzas.Load(reader);

                return tipoFianzas;
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

        public DataTable ObtenerInfoTablaOficios()
        {
            Conexion_BDD conexion = new Conexion_BDD();
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "SELECT Id, NroOficio, [Fecha de Oficio], Fecha_Vence, tf.DesTipFian AS TipoDeFianza, c.Nombre_Consignatario " +
                                  "FROM ((Oficios AS o LEFT JOIN [Tipo de Fianzas] AS tf ON (o.Cod_Tipo = tf.Cod_Tf)) " +
                                  "LEFT JOIN Consignatarios AS c ON (o.Rif = c.Rif_Consignatario)) " +
                                  "ORDER BY Id";
                cmd.CommandType = CommandType.Text;

                OleDbDataReader reader = cmd.ExecuteReader();

                DataTable oficios = new DataTable();
                oficios.Columns.Add("Id");
                oficios.Columns.Add("NroOficio");
                oficios.Columns.Add("Fecha de Oficio");
                oficios.Columns.Add("Fecha_Vence");
                oficios.Columns.Add("TipoDeFianza");
                oficios.Columns.Add("Nombre_Consignatario");

                DataRow of = null;
                while (reader.Read())
                {
                    of = oficios.NewRow();
                    of["Id"] = Convert.ToInt32(reader["Id"].ToString());
                    of["NroOficio"] = reader["NroOficio"].ToString();
                    of["Fecha de Oficio"] = reader["Fecha de Oficio"].ToString();


                    string fechaDeOficio = reader["Fecha de Oficio"].ToString();
                    if (fechaDeOficio == string.Empty)
                        of["Fecha de Oficio"] = DateTime.MinValue;
                    else
                        of["Fecha de Oficio"] = DateTime.Parse(fechaDeOficio);


                    string fecha_Vence = reader["Fecha_Vence"].ToString();
                    if (fecha_Vence == string.Empty)
                        of["Fecha_Vence"] = DateTime.MinValue;
                    else
                        of["Fecha_Vence"] = DateTime.Parse(fecha_Vence);


                    of["TipoDeFianza"] = reader["TipoDeFianza"].ToString();
                    of["Nombre_Consignatario"] = reader["Nombre_Consignatario"].ToString();
                    oficios.Rows.Add(of);
                }

                return oficios;
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

        public DataTable ObtenerInfoTablaGerente()
        {
            Conexion_BDD conexion = new Conexion_BDD();
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "SELECT idGerente, Nombre, Cargo, Providencia_Gerente, FechaProvidencia_Gerente, GO_Gerente, FechaGaceta_Gerente, Providencia, [GO], FechaGaceta, Siglas, GerenteActivo FROM Gerente";
                cmd.CommandType = CommandType.Text;

                OleDbDataReader reader = cmd.ExecuteReader();

                DataTable gerentes = new DataTable();
                gerentes.Columns.Add("idGerente");
                gerentes.Columns.Add("Nombre");
                gerentes.Columns.Add("Cargo");
                gerentes.Columns.Add("Providencia_Gerente");
                gerentes.Columns.Add("FechaProvidencia_Gerente");
                gerentes.Columns.Add("GO_Gerente");
                gerentes.Columns.Add("FechaGaceta_Gerente");
                gerentes.Columns.Add("Providencia");
                gerentes.Columns.Add("GO");
                gerentes.Columns.Add("FechaGaceta");
                gerentes.Columns.Add("Siglas");
                gerentes.Columns.Add("GerenteActivo");

                DataRow ge = null;
                while (reader.Read())
                {
                    ge = gerentes.NewRow();
                    ge["idGerente"] = long.Parse(reader["idGerente"].ToString());
                    ge["Nombre"] = reader["Nombre"].ToString();
                    ge["Cargo"] = reader["Cargo"].ToString();
                    ge["Providencia_Gerente"] = reader["Providencia_Gerente"].ToString();


                    string fecha = reader["FechaProvidencia_Gerente"].ToString();
                    if (fecha == string.Empty)
                        ge["FechaProvidencia_Gerente"] = DateTime.MinValue;
                    else
                        ge["FechaProvidencia_Gerente"] = Convert.ToDateTime(reader["FechaProvidencia_Gerente"].ToString());


                    ge["GO_Gerente"] = reader["GO_Gerente"].ToString();


                    fecha = reader["FechaGaceta_Gerente"].ToString();
                    if (fecha == string.Empty)
                        ge["FechaGaceta_Gerente"] = DateTime.MinValue;
                    else
                        ge["FechaGaceta_Gerente"] = Convert.ToDateTime(reader["FechaGaceta_Gerente"].ToString());


                    ge["Providencia"] = reader["Providencia"].ToString();
                    ge["GO"] = reader["GO"].ToString();


                    fecha = reader["FechaGaceta"].ToString();
                    if (fecha == string.Empty)
                        ge["FechaGaceta"] = DateTime.MinValue;
                    else
                        ge["FechaGaceta"] = Convert.ToDateTime(reader["FechaGaceta"].ToString());


                    ge["Siglas"] = reader["Siglas"].ToString();
                    ge["GerenteActivo"] = reader["GerenteActivo"].ToString();

                    gerentes.Rows.Add(ge);
                }

                return gerentes;
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

        public DataTable ObtenerInfoTablaMotivos()
        {
            Conexion_BDD conexion = new Conexion_BDD();
            OleDbCommand cmd = new OleDbCommand();
            try
            {
                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = "SELECT * FROM Motivos";
                cmd.CommandType = CommandType.Text;

                OleDbDataReader reader = cmd.ExecuteReader();

                DataTable motivos = new DataTable();
                motivos.Load(reader);
                
                return motivos;
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
