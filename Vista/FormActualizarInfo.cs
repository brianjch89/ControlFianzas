using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using Controlador;

namespace Vista
{
    public partial class FormActualizarInfo : Form
    {
        long contConsignatarios = 0, contAgentes = 0, contGarantes = 0, contTipoFianzas = 0, contOficios = 0, contGerentes = 0, contMotivos = 0;

        public ControladorActualizarInfo c_ActualizarInfo = new ControladorActualizarInfo();
        DataTable consignatarios;
        DataTable agentes;
        DataTable garantes;
        DataTable tipoFianzas;
        DataTable oficios;
        DataTable gerentes;
        DataTable motivos;

        DateTime fechaVieja;

        bool estadoConsignatario = false, estadoAgente = false, estadoGarante = false, estadoOperacion = false, estadoOficio = false, estadoGerente = false, estadoML = false;
        FormFianzas f;

        public FormActualizarInfo(FormFianzas ff)
        {
            f = ff;
            InitializeComponent();
        }

        // Para dar sombra a la ventada
        private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lPredeterminados_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPredeterminados_Load(object sender, EventArgs e)
        {
            ListarConsignatarios();
            ListarTipoDeFianza();
            CargarDatos();
        }

        private void ListarConsignatarios()
        {
            cbConsignatarioOficio.DataSource = c_ActualizarInfo.ObtenerInfoTablaConsignatarios();
            cbConsignatarioOficio.DisplayMember = "Nombre_Consignatario";
            cbConsignatarioOficio.ValueMember = "Rif_Consignatario";
        }

        private void ListarTipoDeFianza()
        {
            cbTipoFianzaOficio.DataSource = c_ActualizarInfo.ObtenerInfoTablaTipoFianza();
            cbTipoFianzaOficio.DisplayMember = "DesTipFian";
            cbTipoFianzaOficio.ValueMember = "Cod_Tf";
        }

        private void CargarDatos()
        {
            // INFORMACIÓN CONSIGNATARIOS
            consignatarios = c_ActualizarInfo.ObtenerInfoTablaConsignatarios();
            InformacionConsignatarios();
            // FIN INFORMACIÓN CONSIGNATARIOS


            // INFORMACIÓN AGENTES
            agentes = c_ActualizarInfo.ObtenerInfoTablaAgentes();
            InformacionAgentes();
            // FIN INFMORMACIÓN AGENTES


            // INFORMACIÓN GARANTES
            garantes = c_ActualizarInfo.ObtenerInfoTablaGarantes();
            InformacionGarantes();
            // FIN INFORMACIÓN GARANRES


            // INFORMACIÓN TIPO DE FIANZA
            tipoFianzas = c_ActualizarInfo.ObtenerInfoTablaTipoFianza();
            InformacionTipoFianzas();
            // FIN INFORMACIÓN TIPO DE FIANZA


            // INFORMACIÓN OFICIOS
            oficios = c_ActualizarInfo.ObtenerInfoTablaOficios();
            InformacionOficios();
            // FIN INFORMACIÓN OFICIOS


            // INFORMACIÓN GERENTES
            gerentes = c_ActualizarInfo.ObtenerInfoTablaGerente();
            InformacionGerente();
            // FIN INFORMACIÓN GERENTES


            // INFORMACIÓN MOTIVOS
            motivos = c_ActualizarInfo.ObtenerInfoTablaMotivos();
            InformacionMotivos();
            // FIN INFORMACIÓN MOTIVOS
        }

        public Boolean VerificarCampos()
        {
            if (mtbRifConsignatario.Text.Equals("") || tbNombreConsignatario.Text.Equals(""))
                return true;
            return false;
        }

        public void InformacionConsignatarios()
        {
            DataRow consig = consignatarios.Rows[(int)contConsignatarios];

            mtbRifConsignatario.Text = consig["Rif_Consignatario"].ToString();
            mtbRifConsignatario.Enabled = false;

            tbNombreConsignatario.Text = consig["Nombre_Consignatario"].ToString();
            tbSiglasConsignatario.Text = consig["Siglas"].ToString();
            tbRepresentanteConsignatario.Text = consig["Representante"].ToString();
            tbDireccionConsignatario.Text = consig["Dirección"].ToString();
            tbTelefonoConsignatario.Text = consig["Telefono"].ToString();
            tbEmailConsignatario.Text = consig["email"].ToString();

            lCantidadConsignatarios.Text = (contConsignatarios + 1) + " de " + consignatarios.Rows.Count;
        }


        public void InformacionAgentes()
        {
            DataRow agen = agentes.Rows[(int)contAgentes];

            mtbRifAgente.Text = agen["Rif_Agentes"].ToString();
            mtbRifAgente.Enabled = false;

            tbNombreAgente.Text = agen["Nombre_Agente"].ToString();
            tbSiglasAgente.Text = agen["Siglas_Agente"].ToString();
            tbRepresentanteAgente.Text = agen["Representante"].ToString();
            tbDireccionAgente.Text = agen["Domicilio Fiscal"].ToString();
            tbTelefonoAgente.Text = agen["Telefono"].ToString();

            lCantidadAgentes.Text = (contAgentes + 1) + " de " + agentes.Rows.Count;
        }


        public void InformacionGarantes()
        {
            DataRow garan = garantes.Rows[(int)contGarantes];

            mtbRifGarante.Text = garan["Rif_Garante"].ToString();
            mtbRifGarante.Enabled = false;

            tbNombreGarante.Text = garan["Nombre_Garante"].ToString();
            tbSiglasGarante.Text = garan["Siglas"].ToString();
            tbDireccionGarante.Text = garan["Direccion"].ToString();
            tbTelefonoGarante.Text = garan["Telefono"].ToString();
            tbNumeroGarante.Text = garan["Nro_Aprobacion"].ToString();
            tbOficioGarante.Text = garan["OficioNro"].ToString();

            fechaVieja = DateTime.MinValue;
            if (fechaVieja == Convert.ToDateTime(garan["Fecha_Oficio"].ToString()))
            {
                dtpFechaGarante.Value = DateTime.Today;
                dtpFechaGarante.Format = DateTimePickerFormat.Custom;
                dtpFechaGarante.CustomFormat = " ";
            }
            else
            {
                dtpFechaGarante.Value = Convert.ToDateTime(garan["Fecha_Oficio"].ToString());
                dtpFechaGarante.Format = DateTimePickerFormat.Custom;
                dtpFechaGarante.CustomFormat = "dd/MM/yy";
            }

            lCantidadGarantes.Text = (contGarantes + 1) + " de " + garantes.Rows.Count;
        }


        public void InformacionTipoFianzas()
        {
            DataRow tipoF = tipoFianzas.Rows[(int)contTipoFianzas];

            tbCodigoOperacion.Text = tipoF["Cod_Tf"].ToString();
            tbCodigoOperacion.Enabled = false;

            tbSiglasOperacion.Text = tipoF["DesTipFian"].ToString();
            tbDescripcionOperacion.Text = tipoF["DesTipFianza"].ToString();

            lCantidadOperaciones.Text = (contTipoFianzas + 1) + " de " + tipoFianzas.Rows.Count;
        }


        public void InformacionOficios()
        {
            DataRow ofic = oficios.Rows[(int)contOficios];

            tbOficioOficio.Text = ofic["NroOficio"].ToString();


            if (fechaVieja == Convert.ToDateTime(ofic["Fecha de Oficio"].ToString()))
            {
                dtpFechaEmisionOficio.Value = DateTime.Today;
                dtpFechaEmisionOficio.Format = DateTimePickerFormat.Custom;
                dtpFechaEmisionOficio.CustomFormat = " ";
            }
            else
            {
                dtpFechaEmisionOficio.Value = Convert.ToDateTime(ofic["Fecha de Oficio"].ToString());
                dtpFechaEmisionOficio.Format = DateTimePickerFormat.Short;
            }


            if (fechaVieja == Convert.ToDateTime(ofic["Fecha_Vence"].ToString()))
            {
                dtpFechaVencimientoOficio.Value = DateTime.Today;
                dtpFechaVencimientoOficio.Format = DateTimePickerFormat.Custom;
                dtpFechaVencimientoOficio.CustomFormat = " ";
            }
            else
            {
                dtpFechaVencimientoOficio.Value = Convert.ToDateTime(ofic["Fecha_Vence"].ToString());
                dtpFechaVencimientoOficio.Format = DateTimePickerFormat.Short;
            }


            cbConsignatarioOficio.Text = ofic["Nombre_Consignatario"].ToString();
            cbTipoFianzaOficio.Text = ofic["TipoDeFianza"].ToString();

            lCantidadOficios.Text = (contOficios + 1) + " de " + oficios.Rows.Count;
        }

        public void InformacionGerente()
        {
            DataRow geren = gerentes.Rows[(int)contGerentes];

            tbNombreGerente.Text = geren["Nombre"].ToString();
            tbCargoGerente.Text = geren["Cargo"].ToString();
            tbProvidenciaGerente.Text = geren["Providencia_Gerente"].ToString();

            // Oficio
            if (fechaVieja == Convert.ToDateTime(geren["FechaProvidencia_Gerente"].ToString()))
            {
                dtpFechaProvidenciaGerente.Value = DateTime.Today;
                dtpFechaProvidenciaGerente.Format = DateTimePickerFormat.Custom;
                dtpFechaProvidenciaGerente.CustomFormat = " ";
            }
            else
            {
                dtpFechaProvidenciaGerente.Value = Convert.ToDateTime(geren["FechaProvidencia_Gerente"].ToString());
                dtpFechaProvidenciaGerente.Format = DateTimePickerFormat.Short;
            }

            // Fecha Gaceta
            if (fechaVieja == Convert.ToDateTime(geren["FechaGaceta_Gerente"].ToString()))
            {
                dtpFechaGacetaGerente.Value = DateTime.Today;
                dtpFechaGacetaGerente.Format = DateTimePickerFormat.Custom;
                dtpFechaGacetaGerente.CustomFormat = " ";
            }
            else
            {
                dtpFechaGacetaGerente.Value = Convert.ToDateTime(geren["FechaGaceta_Gerente"].ToString());
                dtpFechaGacetaGerente.Format = DateTimePickerFormat.Short;
            }

            tbGacetaOficialGerente.Text = geren["GO_Gerente"].ToString();
            tbProvidencia.Text = geren["Providencia"].ToString();
            tbGacetaOficial.Text = geren["GO"].ToString();

            if (fechaVieja == Convert.ToDateTime(geren["FechaGaceta"].ToString()))
            {
                dtpFechaGaceta.Value = DateTime.Today;
                dtpFechaGaceta.Format = DateTimePickerFormat.Custom;
                dtpFechaGaceta.CustomFormat = " ";
            }
            else
            {
                dtpFechaGaceta.Value = Convert.ToDateTime(geren["FechaGaceta"].ToString());
                dtpFechaGaceta.Format = DateTimePickerFormat.Short;
            }

            tbSiglas_Gerente.Text = geren["Siglas"].ToString();
            chbGerenteActivo.Checked = Convert.ToBoolean(geren["GerenteActivo"].ToString());

            lCantidadGerentes.Text = (contGerentes + 1) + " de " + gerentes.Rows.Count;
        }


        public void InformacionMotivos()
        {
            DataRow moti = motivos.Rows[(int)contMotivos];

            tbCodigoLiberacionML.Text = moti["Cod_Lib"].ToString();
            tbCodigoLiberacionML.Enabled = false;

            tbDescripcionML.Text = moti["Descripcion"].ToString();

            lCantidadMotivos.Text = (contMotivos + 1) + " de " + motivos.Rows.Count;
        }


        // BOTONES CONSIGNATARIOS
        private void btnNuevoConsignatario_Click(object sender, EventArgs e)
        {
            mtbRifConsignatario.Enabled = true;
            mtbRifConsignatario.Focus();
            estadoConsignatario = true;
            VaciarCamposConsignatario();
            lCantidadConsignatarios.Text = (consignatarios.Rows.Count + 1) + " de " + (consignatarios.Rows.Count + 1);
        }

        private void VaciarCamposConsignatario()
        {
            mtbRifConsignatario.Text = string.Empty;
            tbNombreConsignatario.Text = string.Empty;
            tbSiglasConsignatario.Text = string.Empty;
            tbRepresentanteConsignatario.Text = string.Empty;
            tbDireccionConsignatario.Text = string.Empty;
            tbTelefonoConsignatario.Text = string.Empty;
            tbEmailConsignatario.Text = string.Empty;
        }

        private void btnBuscarConsignatario_Click(object sender, EventArgs e)
        {
            FormBuscarPredeterminado fbp = new FormBuscarPredeterminado("Ingrese o seleccione el RIF del Consignatario", 1);
            fbp.setListado(consignatarios);
            fbp.ShowDialog();
            //DataTable dt = fbp.dt;

            if (fbp.ban)
            {
                estadoConsignatario = false;
                if (fbp.fi != null) // dt.Rows.Count > 0
                {
                    DataRow consig = fbp.fi;

                    mtbRifConsignatario.Text = consig["Rif_Consignatario"].ToString();
                    mtbRifConsignatario.Enabled = false;

                    tbNombreConsignatario.Text = consig["Nombre_Consignatario"].ToString();
                    tbSiglasConsignatario.Text = consig["Siglas"].ToString();
                    tbRepresentanteConsignatario.Text = consig["Representante"].ToString();
                    tbDireccionConsignatario.Text = consig["Dirección"].ToString();
                    tbTelefonoConsignatario.Text = consig["Telefono"].ToString();
                    tbEmailConsignatario.Text = consig["email"].ToString();

                    int i = 0;
                    foreach (DataRow consignatario in consignatarios.Rows)
                    {
                        if (consignatario["Rif_Consignatario"].ToString().Equals(consig["Rif_Consignatario"].ToString()))
                            break;
                        i++;
                    }
                    contConsignatarios = i;

                    lCantidadConsignatarios.Text = (contConsignatarios + 1) + " de " + consignatarios.Rows.Count;
                }
            }
        }

        private void btnPrimeroConsignatario_Click(object sender, EventArgs e)
        {
            estadoConsignatario = false;
            contConsignatarios = 0;
            InformacionConsignatarios();
        }

        private void btnUltimoConsignatario_Click(object sender, EventArgs e)
        {
            estadoConsignatario = false;
            contConsignatarios = consignatarios.Rows.Count - 1;
            InformacionConsignatarios();
        }

        private void btnAnteriorConsignatario_Click(object sender, EventArgs e)
        {
            if (!estadoConsignatario)
                if (contConsignatarios > 0)
                {
                    contConsignatarios--;
                    InformacionConsignatarios();
                }
        }

        private void btnSiguienteConsignatario_Click(object sender, EventArgs e)
        {
            if (!estadoConsignatario)
                if (contConsignatarios < (consignatarios.Rows.Count - 1))
                {
                    contConsignatarios++;
                    InformacionConsignatarios();
                }
        }

        private void btnGuardarConsignatario_Click(object sender, EventArgs e)
        {
            string query;
            string rif_consignatario = mtbRifConsignatario.Text.Replace("-", "");
            if (estadoConsignatario) // Ingresar Consignatario
                if (LlenoConsignatario())
                {
                    // Primero verifico si el consignatario existe en la base de datos
                    DataTable dt = c_ActualizarInfo.BuscarPredeterminado("SELECT Rif_Consignatario, Nombre_Consignatario, Siglas, Representante, Dirección, Telefono, email FROM Consignatarios WHERE Rif_Consignatario = '" + rif_consignatario + "'", 1);
                    if (dt.Rows.Count == 0)
                    {
                        query = "INSERT INTO Consignatarios(Rif_Consignatario, Nombre_Consignatario, Dirección, Telefono, Siglas, Representante, email) " +
                                "VALUES('" + rif_consignatario + "', '" + tbNombreConsignatario.Text + "', '" + tbDireccionConsignatario.Text + "', '" + tbTelefonoConsignatario.Text + "', " +
                                "'" + tbSiglasConsignatario.Text + "', '" + tbRepresentanteConsignatario.Text + "', '" + tbEmailConsignatario.Text + "')";

                        if (c_ActualizarInfo.GestionarPredeterminados(query) > 0)
                        {
                            estadoConsignatario = false;
                            consignatarios = c_ActualizarInfo.ObtenerInfoTablaConsignatarios();
                            contConsignatarios = consignatarios.Rows.Count - 1;
                            f.ListarContribuyente(1);
                            ListarConsignatarios();
                            new FormAviso("Se ha ingresado el Consignatario.", 310, 106).ShowDialog();
                            mtbRifConsignatario.Enabled = false;
                        }
                    }
                    else
                        new FormAviso("No se agregó la información debido a que ya existe el Rif del Consignatario y la información asociada al mismo.", 885, 393).ShowDialog();
                }
                else
                {
                    new FormAviso("Debe ingresar el RIF y el Nombre del Consignatario.", 435, 169).ShowDialog();
                    mtbRifConsignatario.Focus();
                }
            else // Actualizar Consignatario
                if (LlenoConsignatario())
                {
                    query = "UPDATE Consignatarios SET Nombre_Consignatario = '" + tbNombreConsignatario.Text + "', " +
                            "Siglas = '" + tbSiglasConsignatario.Text + "', Representante = '" + tbRepresentanteConsignatario.Text + "', Dirección = '" + tbDireccionConsignatario.Text + "', " +
                            "Telefono = '" + tbTelefonoConsignatario.Text + "', email = '" + tbEmailConsignatario.Text + "' WHERE Rif_Consignatario = '" + rif_consignatario + "'";

                    if (c_ActualizarInfo.GestionarPredeterminados(query) > 0)
                    {
                        consignatarios = c_ActualizarInfo.ObtenerInfoTablaConsignatarios();
                        f.ListarContribuyente(2);
                        ListarConsignatarios();
                        new FormAviso("Se ha actualizado el Consignatario.", 321, 112).ShowDialog();
                    }
                }
                else
                {
                    new FormAviso("Debe ingresar el Nombre del Consignatario.", 380, 148).ShowDialog();
                    mtbRifConsignatario.Focus();
                }
        }

        private bool LlenoConsignatario()
        {
            if (mtbRifConsignatario.Text.Equals(" -        -") || tbNombreConsignatario.Text.Equals(string.Empty))
                return false;
            return true;
        }

        private void btnRegresarConsignatario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // FIN BOTONES CONSIGNATARIOS


        // BOTONES AGENTES
        private void btnNuevoAgente_Click(object sender, EventArgs e)
        {
            mtbRifAgente.Enabled = true;
            mtbRifAgente.Focus();
            estadoAgente = true;
            VaciarCamposAgente();
            lCantidadAgentes.Text = (agentes.Rows.Count + 1) + " de " + (agentes.Rows.Count + 1);
        }

        private void VaciarCamposAgente()
        {
            mtbRifAgente.Text = string.Empty;
            tbNombreAgente.Text = string.Empty;
            tbSiglasAgente.Text = string.Empty;
            tbRepresentanteAgente.Text = string.Empty;
            tbDireccionAgente.Text = string.Empty;
            tbTelefonoAgente.Text = string.Empty;
        }

        private void btnBuscarAgente_Click(object sender, EventArgs e)
        {
            FormBuscarPredeterminado fbp = new FormBuscarPredeterminado("Ingrese o seleccione el RIF del Agente", 2);
            fbp.setListado(agentes);
            fbp.ShowDialog();
            //DataTable dt = fbp.dt;

            if (fbp.ban)
            {
                estadoAgente = false;
                if (fbp.fi != null) // dt.Rows.Count > 0
                {
                    DataRow agen = fbp.fi;

                    mtbRifAgente.Text = agen["Rif_Agentes"].ToString();
                    mtbRifAgente.Enabled = false;

                    tbNombreAgente.Text = agen["Nombre_Agente"].ToString();
                    tbSiglasAgente.Text = agen["Siglas_Agente"].ToString();
                    tbRepresentanteAgente.Text = agen["Representante"].ToString();
                    tbDireccionAgente.Text = agen["Domicilio Fiscal"].ToString();
                    tbTelefonoAgente.Text = agen["Telefono"].ToString();

                    int i = 0;
                    foreach (DataRow agente in agentes.Rows)
                    {
                        if (agente["Rif_Agentes"].ToString().Equals(agen["Rif_Agentes"].ToString()))
                            break;
                        i++;
                    }
                    contAgentes = i;

                    lCantidadAgentes.Text = (contAgentes + 1) + " de " + agentes.Rows.Count;
                }
            }
        }

        private void btnPrimerAgente_Click(object sender, EventArgs e)
        {
            estadoAgente = false;
            contAgentes = 0;
            InformacionAgentes();
        }

        private void btnUltimoAgente_Click(object sender, EventArgs e)
        {
            estadoAgente = false;
            contAgentes = agentes.Rows.Count - 1;
            InformacionAgentes();
        }

        private void btnAnteriorAgente_Click(object sender, EventArgs e)
        {
            if (!estadoAgente)
                if (contAgentes > 0)
                {
                    contAgentes--;
                    InformacionAgentes();
                }
        }

        private void btnSiguienteAgentes_Click(object sender, EventArgs e)
        {
            if (!estadoAgente)
                if (contAgentes < (agentes.Rows.Count - 1))
                {
                    contAgentes++;
                    InformacionAgentes();
                }
        }

        private void btnGuardarAgente_Click(object sender, EventArgs e)
        {
            string query;
            string rif_agente = mtbRifAgente.Text.Replace("-", "");
            if (estadoAgente)
                if (LlenoAgente())
                {
                    // Primero verifico si el agente existe en la base de datos
                    DataTable dt = c_ActualizarInfo.BuscarPredeterminado("SELECT Rif_Agentes, Nombre_Agente, Siglas_Agente, Representante, [Domicilio Fiscal], Telefono FROM Agentes WHERE Rif_Agentes = '" + rif_agente + "'", 2);
                    if (dt.Rows.Count == 0)
                    {
                        query = "INSERT INTO Agentes(Rif_Agentes, Nombre_Agente, Siglas_Agente, Representante, Telefono, [Domicilio Fiscal]) " +
                                "VALUES('" + rif_agente + "', '" + tbNombreAgente.Text + "', '" + tbSiglasAgente.Text + "', '" + tbRepresentanteAgente.Text + "', " +
                                "'" + tbTelefonoAgente.Text + "', '" + tbDireccionAgente.Text + "')";

                        if (c_ActualizarInfo.GestionarPredeterminados(query) > 0)
                        {
                            estadoAgente = false;
                            agentes = c_ActualizarInfo.ObtenerInfoTablaAgentes();
                            contAgentes = agentes.Rows.Count - 1;
                            f.ListarAgentes(1);
                            new FormAviso("Se ha ingresado el Agente.", 258, 80).ShowDialog();
                            mtbRifAgente.Enabled = false;
                        }
                    }
                    else
                        new FormAviso("No se agregó la información debido a que ya existe el Rif del Agente y la información asociada al mismo.", 835, 368).ShowDialog();
                }
                else
                {
                    new FormAviso("Debe ingresar el RIF y el Nombre del Agente.", 365, 144).ShowDialog();
                    mtbRifAgente.Focus();
                }
            else
                if (LlenoAgente())
                {
                    query = "UPDATE Agentes SET Nombre_Agente = '" + tbNombreAgente.Text + "', " +
                            "Siglas_Agente = '" + tbSiglasAgente.Text + "', Representante = '" + tbRepresentanteAgente.Text + "', [Domicilio Fiscal] = '" + tbDireccionAgente.Text + "', " +
                            "Telefono = '" + tbTelefonoAgente.Text + "' WHERE Rif_Agentes = '" + rif_agente + "'";

                    if (c_ActualizarInfo.GestionarPredeterminados(query) > 0)
                    {
                        agentes = c_ActualizarInfo.ObtenerInfoTablaAgentes();
                        f.ListarAgentes(2);
                        new FormAviso("Se ha actualizado el Agente.", 275, 89).ShowDialog();
                    }
                }
                else
                {
                    new FormAviso("Debe ingresar el Nombre del Agente.", 330, 121).ShowDialog();
                    mtbRifAgente.Focus();
                }
        }

        private bool LlenoAgente()
        {
            if (mtbRifAgente.Text.Equals(" -        -") || tbNombreAgente.Text.Equals(string.Empty))
                return false;
            return true;
        }

        private void btnRegresarAgente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // FIN BOTONES AGENTES


        // BOTONES GARANTES
        private void btnNuevoGarante_Click(object sender, EventArgs e)
        {
            mtbRifGarante.Enabled = true;
            mtbRifGarante.Focus();
            estadoGarante = true;
            VaciarCamposGarante();
            lCantidadGarantes.Text = (garantes.Rows.Count + 1) + " de " + (garantes.Rows.Count + 1);
        }

        private void VaciarCamposGarante()
        {
            mtbRifGarante.Text = string.Empty;
            tbNombreGarante.Text = string.Empty;
            tbSiglasGarante.Text = string.Empty;
            tbDireccionGarante.Text = string.Empty;
            tbTelefonoGarante.Text = string.Empty;
            tbNumeroGarante.Text = string.Empty;
            tbOficioGarante.Text = string.Empty;

            dtpFechaGarante.Value = DateTime.Today;
            dtpFechaGarante.Format = DateTimePickerFormat.Custom;
            dtpFechaGarante.CustomFormat = " ";
        }

        private void btnBuscarGarante_Click(object sender, EventArgs e)
        {
            FormBuscarPredeterminado fbp = new FormBuscarPredeterminado("Ingrese o seleccione el RIF del Garante", 3);
            fbp.setListado(garantes);
            fbp.ShowDialog();
            //DataTable dt = fbp.dt;

            if (fbp.ban)
            {
                estadoGarante = false;
                if (fbp.fi != null) // dt.Rows.Count > 0
                {
                    DataRow garan = fbp.fi;

                    mtbRifGarante.Text = garan["Rif_Garante"].ToString();
                    mtbRifGarante.Enabled = false;

                    tbNombreGarante.Text = garan["Nombre_Garante"].ToString();
                    tbSiglasGarante.Text = garan["Siglas"].ToString();
                    tbDireccionGarante.Text = garan["Direccion"].ToString();
                    tbTelefonoGarante.Text = garan["Telefono"].ToString();
                    tbNumeroGarante.Text = garan["Nro_Aprobacion"].ToString();
                    tbOficioGarante.Text = garan["OficioNro"].ToString();

                    fechaVieja = DateTime.MinValue;
                    if (fechaVieja == Convert.ToDateTime(garan["Fecha_Oficio"].ToString()))
                    {
                        dtpFechaGarante.Value = DateTime.Today;
                        dtpFechaGarante.Format = DateTimePickerFormat.Custom;
                        dtpFechaGarante.CustomFormat = " ";
                    }
                    else
                    {
                        dtpFechaGarante.Value = Convert.ToDateTime(garan["Fecha_Oficio"].ToString());
                        dtpFechaGarante.Format = DateTimePickerFormat.Custom;
                        dtpFechaGarante.CustomFormat = "dd/MM/yy";
                    }

                    int i = 0;
                    foreach (DataRow garante in garantes.Rows)
                    {
                        if (garante["Rif_Garante"].ToString().Equals(garan["Rif_Garante"].ToString()))
                            break;
                        i++;
                    }
                    contGarantes = i;

                    lCantidadGarantes.Text = (contGarantes + 1) + " de " + garantes.Rows.Count;
                }
            }
        }

        private void btnPrimerGarante_Click(object sender, EventArgs e)
        {
            estadoGarante = false;
            contGarantes = 0;
            InformacionGarantes();
        }

        private void btnUltimoGarante_Click(object sender, EventArgs e)
        {
            estadoGarante = false;
            contGarantes = garantes.Rows.Count - 1;
            InformacionGarantes();
        }

        private void btnAnteriorGarante_Click(object sender, EventArgs e)
        {
            if (!estadoGarante)
                if (contGarantes > 0)
                {
                    contGarantes--;
                    InformacionGarantes();
                }
        }

        private void btnSiguienteGarante_Click(object sender, EventArgs e)
        {
            if (!estadoGarante)
                if (contGarantes < (garantes.Rows.Count - 1))
                {
                    contGarantes++;
                    InformacionGarantes();
                }
        }

        private void btnGuardarGarante_Click(object sender, EventArgs e)
        {
            string query;
            string rif_garante = mtbRifGarante.Text.Replace("-", "");
            if (estadoGarante)
                if (LlenoGarante())
                {
                    // Primero verifico si el agente existe en la base de datos
                    DataTable dt = c_ActualizarInfo.BuscarPredeterminado("SELECT Rif_Garante, Nombre_Garante, Siglas, Direccion, Telefono, Nro_Aprobacion, OficioNro, Fecha_Oficio FROM Garantes WHERE Rif_Garante = '" + rif_garante + "'", 3);
                    if (dt.Rows.Count == 0)
                    {
                        if (dtpFechaGarante.CustomFormat == "dd/MM/yy")
                        {
                            query = "INSERT INTO Garantes(Rif_Garante, Nombre_Garante, Direccion, Telefono, Siglas, Nro_Aprobacion, OficioNro, Fecha_Oficio) " +
                                    "VALUES('" + rif_garante + "', '" + tbNombreGarante.Text + "', '" + tbDireccionGarante.Text + "', '" + tbTelefonoAgente.Text + "', '" + tbSiglasGarante.Text + "', " +
                                    "'" + tbNumeroGarante.Text + "', '" + tbOficioGarante.Text + "', '" + dtpFechaGarante.Value.Date + "')";
                        }
                        else // No se considera la fecha si el DateTimePicker está en blanco. Por ende, el campo "Fecha_Oficio"
                        {
                            query = "INSERT INTO Garantes(Rif_Garante, Nombre_Garante, Direccion, Telefono, Siglas, Nro_Aprobacion, OficioNro, Fecha_Oficio) " +
                                    "VALUES('" + rif_garante + "', '" + tbNombreGarante.Text + "', '" + tbDireccionGarante.Text + "', '" + tbTelefonoAgente.Text + "', '" + tbSiglasGarante.Text + "', " +
                                    "'" + tbNumeroGarante.Text + "', '" + tbOficioGarante.Text + "', NULL)";
                        }

                        if (c_ActualizarInfo.GestionarPredeterminados(query) > 0)
                        {
                            estadoGarante = false;
                            garantes = c_ActualizarInfo.ObtenerInfoTablaGarantes();
                            contGarantes = garantes.Rows.Count - 1;
                            f.ListarGarantes(1);
                            new FormAviso("Se ha ingresado el Garante.", 270, 86).ShowDialog();
                            mtbRifGarante.Enabled = false;
                        }
                    }
                    else
                        new FormAviso("No se agregó la información debido a que ya existe el Rif del Garante y la información asociada al mismo.", 845, 374).ShowDialog();

                }
                else
                {
                    new FormAviso("Debe ingresar el RIF y el Nombre del Garante. ", 390, 146).ShowDialog();
                    mtbRifGarante.Focus();
                }
            else
                if (LlenoGarante())
                {
                    if (dtpFechaGarante.CustomFormat == "dd/MM/yy")
                    {
                        query = "UPDATE Garantes SET Nombre_Garante = '" + tbNombreGarante.Text + "', " +
                                "Siglas = '" + tbSiglasGarante.Text + "', Direccion = '" + tbDireccionGarante.Text + "', " +
                                "Telefono = '" + tbTelefonoAgente.Text + "', Nro_Aprobacion = '" + tbNumeroGarante.Text + "', " +
                                "OficioNro = '" + tbOficioGarante.Text + "', Fecha_Oficio = '" + dtpFechaGarante.Value.Date + "' WHERE Rif_Garante = '" + rif_garante + "'";
                    }
                    else // No se considera la fecha si el DateTimePicker está en blanco. Por ende, el campo "Fecha_Oficio"
                    {
                        query = "UPDATE Garantes SET Nombre_Garante = '" + tbNombreGarante.Text + "', " +
                                "Siglas = '" + tbSiglasGarante.Text + "', Direccion = '" + tbDireccionGarante.Text + "', " +
                                "Telefono = '" + tbTelefonoAgente.Text + "', Nro_Aprobacion = '" + tbNumeroGarante.Text + "', " +
                                "OficioNro = '" + tbOficioGarante.Text + "', Fecha_Oficio = NULL WHERE Rif_Garante = '" + rif_garante + "'";
                    }

                    if (c_ActualizarInfo.GestionarPredeterminados(query) > 0)
                    {
                        garantes = c_ActualizarInfo.ObtenerInfoTablaGarantes();
                        f.ListarGarantes(2);
                        new FormAviso("Se ha actualizado el Garante.", 281, 92).ShowDialog();
                    }
                }
                else
                {
                    new FormAviso("Debe ingresar el Nombre del Garante.", 337, 126).ShowDialog();
                    mtbRifGarante.Focus();
                }
        }

        private bool LlenoGarante()
        {
            if (mtbRifGarante.Text.Equals(" -        -") || tbNombreGarante.Text.Equals(string.Empty))
                return false;
            return true;
        }

        private void btnRegresarGarante_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Este método se dispara cuando se seleciona una fecha
        private void dtpFechaGarante_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaGarante.Format = DateTimePickerFormat.Custom;
            dtpFechaGarante.CustomFormat = "dd/MM/yy";
        }

        // Si presiona el click derecho, el campo de la fecha se vacia
        private void dtpFechaGarante_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dtpFechaGarante.Value = DateTime.Today;
                dtpFechaGarante.Format = DateTimePickerFormat.Custom;
                dtpFechaGarante.CustomFormat = " ";
            }
        }
        // FIN BOTONES GARANTES


        // BOTONES NATURALEZA DE LA OPERACION
        private void btnNuevaOperacion_Click(object sender, EventArgs e)
        {
            tbCodigoOperacion.Enabled = true;
            tbSiglasOperacion.Focus();
            estadoOperacion = true;
            VaciarCamposTipoDeFianza();
            lCantidadOperaciones.Text = (tipoFianzas.Rows.Count + 1) + " de " + (tipoFianzas.Rows.Count + 1);
            tbCodigoOperacion.Text = Convert.ToString(Convert.ToInt32(tipoFianzas.Rows[tipoFianzas.Rows.Count - 1]["Cod_Tf"].ToString()) + 1);
        }

        private void VaciarCamposTipoDeFianza()
        {
            tbCodigoOperacion.Text = string.Empty;
            tbSiglasOperacion.Text = string.Empty;
            tbDescripcionOperacion.Text = string.Empty;
        }

        private void btnBuscarOperacion_Click(object sender, EventArgs e)
        {
            FormBuscarPredeterminado fbp = new FormBuscarPredeterminado("Ingrese o seleccione la Operación", 4);
            fbp.setListado(tipoFianzas);
            fbp.ShowDialog();
            //DataTable dt = fbp.dt;

            if (fbp.ban)
            {
                estadoOperacion = false;
                if (fbp.fi != null) // dt.Rows.Count > 0
                {
                    DataRow opera = fbp.fi;

                    tbCodigoOperacion.Text = opera["Cod_Tf"].ToString();
                    tbCodigoOperacion.Enabled = false;

                    tbSiglasOperacion.Text = opera["DesTipFian"].ToString();
                    tbDescripcionOperacion.Text = opera["DesTipFianza"].ToString();

                    int i = 0;
                    foreach (DataRow operacion in tipoFianzas.Rows)
                    {
                        if (operacion["Cod_Tf"].ToString().Equals(opera["Cod_Tf"].ToString()))
                            break;
                        i++;
                    }
                    contTipoFianzas = i;

                    lCantidadOperaciones.Text = (contTipoFianzas + 1) + " de " + tipoFianzas.Rows.Count;
                }
            }
        }

        private void btnPrimeraOperacion_Click(object sender, EventArgs e)
        {
            estadoOperacion = false;
            contTipoFianzas = 0;
            InformacionTipoFianzas();
        }

        private void btnUltimaOperacion_Click(object sender, EventArgs e)
        {
            estadoOperacion = false;
            contTipoFianzas = tipoFianzas.Rows.Count - 1;
            InformacionTipoFianzas();
        }

        private void btnAnteriorOperacion_Click(object sender, EventArgs e)
        {
            if (!estadoOperacion)
                if (contTipoFianzas > 0)
                {
                    contTipoFianzas--;
                    InformacionTipoFianzas();
                }
        }

        private void btnSiguienteOperacion_Click(object sender, EventArgs e)
        {
            if (!estadoOperacion)
                if (contTipoFianzas < (tipoFianzas.Rows.Count - 1))
                {
                    contTipoFianzas++;
                    InformacionTipoFianzas();
                }
        }

        private void btnGuardarOperacion_Click(object sender, EventArgs e)
        {
            string query;
            if (estadoOperacion)
                if (LlenoNaturaleza())
                {
                    // Primero verifico si el tipo de fianza existe en la base de datos
                    DataTable dt = c_ActualizarInfo.BuscarPredeterminado("SELECT * FROM [Tipo de Fianzas] WHERE DesTipFianza = '" + tbDescripcionOperacion.Text + "'", 4);
                    if (dt.Rows.Count == 0)
                    {
                        query = "INSERT INTO [Tipo de Fianzas](Cod_Tf, DesTipFian, DesTipFianza) " +
                                "VALUES(" + Convert.ToByte(tbCodigoOperacion.Text) + ", '" + tbSiglasOperacion.Text + "', '" + tbDescripcionOperacion.Text + "')";

                        if (c_ActualizarInfo.GestionarPredeterminados(query) > 0)
                        {
                            estadoOperacion = false;
                            tipoFianzas = c_ActualizarInfo.ObtenerInfoTablaTipoFianza();
                            contTipoFianzas = tipoFianzas.Rows.Count - 1;
                            f.ListarTipoDeFianza(1);
                            ListarTipoDeFianza();
                            new FormAviso("Se ha ingresado el Tipo de Fianza.", 309, 106).ShowDialog();
                            tbCodigoOperacion.Enabled = false;
                        }
                    }
                    else
                        new FormAviso("No se agregó la información debido a que ya existe el Tipo de Fianza y la información asociada al mismo.", 840, 371).ShowDialog();
                }
                else
                {
                    new FormAviso("Llene todos los campos. ", 230, 67).ShowDialog();
                    tbSiglasOperacion.Focus();
                }
            else
                if (LlenoNaturaleza())
                {
                    query = "UPDATE [Tipo de Fianzas] SET Cod_Tf = " + Convert.ToInt32(tbCodigoOperacion.Text) + ", DesTipFian = '" + tbSiglasOperacion.Text + "', " +
                            "DesTipFianza = '" + tbDescripcionOperacion.Text + "' WHERE Cod_Tf = " + Convert.ToInt32(tbCodigoOperacion.Text);

                    if (c_ActualizarInfo.GestionarPredeterminados(query) > 0)
                    {
                        tipoFianzas = c_ActualizarInfo.ObtenerInfoTablaTipoFianza();
                        f.ListarTipoDeFianza(2);
                        ListarTipoDeFianza();
                        new FormAviso("Se ha actualizado el Tipo de Fianza.", 323, 113).ShowDialog();
                    }
                }
                else
                {
                    new FormAviso("Llene todos los campos. ", 230, 67).ShowDialog();
                    tbSiglasOperacion.Focus();
                }
        }

        private bool LlenoNaturaleza()
        {
            if (tbCodigoOperacion.Text.Equals(string.Empty) || tbSiglasOperacion.Text.Equals(string.Empty) || tbDescripcionOperacion.Text.Equals(string.Empty))
                return false;
            return true;
        }

        private void btnRegresarOperacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbCodigoOperacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = true;
        }
        // FIN BOTONES NATURALEZA DE LA OPERACION


        // BOTONES OFICIO
        private void btnNuevoOficio_Click(object sender, EventArgs e)
        {
            tbOficioOficio.Focus();
            estadoOficio = true;
            VaciarCamposOficio();
            lCantidadOficios.Text = (oficios.Rows.Count + 1) + " de " + (oficios.Rows.Count + 1);
        }

        private void VaciarCamposOficio()
        {
            tbOficioOficio.Text = string.Empty;

            dtpFechaEmisionOficio.Value = DateTime.Today;
            dtpFechaEmisionOficio.Format = DateTimePickerFormat.Custom;
            dtpFechaEmisionOficio.CustomFormat = " ";

            dtpFechaVencimientoOficio.Value = DateTime.Today;
            dtpFechaVencimientoOficio.Format = DateTimePickerFormat.Custom;
            dtpFechaVencimientoOficio.CustomFormat = " ";

            cbConsignatarioOficio.Text = string.Empty;
            cbTipoFianzaOficio.Text = string.Empty;
        }

        private void btnBuscarOficio_Click(object sender, EventArgs e)
        {
            FormBuscarPredeterminado fbp = new FormBuscarPredeterminado("Ingrese o seleccione el Oficio", 5);
            fbp.setListado(oficios);
            fbp.ShowDialog();
            //DataTable dt = fbp.dt;

            if (fbp.ban)
            {
                estadoOficio = false;
                if (fbp.fi != null) // dt.Rows.Count > 0
                {
                    DataRow ofic = fbp.fi;

                    tbOficioOficio.Text = ofic["NroOficio"].ToString();


                    fechaVieja = DateTime.MinValue;
                    if (fechaVieja == Convert.ToDateTime(ofic["Fecha de Oficio"].ToString()))
                    {
                        dtpFechaEmisionOficio.Value = DateTime.Today;
                        dtpFechaEmisionOficio.Format = DateTimePickerFormat.Custom;
                        dtpFechaEmisionOficio.CustomFormat = " ";
                    }
                    else
                    {
                        dtpFechaEmisionOficio.Format = DateTimePickerFormat.Short;
                        dtpFechaEmisionOficio.Value = Convert.ToDateTime(ofic["Fecha de Oficio"].ToString());
                    }


                    if (fechaVieja == Convert.ToDateTime(ofic["Fecha_Vence"].ToString()))
                    {
                        dtpFechaVencimientoOficio.Value = DateTime.Today;
                        dtpFechaVencimientoOficio.Format = DateTimePickerFormat.Custom;
                        dtpFechaVencimientoOficio.CustomFormat = " ";
                    }
                    else
                    {
                        dtpFechaVencimientoOficio.Format = DateTimePickerFormat.Short;
                        dtpFechaVencimientoOficio.Value = Convert.ToDateTime(ofic["Fecha_Vence"].ToString());
                    }


                    cbConsignatarioOficio.Text = ofic["Nombre_Consignatario"].ToString();
                    cbTipoFianzaOficio.Text = ofic["TipoDeFianza"].ToString();

                    int i = 0;
                    foreach (DataRow oficio in oficios.Rows)
                    {
                        if (oficio["NroOficio"].ToString().Equals(ofic["NroOficio"].ToString()))
                            break;
                        i++;
                    }
                    contOficios = i;

                    lCantidadOficios.Text = (contOficios + 1) + " de " + oficios.Rows.Count;
                }
            }
        }

        private void btnPrimerOficio_Click(object sender, EventArgs e)
        {
            ColorOriginalEtiquetasOficio();
            estadoOficio = false;
            contOficios = 0;
            InformacionOficios();
        }

        private void btnUltimoOficio_Click(object sender, EventArgs e)
        {
            ColorOriginalEtiquetasOficio();
            estadoOficio = false;
            contOficios = oficios.Rows.Count - 1;
            InformacionOficios();
        }

        private void btnAnteriorOficio_Click(object sender, EventArgs e)
        {
            ColorOriginalEtiquetasOficio();
            if (!estadoOficio)
                if (contOficios > 0)
                {
                    contOficios--;
                    InformacionOficios();
                }
        }

        private void btnSiguienteOficio_Click(object sender, EventArgs e)
        {
            ColorOriginalEtiquetasOficio();
            if (!estadoOficio)
                if (contOficios < (oficios.Rows.Count - 1))
                {
                    contOficios++;
                    InformacionOficios();
                }
        }

        private void btnGuardarOficio_Click(object sender, EventArgs e)
        {
            string query;
            if (estadoOficio)
                if (LlenoOficio())
                {
                    // Primero verifico si el oficio existe en la base de datos
                    DataTable dt = c_ActualizarInfo.BuscarPredeterminado("SELECT NroOficio, [Fecha de Oficio], Fecha_Vence, tf.DesTipFian AS TipoDeFianza, c.Nombre_Consignatario " +
                                                                         "FROM ((Oficios AS o LEFT JOIN [Tipo de Fianzas] AS tf ON (o.Cod_Tipo = tf.Cod_Tf)) " +
                                                                         "LEFT JOIN Consignatarios AS c ON (o.Rif = c.Rif_Consignatario)) " +
                                                                         "WHERE NroOficio = '" + tbOficioOficio.Text + "'", 5);
                    if (dt.Rows.Count == 0)
                    {
                        try
                        {
                            if ((dtpFechaEmisionOficio.Format == DateTimePickerFormat.Short) && (dtpFechaVencimientoOficio.Format == DateTimePickerFormat.Short))
                            {
                                if (Convert.ToString(cbTipoFianzaOficio.SelectedValue).Equals(string.Empty))
                                    lTipoFianzaOficio.ForeColor = ColorTranslator.FromHtml("#EC2E2E");
                                if (Convert.ToString(cbConsignatarioOficio.SelectedValue).Equals(string.Empty))
                                    lConsignatarioOficio.ForeColor = ColorTranslator.FromHtml("#EC2E2E");

                                query = "INSERT INTO Oficios(NroOficio, [Fecha de Oficio], Fecha_Vence, Cod_Tipo, Rif) " +
                                        "VALUES('" + tbOficioOficio.Text + "', '" + dtpFechaEmisionOficio.Value.Date + "', '" + dtpFechaVencimientoOficio.Value.Date + "', '" + Convert.ToByte(cbTipoFianzaOficio.SelectedValue.ToString()) + "', '" + cbConsignatarioOficio.SelectedValue.ToString() + "')";
                            }
                            else if ((dtpFechaEmisionOficio.Format != DateTimePickerFormat.Short) && (dtpFechaVencimientoOficio.Format != DateTimePickerFormat.Short))
                            {
                                if (Convert.ToString(cbTipoFianzaOficio.SelectedValue).Equals(string.Empty))
                                    lTipoFianzaOficio.ForeColor = ColorTranslator.FromHtml("#EC2E2E");
                                if (Convert.ToString(cbConsignatarioOficio.SelectedValue).Equals(string.Empty))
                                    lConsignatarioOficio.ForeColor = ColorTranslator.FromHtml("#EC2E2E");

                                query = "INSERT INTO Oficios(NroOficio, [Fecha de Oficio], Fecha_Vence, Cod_Tipo, Rif) " +
                                        "VALUES('" + tbOficioOficio.Text + "', NULL, NULL, '" + Convert.ToByte(cbTipoFianzaOficio.SelectedValue.ToString()) + "', '" + cbConsignatarioOficio.SelectedValue.ToString() + "')";
                            }
                            else if (dtpFechaEmisionOficio.Format == DateTimePickerFormat.Short)
                            {
                                if (Convert.ToString(cbTipoFianzaOficio.SelectedValue).Equals(string.Empty))
                                    lTipoFianzaOficio.ForeColor = ColorTranslator.FromHtml("#EC2E2E");
                                if (Convert.ToString(cbConsignatarioOficio.SelectedValue).Equals(string.Empty))
                                    lConsignatarioOficio.ForeColor = ColorTranslator.FromHtml("#EC2E2E");

                                query = "INSERT INTO Oficios(NroOficio, [Fecha de Oficio], Fecha_Vence, Cod_Tipo, Rif) " +
                                        "VALUES('" + tbOficioOficio.Text + "', '" + dtpFechaEmisionOficio.Value.Date + "', NULL, '" + Convert.ToByte(cbTipoFianzaOficio.SelectedValue.ToString()) + "', '" + cbConsignatarioOficio.SelectedValue.ToString() + "')";
                            }
                            else
                            {
                                if (Convert.ToString(cbTipoFianzaOficio.SelectedValue).Equals(string.Empty))
                                    lTipoFianzaOficio.ForeColor = ColorTranslator.FromHtml("#EC2E2E");
                                if (Convert.ToString(cbConsignatarioOficio.SelectedValue).Equals(string.Empty))
                                    lConsignatarioOficio.ForeColor = ColorTranslator.FromHtml("#EC2E2E");

                                query = "INSERT INTO Oficios(NroOficio, [Fecha de Oficio], Fecha_Vence, Cod_Tipo, Rif) " +
                                        "VALUES('" + tbOficioOficio.Text + "', NULL, '" + dtpFechaVencimientoOficio.Value.Date + "', '" + Convert.ToByte(cbTipoFianzaOficio.SelectedValue.ToString()) + "', '" + cbConsignatarioOficio.SelectedValue.ToString() + "')";
                            }

                            if (c_ActualizarInfo.GestionarPredeterminados(query) > 0)
                            {
                                estadoOficio = false;
                                oficios = c_ActualizarInfo.ObtenerInfoTablaOficios();
                                contOficios = oficios.Rows.Count - 1;
                                f.ListarOficios(1);
                                new FormAviso("Se ha ingresado el Oficio.", 249, 76).ShowDialog();
                            }
                            else
                                new FormAviso("Error. Verifique los datos.", 241, 72).ShowDialog();
                        }
                        catch (Exception)
                        {
                            new FormAviso("Error. Verifique los datos.", 241, 72).ShowDialog();
                        }
                    }
                    else
                        new FormAviso("No se agregó la información debido a que ya existe el Oficio y la información asociada al mismo.", 775, 339).ShowDialog();
                }
                else
                {
                    new FormAviso("Llene todos los campos.", 230, 67).ShowDialog();
                    tbOficioOficio.Focus();
                }
            else
                if (LlenoOficio())
                {
                    try
                    {
                        if ((dtpFechaEmisionOficio.Format == DateTimePickerFormat.Short) && (dtpFechaVencimientoOficio.Format == DateTimePickerFormat.Short))
                        {
                            if (Convert.ToString(cbTipoFianzaOficio.SelectedValue).Equals(string.Empty))
                                lTipoFianzaOficio.ForeColor = ColorTranslator.FromHtml("#EC2E2E");
                            if (Convert.ToString(cbConsignatarioOficio.SelectedValue).Equals(string.Empty))
                                lConsignatarioOficio.ForeColor = ColorTranslator.FromHtml("#EC2E2E");

                            query = "UPDATE Oficios SET NroOficio = '" + tbOficioOficio.Text + "', [Fecha de Oficio] = '" + dtpFechaEmisionOficio.Value.Date + "', Fecha_Vence = '" + dtpFechaVencimientoOficio.Value.Date + "', " +
                                    "Cod_Tipo = '" + Convert.ToByte(cbTipoFianzaOficio.SelectedValue.ToString()) + "', Rif = '" + cbConsignatarioOficio.SelectedValue.ToString() + "' WHERE Id = " + long.Parse(oficios.Rows[(int)contOficios]["Id"].ToString());
                        }
                        else if ((dtpFechaEmisionOficio.Format != DateTimePickerFormat.Short) && (dtpFechaVencimientoOficio.Format != DateTimePickerFormat.Short))
                        {
                            if (Convert.ToString(cbTipoFianzaOficio.SelectedValue).Equals(string.Empty))
                                lTipoFianzaOficio.ForeColor = ColorTranslator.FromHtml("#EC2E2E");
                            if (Convert.ToString(cbConsignatarioOficio.SelectedValue).Equals(string.Empty))
                                lConsignatarioOficio.ForeColor = ColorTranslator.FromHtml("#EC2E2E");

                            query = "UPDATE Oficios SET NroOficio = '" + tbOficioOficio.Text + "', [Fecha de Oficio] = NULL, Fecha_Vence = NULL, " +
                                    "Cod_Tipo = '" + Convert.ToByte(cbTipoFianzaOficio.SelectedValue.ToString()) + "', Rif = '" + cbConsignatarioOficio.SelectedValue.ToString() + "' WHERE Id = " + long.Parse(oficios.Rows[(int)contOficios]["Id"].ToString());
                        }
                        else if (dtpFechaEmisionOficio.Format == DateTimePickerFormat.Short)
                        {
                            if (Convert.ToString(cbTipoFianzaOficio.SelectedValue).Equals(string.Empty))
                                lTipoFianzaOficio.ForeColor = ColorTranslator.FromHtml("#EC2E2E");
                            if (Convert.ToString(cbConsignatarioOficio.SelectedValue).Equals(string.Empty))
                                lConsignatarioOficio.ForeColor = ColorTranslator.FromHtml("#EC2E2E");

                            query = "UPDATE Oficios SET NroOficio = '" + tbOficioOficio.Text + "', [Fecha de Oficio] = '" + dtpFechaEmisionOficio.Value.Date + "', Fecha_Vence = NULL, " +
                                    "Cod_Tipo = '" + Convert.ToByte(cbTipoFianzaOficio.SelectedValue.ToString()) + "', Rif = '" + cbConsignatarioOficio.SelectedValue.ToString() + "' WHERE Id = " + long.Parse(oficios.Rows[(int)contOficios]["Id"].ToString());
                        }
                        else
                        {
                            if (Convert.ToString(cbTipoFianzaOficio.SelectedValue).Equals(string.Empty))
                                lTipoFianzaOficio.ForeColor = ColorTranslator.FromHtml("#EC2E2E");
                            if (Convert.ToString(cbConsignatarioOficio.SelectedValue).Equals(string.Empty))
                                lConsignatarioOficio.ForeColor = ColorTranslator.FromHtml("#EC2E2E");

                            query = "UPDATE Oficios SET NroOficio = '" + tbOficioOficio.Text + "', [Fecha de Oficio] = NULL, Fecha_Vence = '" + dtpFechaVencimientoOficio.Value.Date + "', " +
                                    "Cod_Tipo = '" + Convert.ToByte(cbTipoFianzaOficio.SelectedValue.ToString()) + "', Rif = '" + cbConsignatarioOficio.SelectedValue.ToString() + "' WHERE Id = " + long.Parse(oficios.Rows[(int)contOficios]["Id"].ToString());
                        }

                        if (c_ActualizarInfo.GestionarPredeterminados(query) > 0)
                        {
                            oficios = c_ActualizarInfo.ObtenerInfoTablaOficios();
                            f.ListarOficios(2);
                            new FormAviso("Se ha actualizado el Oficio.", 263, 83).ShowDialog();
                        }
                        else
                            new FormAviso("Error. Verifique los datos_1.", 241, 72).ShowDialog();
                    }
                    catch (Exception)
                    {
                        new FormAviso("Error. Verifique los datos.", 241, 72).ShowDialog();
                    }
                }
                else
                {
                    new FormAviso("Llene todos los campos.", 230, 67).ShowDialog();
                    tbOficioOficio.Focus();
                }
        }

        private bool LlenoOficio()
        {
            if (tbOficioOficio.Text.Equals(string.Empty) || cbConsignatarioOficio.Text.Equals(string.Empty) || cbTipoFianzaOficio.Text.Equals(string.Empty))
                return false;
            return true;
        }

        private void ColorOriginalEtiquetasOficio()
        {
            lConsignatarioOficio.ForeColor = Color.Lavender;
            lTipoFianzaOficio.ForeColor = Color.Lavender;
        }

        private void btnRegresarOficio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpFechaEmisionOficio_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaEmisionOficio.Format = DateTimePickerFormat.Short;
        }

        private void dtpFechaEmisionOficio_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dtpFechaEmisionOficio.Value = DateTime.Today;
                dtpFechaEmisionOficio.Format = DateTimePickerFormat.Custom;
                dtpFechaEmisionOficio.CustomFormat = " ";
            }
        }

        private void dtpFechaVencimientoOficio_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaVencimientoOficio.Format = DateTimePickerFormat.Short;
        }

        private void dtpFechaVencimientoOficio_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dtpFechaVencimientoOficio.Value = DateTime.Today;
                dtpFechaVencimientoOficio.Format = DateTimePickerFormat.Custom;
                dtpFechaVencimientoOficio.CustomFormat = " ";
            }
        }


        private void cbConsignatarioOficio_KeyPress(object sender, KeyPressEventArgs e)
        {
            lConsignatarioOficio.ForeColor = Color.Lavender;
        }

        private void cbTipoFianzaOficio_KeyPress(object sender, KeyPressEventArgs e)
        {
            lTipoFianzaOficio.ForeColor = Color.Lavender;
        }


        private void cbConsignatarioOficio_SelectedIndexChanged(object sender, EventArgs e)
        {
            lConsignatarioOficio.ForeColor = Color.Lavender;
        }

        private void cbTipoFianzaOficio_SelectedIndexChanged(object sender, EventArgs e)
        {
            lTipoFianzaOficio.ForeColor = Color.Lavender;
        }
        // FIN BOTONES OFICIO


        // BOTONES GERENTE
        private void btnNuevoGerente_Click(object sender, EventArgs e)
        {
            tbSiglas_Gerente.Focus();
            estadoGerente = true;
            VaciarCamposGerente();
            lCantidadGerentes.Text = (gerentes.Rows.Count + 1) + " de " + (gerentes.Rows.Count + 1);
        }

        private void VaciarCamposGerente()
        {
            tbSiglas_Gerente.Text = string.Empty;
            tbNombreGerente.Text = string.Empty;
            tbCargoGerente.Text = string.Empty;
            tbProvidenciaGerente.Text = string.Empty;

            dtpFechaProvidenciaGerente.Value = DateTimePicker.MinimumDateTime;
            dtpFechaProvidenciaGerente.Format = DateTimePickerFormat.Custom;
            dtpFechaProvidenciaGerente.CustomFormat = " ";

            tbGacetaOficialGerente.Text = string.Empty;

            dtpFechaGacetaGerente.Value = DateTimePicker.MinimumDateTime;
            dtpFechaGacetaGerente.Format = DateTimePickerFormat.Custom;
            dtpFechaGacetaGerente.CustomFormat = " ";

            tbProvidencia.Text = string.Empty;
            tbGacetaOficial.Text = string.Empty;

            dtpFechaGaceta.Value = DateTimePicker.MinimumDateTime;
            dtpFechaGaceta.Format = DateTimePickerFormat.Custom;
            dtpFechaGaceta.CustomFormat = " ";
        }

        private void btnBuscarGerente_Click(object sender, EventArgs e)
        {
            FormBuscarPredeterminado fbp = new FormBuscarPredeterminado("Ingrese o seleccione el nombre del Gerente", 6);
            fbp.setListado(gerentes);
            fbp.ShowDialog();
            //DataTable dt = fbp.dt;

            if (fbp.ban)
            {
                estadoGerente = false;
                if (fbp.fi != null) // dt.Rows.Count > 0
                {
                    DataRow geren = fbp.fi;

                    tbNombreGerente.Text = geren["Nombre"].ToString();
                    tbCargoGerente.Text = geren["Cargo"].ToString();
                    tbProvidenciaGerente.Text = geren["Providencia_Gerente"].ToString();

                    // Oficio
                    if (fechaVieja == Convert.ToDateTime(geren["FechaProvidencia_Gerente"].ToString())) //fechaVieja == Convert.ToDateTime(geren["FechaProvidencia_Gerente"].ToString())
                    {
                        dtpFechaProvidenciaGerente.Value = DateTime.Today;
                        dtpFechaProvidenciaGerente.Format = DateTimePickerFormat.Custom;
                        dtpFechaProvidenciaGerente.CustomFormat = " ";
                    }
                    else
                    {
                        dtpFechaProvidenciaGerente.Format = DateTimePickerFormat.Short;
                        dtpFechaProvidenciaGerente.Value = Convert.ToDateTime(geren["FechaProvidencia_Gerente"].ToString());
                    }

                    // Fecha Gaceta
                    if (fechaVieja == Convert.ToDateTime(geren["FechaGaceta_Gerente"].ToString()))
                    {
                        dtpFechaGacetaGerente.Value = DateTime.Today;
                        dtpFechaGacetaGerente.Format = DateTimePickerFormat.Custom;
                        dtpFechaGacetaGerente.CustomFormat = " ";
                    }
                    else
                    {
                        dtpFechaGacetaGerente.Format = DateTimePickerFormat.Short;
                        dtpFechaGacetaGerente.Value = Convert.ToDateTime(geren["FechaGaceta_Gerente"].ToString());
                    }

                    tbGacetaOficialGerente.Text = geren["GO_Gerente"].ToString();
                    tbProvidencia.Text = geren["Providencia"].ToString();
                    tbGacetaOficial.Text = geren["GO"].ToString();

                    if (fechaVieja == Convert.ToDateTime(geren["FechaGaceta"].ToString()))
                    {
                        dtpFechaGaceta.Value = DateTime.Today;
                        dtpFechaGaceta.Format = DateTimePickerFormat.Custom;
                        dtpFechaGaceta.CustomFormat = " ";
                    }
                    else
                    {
                        dtpFechaGaceta.Format = DateTimePickerFormat.Short;
                        dtpFechaGaceta.Value = Convert.ToDateTime(geren["FechaGaceta"].ToString());
                    }

                    tbSiglas_Gerente.Text = geren["Siglas"].ToString();
                    chbGerenteActivo.Checked = Convert.ToBoolean(geren["GerenteActivo"].ToString());

                    int i = 0;
                    foreach (DataRow gerente in gerentes.Rows)
                    {
                        if (gerente["Nombre"].ToString().Equals(geren["Nombre"].ToString()))
                            break;
                        i++;
                    }
                    contGerentes = i;

                    lCantidadGerentes.Text = (contGerentes + 1) + " de " + gerentes.Rows.Count;
                }
            }
        }

        private void btnPrimerGerente_Click(object sender, EventArgs e)
        {
            estadoGerente = false;
            contGerentes = 0;
            InformacionGerente();
        }

        private void btnUltimoGerente_Click(object sender, EventArgs e)
        {
            estadoGerente = false;
            contGerentes = gerentes.Rows.Count - 1;
            InformacionGerente();
        }

        private void btnAnteriorGerente_Click(object sender, EventArgs e)
        {
            if (!estadoGerente)
                if (contGerentes > 0)
                {
                    contGerentes--;
                    InformacionGerente();
                }
        }

        private void btnSiguienteGerente_Click(object sender, EventArgs e)
        {
            if (!estadoGerente)
                if (contGerentes < (gerentes.Rows.Count - 1))
                {
                    contGerentes++;
                    InformacionGerente();
                }
        }

        private void btnGuardarGerente_Click(object sender, EventArgs e)
        {
            string query;
            if (estadoGerente)
                if (LlenoGerente())
                {
                    // Primero verifico si el gerente existe en la base de datos
                    DataTable dt = c_ActualizarInfo.BuscarPredeterminado("SELECT * FROM Gerente WHERE Nombre = '" + tbNombreGerente.Text + "'", 6);
                    if (dt.Rows.Count == 0)
                    {
                        query = "INSERT INTO Gerente(Nombre, Cargo, Providencia_Gerente, FechaProvidencia_Gerente, GO_Gerente, FechaGaceta_Gerente, Providencia, [GO], FechaGaceta, Siglas, GerenteActivo) " +
                                "VALUES('" + tbNombreGerente.Text + "', '" + tbCargoGerente.Text + "', '" + tbProvidenciaGerente.Text + "', " +
                                "'" + dtpFechaProvidenciaGerente.Value.Date + "', '" + tbGacetaOficialGerente.Text + "', '" + dtpFechaGacetaGerente.Value.Date + "', " +
                                "'" + tbProvidencia.Text + "', '" + tbGacetaOficial.Text + "', '" + dtpFechaGaceta.Value.Date + "', '" + tbSiglas_Gerente.Text + "', " + chbGerenteActivo.Checked + ")";

                        if (c_ActualizarInfo.GestionarPredeterminados(query) > 0)
                        {
                            estadoGerente = false;
                            gerentes = c_ActualizarInfo.ObtenerInfoTablaGerente();
                            contGerentes = gerentes.Rows.Count - 1;
                            new FormAviso("Se ha ingresado el Gerente.", 263, 83).ShowDialog();
                        }
                    }
                    else
                        new FormAviso("No se agregó la información debido a que ya existe el Gerente y la información asociada al mismo.", 795, 349).ShowDialog();
                }
                else
                {
                    new FormAviso("Debe llenar los campos necesarios para poder ingresar la información del Gerente", 685, 294).ShowDialog();
                    tbSiglas_Gerente.Focus();
                }
            else
                if (LlenoGerente())
                {
                    query = "UPDATE Gerente SET Nombre = '" + tbNombreGerente.Text + "', Cargo = '" + tbCargoGerente.Text + "', Providencia_Gerente = '" + tbProvidenciaGerente.Text + "', " +
                            "FechaProvidencia_Gerente = '" + dtpFechaProvidenciaGerente.Value.Date + "', GO_Gerente = '" + tbGacetaOficialGerente.Text + "', FechaGaceta_Gerente = '" + dtpFechaGacetaGerente.Value.Date + "', " +
                            "Providencia = '" + tbProvidencia.Text + "', [GO] = '" + tbGacetaOficial.Text + "', FechaGaceta = '" + dtpFechaGaceta.Value.Date + "', Siglas = '" + tbSiglas_Gerente.Text + "', " +
                            "GerenteActivo = " + chbGerenteActivo.Checked + " WHERE idGerente = " + long.Parse(gerentes.Rows[(int)contGerentes]["idGerente"].ToString()) + "";

                    if (c_ActualizarInfo.GestionarPredeterminados(query) > 0)
                    {
                        gerentes = c_ActualizarInfo.ObtenerInfoTablaGerente();
                        new FormAviso("Se ha actualizado el Gerente.", 280, 91).ShowDialog();
                    }
                }
                else
                {
                    new FormAviso("Debe llenar los campos necesarios para poder actualizar la información del Gerente", 685, 294).ShowDialog();
                    tbSiglas_Gerente.Focus();
                }
        }

        private bool LlenoGerente()
        {
            if (tbNombreGerente.Text.Equals(string.Empty) || tbCargoGerente.Text.Equals(string.Empty) || tbProvidenciaGerente.Text.Equals(string.Empty) ||
                tbGacetaOficialGerente.Text.Equals(string.Empty) || tbProvidencia.Text.Equals(string.Empty))
                return false;
            return true;
        }

        private void btnRegresarGerente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpOficioGerente_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaProvidenciaGerente.Format = DateTimePickerFormat.Short;
        }

        private void dtpOficioGerente_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dtpFechaProvidenciaGerente.Value = DateTime.Today;
                dtpFechaProvidenciaGerente.Format = DateTimePickerFormat.Custom;
                dtpFechaProvidenciaGerente.CustomFormat = " ";
            }
        }

        private void dtpFechaGacetaGerente_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaGacetaGerente.Format = DateTimePickerFormat.Short;
        }

        private void dtpFechaGacetaGerente_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dtpFechaGacetaGerente.Value = DateTime.Today;
                dtpFechaGacetaGerente.Format = DateTimePickerFormat.Custom;
                dtpFechaGacetaGerente.CustomFormat = " ";
            }
        }

        private void dtpFechaGaceta_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaGaceta.Format = DateTimePickerFormat.Short;
        }

        private void dtpFechaGaceta_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dtpFechaGaceta.Value = DateTime.Today;
                dtpFechaGaceta.Format = DateTimePickerFormat.Custom;
                dtpFechaGaceta.CustomFormat = " ";
            }
        }
        // FIN BOTONES GERENTE


        // BOTONES MOTIVOS
        private void btnNuevoML_Click(object sender, EventArgs e)
        {
            tbDescripcionML.Focus();
            estadoML = true;
            VaciarCamposML();
            lCantidadMotivos.Text = (motivos.Rows.Count + 1) + " de " + (motivos.Rows.Count + 1);
        }

        private void VaciarCamposML()
        {
            tbCodigoLiberacionML.Text = Convert.ToString(motivos.Rows.Count);
            tbDescripcionML.Text = string.Empty;
        }

        private void btnBuscarML_Click(object sender, EventArgs e)
        {
            FormBuscarPredeterminado fbp = new FormBuscarPredeterminado("Ingrese o seleccione el Motivo", 7);
            fbp.setListado(motivos);
            fbp.ShowDialog();
            //DataTable dt = fbp.dt;

            if (fbp.ban)
            {
                estadoML = false;
                if (fbp.fi != null) // dt.Rows.Count > 0
                {
                    DataRow moti = fbp.fi;

                    tbCodigoLiberacionML.Text = moti["Cod_Lib"].ToString();
                    tbCodigoLiberacionML.Enabled = false;

                    tbDescripcionML.Text = moti["Descripcion"].ToString();

                    int i = 0;
                    foreach (DataRow motivo in motivos.Rows)
                    {
                        if (motivo["Descripcion"].ToString().Equals(moti["Descripcion"].ToString()))
                            break;
                        i++;
                    }
                    contMotivos = i;

                    lCantidadMotivos.Text = (contMotivos + 1) + " de " + motivos.Rows.Count;
                }
            }
        }

        private void btnPrimerML_Click(object sender, EventArgs e)
        {
            estadoML = false;
            contMotivos = 0;
            InformacionMotivos();
        }

        private void btnUltimoML_Click(object sender, EventArgs e)
        {
            estadoML = false;
            contMotivos = motivos.Rows.Count - 1;
            InformacionMotivos();
        }

        private void btnAnteriorML_Click(object sender, EventArgs e)
        {
            if (!estadoML)
                if (contMotivos > 0)
                {
                    contMotivos--;
                    InformacionMotivos();
                }
        }

        private void btnSiguienteML_Click(object sender, EventArgs e)
        {
            if (!estadoML)
                if (contMotivos < (motivos.Rows.Count - 1))
                {
                    contMotivos++;
                    InformacionMotivos();
                }
        }

        private void btnGuardarML_Click(object sender, EventArgs e)
        {
            string query;
            if (estadoML)
                if (LlenoML())
                {
                    // Primero verifico si el motivo existe en la base de datos
                    DataTable dt = c_ActualizarInfo.BuscarPredeterminado("SELECT * FROM Motivos WHERE Descripcion = '" + tbDescripcionML.Text + "'", 7);
                    if (dt.Rows.Count == 0)
                    {
                        query = "INSERT INTO Motivos(Cod_Lib, Descripcion) " +
                                "VALUES(" + Convert.ToInt32(tbCodigoLiberacionML.Text) + ", '" + tbDescripcionML.Text + "')";

                        if (c_ActualizarInfo.GestionarPredeterminados(query) > 0)
                        {
                            estadoML = false;
                            motivos = c_ActualizarInfo.ObtenerInfoTablaMotivos();
                            contMotivos = motivos.Rows.Count - 1;
                            new FormAviso("Se ha ingresado el Motivo de Liberación.", 361, 132).ShowDialog();
                            tbCodigoLiberacionML.Enabled = false;
                        }
                    }
                    else
                        new FormAviso("No se agregó la información debido a que ya existe el Motivo y la información asociada al mismo.", 785, 344).ShowDialog();
                }
                else
                {
                    new FormAviso("Llene todos los campos. ", 230, 67).ShowDialog();
                    tbDescripcionML.Focus();
                }
            else
                if (LlenoML())
                {
                    query = "UPDATE Motivos SET Descripcion = '" + tbDescripcionML.Text + "' WHERE Cod_Lib = " + Convert.ToInt32(tbCodigoLiberacionML.Text);

                    if (c_ActualizarInfo.GestionarPredeterminados(query) > 0)
                    {
                        motivos = c_ActualizarInfo.ObtenerInfoTablaMotivos();
                        new FormAviso("Se ha actualizado el Motivo de Liberación.", 375, 139).ShowDialog();
                    }
                }
                else
                {
                    new FormAviso("Llene todos los campos. ", 230, 67).ShowDialog();
                    tbDescripcionML.Focus();
                }
        }

        private bool LlenoML()
        {
            if (tbCodigoLiberacionML.Text.Equals(string.Empty) || tbDescripcionML.Text.Equals(string.Empty))
                return false;
            return true;
        }

        private void btnRegresarML_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbCodigoLiberacionML_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = true;
        }
        // FIN BOTONES MOTIVOS
    }
}
