using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Globalization;

using Controlador;

namespace Vista
{
    public partial class FormFianzas : Form
    {
        ControladorFianzas c_Fianzas = new ControladorFianzas();
        DataTable fianzas;
        int cont, Año;
        bool ban = false, estado = true;
        string cadena = string.Empty;

        public FormFianzas()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lFecha.Text = DateTime.Now.ToString("D");
            lHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void Fianzas_Load(object sender, EventArgs e)
        {
            // GARANTES
            ListarGarantes(1);

            // AGENTES
            ListarAgentes(1);

            // CONTRIBUYENTES
            ListarContribuyente(1);

            // NATURALEZA DE LA OPERACIÓN
            ListarTipoDeFianza(1);

            // OFICIOS
            ListarOficios(1);
            
            tbNroFianza.Focus();
        }

        public void ListarGarantes(byte op)
        {
            cbGarante.DataSource = new FormActualizarInfo(this).c_ActualizarInfo.ObtenerInfoTablaGarantes();
            cbGarante.DisplayMember = "Nombre_Garante";
            cbGarante.ValueMember = "Rif_Garante";

            if (op == 2)
                fianzas = c_Fianzas.ObtenerCantidadFianzas(Año);

            if (estado)
                cbGarante.SelectedIndex = -1;
            else
                cbGarante.Text = fianzas.Rows[cont]["Nombre_Garante"].ToString();
        }

        public void ListarAgentes(byte op)
        {
            cbAgente.DataSource = new FormActualizarInfo(this).c_ActualizarInfo.ObtenerInfoTablaAgentes();
            cbAgente.DisplayMember = "Nombre_Agente";
            cbAgente.ValueMember = "Rif_Agentes";

            if (op == 2)
                fianzas = c_Fianzas.ObtenerCantidadFianzas(Año);

            if (estado)
                cbAgente.SelectedIndex = -1;
            else
                cbAgente.Text = fianzas.Rows[cont]["Nombre_Agente"].ToString();
        }

        public void ListarContribuyente(byte op)
        {
            cbContribuyente.DataSource = new FormActualizarInfo(this).c_ActualizarInfo.ObtenerInfoTablaConsignatarios();
            cbContribuyente.DisplayMember = "Nombre_Consignatario";
            cbContribuyente.ValueMember = "Rif_Consignatario";
            
            if (op == 2)
                fianzas = c_Fianzas.ObtenerCantidadFianzas(Año);

            if (estado)
                cbContribuyente.SelectedIndex = -1;
            else
                cbContribuyente.Text = fianzas.Rows[cont]["Nombre_Consignatario"].ToString();
        }

        public void ListarTipoDeFianza(byte op)
        {
            cbNaturalezaOperacion.DataSource = new FormActualizarInfo(this).c_ActualizarInfo.ObtenerInfoTablaTipoFianza();
            cbNaturalezaOperacion.DisplayMember = "DesTipFian";
            cbNaturalezaOperacion.ValueMember = "Cod_Tf";

            if (op == 2)
                fianzas = c_Fianzas.ObtenerCantidadFianzas(Año);

            if (estado)
                cbNaturalezaOperacion.SelectedIndex = -1;
            else
                cbNaturalezaOperacion.Text = fianzas.Rows[cont]["NaturalezaOperacion"].ToString();
        }

        public void ListarOficios(byte op)
        {
            cbOficio.DataSource = new FormActualizarInfo(this).c_ActualizarInfo.ObtenerInfoTablaOficios();
            cbOficio.DisplayMember = "NroOficio";
            cbOficio.ValueMember = "Id";

            if (op == 2)
                fianzas = c_Fianzas.ObtenerCantidadFianzas(Año);

            if (estado)
                cbOficio.SelectedIndex = -1;
            else
                cbOficio.Text = fianzas.Rows[cont]["NroOficio"].ToString();
        }

        private void tbAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void tbNro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void tbArchivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = true;
        }

        public void SetAño(int año)
        {
            tbAño.Text = año.ToString();
        }

        public void ObtenerFianzas(int año, int opc)
        {
            Año = año;
            if (opc == 1)
            {
                fianzas = c_Fianzas.ObtenerCantidadFianzas(Año);
                lCantidadFianzas.Text = "Fianza " + (fianzas.Rows.Count + 1) + " de " + (fianzas.Rows.Count + 1);
            }
            else
                fianzas = c_Fianzas.ObtenerCantidadFianzas(año);
        }

        public void SetNumeroArchivo()
        {
            tbArchivo.Text = Convert.ToString(fianzas.Rows.Count + 1);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            estado = true;
            VaciarCampos();
            ColorOriginalEtiquetas();
            lCantidadFianzas.Text = "Fianza " + (fianzas.Rows.Count + 1) + " de " + (fianzas.Rows.Count + 1);
            SetNumeroArchivo();
            ban = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //DataTable dt_FianzaAingresar;
            // Si se presionó el botón "Nueva Fianza" del Form "FormFianza" o se presionó el botón "Fianzas"
            // del Form "FormVentadaPrincipal"...
            if (estado)
            {
                if (VerificarCampos())
                    new FormAviso("Llene los campos necesarios para poder ingresar la fianza.", 492, 197).ShowDialog();
                else
                {
                    //dt_FianzaAingresar = TomarInformacionFianzaAIngresar(1);
                    if (TomarInformacionFianzaAIngresar(1).Rows.Count > 0)
                    {
                        if (c_Fianzas.GestionarFianza(TomarInformacionFianzaAIngresar(1), 1, Convert.ToInt32(tbAño.Text)) > 0)
                        {
                            new FormAviso("Se ha ingresado una fianza.", 259, 80).ShowDialog();
                            ObtenerFianzas(Convert.ToInt32(tbAño.Text), 1);
                            VaciarCampos();
                            SetNumeroArchivo();
                        }
                        else
                            new FormAviso("Error. Verifique los datos.", 241, 72).ShowDialog();
                    }
                    else
                        new FormAviso("Error. Verifique los datos.", 241, 72).ShowDialog();
                }
            }
            else
            {
                // Si el valor de la variable "estado" es falso, quiere decir que se va a
                // actualizar la información de una fianza.
                if (VerificarCampos())
                    new FormAviso("Llene los campos necesarios para poder actualizar la fianza.", 505, 204).ShowDialog();
                else
                {
                    //dt_FianzaAingresar = TomarInformacionFianzaAIngresar(2);
                    if (TomarInformacionFianzaAIngresar(2).Rows.Count > 0)
                    {
                        if (c_Fianzas.GestionarFianza(TomarInformacionFianzaAIngresar(2), 2, Convert.ToInt32(tbAño.Text)) > 0)
                        {
                            new FormAviso("Se ha actualizado una fianza.", 274, 88).ShowDialog();
                            ObtenerFianzas(Convert.ToInt32(tbAño.Text), 2);
                        }
                        else
                        {
                            lNroFianza.ForeColor = ColorTranslator.FromHtml("#EC2E2E");
                            new FormAviso("Error. Verifique los datos.1", 241, 72).ShowDialog();
                        }
                    }
                    else
                        new FormAviso("Error. Verifique los datos.2", 241, 72).ShowDialog();
                }
            }
        }

        public DataTable TomarInformacionFianzaAIngresar(int opc)
        {
            DataTable dt = new DataTable();

            if (opc == 2)
                dt.Columns.Add("idNroFianza");

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

            if (opc == 1)
                dt.Columns.Add("Ingreso al Sistema");

            DataRow f = dt.NewRow();

            if (opc == 2)
                f["idNroFianza"] = fianzas.Rows[cont]["idNroFianza"].ToString();

            f["Nro de Fianza"] = tbNroFianza.Text;
            f["Fecha de Emision"] = Convert.ToDateTime(dtpEmision.Value.ToString("dd/MM/yyyy")).ToShortDateString();
            f["Nro Archivo"] = long.Parse(tbArchivo.Text);
            f["Fecha de Vencimiento"] = Convert.ToDateTime(dtpVencimiento.Value.ToString("dd/MM/yyyy")).ToShortDateString();
            f["Fecha Recibida"] = Convert.ToDateTime(dtpRecibida.Value.ToString("dd/MM/yyyy")).ToShortDateString();
            f["Ano"] = Convert.ToInt32(tbAño.Text);

            f["Nombre_Garante"] = Convert.ToString(cbGarante.SelectedValue);
            if (f["Nombre_Garante"].ToString().Equals(string.Empty))
                lGarante.ForeColor = ColorTranslator.FromHtml("#EC2E2E");
            f["Nombre_Agente"] = Convert.ToString(cbAgente.SelectedValue);
            if (f["Nombre_Agente"].ToString().Equals(string.Empty))
                lAgente.ForeColor = ColorTranslator.FromHtml("#EC2E2E");
            f["Nombre_Consignatario"] = Convert.ToString(cbContribuyente.SelectedValue);
            if (f["Nombre_Consignatario"].ToString().Equals(string.Empty))
                lContribuyente.ForeColor = ColorTranslator.FromHtml("#EC2E2E");

            try
            {
                f["NaturalezaOperacion"] = Convert.ToByte(Convert.ToString(cbNaturalezaOperacion.SelectedValue));
            }
            catch (Exception)
            {
                lNaturalezaOperacion.ForeColor = ColorTranslator.FromHtml("#EC2E2E");
            }

            f["Asunto"] = tbAsunto.Text;

            string monto1 = tbMonto.Text.Replace(".", "");
            string monto2 = monto1.Replace(",", ".");
            f["Monto"] = monto2;

            f["Notaria"] = tbNotaria.Text;
            f["Tomo"] = tbTomo.Text;
            f["Nro"] = tbNro.Text;
            f["Fecha de Reg"] = Convert.ToDateTime(dtpFechaRegistro.Value.ToString("dd/MM/yyyy")).ToShortDateString();

            try
            {
                f["NroOficio"] = long.Parse(Convert.ToString(cbOficio.SelectedValue));
            }
            catch (Exception)
            {
                lOficio.ForeColor = ColorTranslator.FromHtml("#EC2E2E");
            }

            if (opc == 1)
                f["Ingreso al Sistema"] = DateTime.Now.Date.ToShortDateString();

            if (lGarante.ForeColor.Equals(ColorTranslator.FromHtml("#EC2E2E")) || lAgente.ForeColor.Equals(ColorTranslator.FromHtml("#EC2E2E")) ||
                lContribuyente.ForeColor.Equals(ColorTranslator.FromHtml("#EC2E2E")) || lNaturalezaOperacion.ForeColor.Equals(ColorTranslator.FromHtml("#EC2E2E")) ||
                lOficio.ForeColor.Equals(ColorTranslator.FromHtml("#EC2E2E")))
            {
                dt = new DataTable();
                return dt;
            }

            dt.Rows.Add(f);

            return dt;
            
        }

        public void VaciarCampos()
        {
            tbNroFianza.Text = string.Empty;
            tbNroFianza.Focus();
            cbGarante.Text = string.Empty;
            tbMonto.Text = "0,00";
            cbAgente.Text = string.Empty;
            cbContribuyente.Text = string.Empty;
            cbNaturalezaOperacion.Text = string.Empty;

            dtpEmision.Value = DateTime.Now.Date;
            dtpVencimiento.Value = DateTime.Now.Date;
            dtpRecibida.Value = DateTime.Now.Date;

            tbArchivo.Text = string.Empty;
            tbAsunto.Text = string.Empty;
            tbNotaria.Text = string.Empty;
            tbTomo.Text = string.Empty;
            cbOficio.Text = string.Empty;
            tbNro.Text = string.Empty;

            dtpFechaRegistro.Value = DateTime.Now.Date;

            lGarante.ForeColor = Color.Lavender;
            lAgente.ForeColor = Color.Lavender;
            lContribuyente.ForeColor = Color.Lavender;
            lNaturalezaOperacion.ForeColor = Color.Lavender;
            lOficio.ForeColor = Color.Lavender;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormIntroducirNroFianza finf = new FormIntroducirNroFianza(Convert.ToInt32(tbAño.Text));
            finf.setListadoFianzas(fianzas);
            finf.ShowDialog();
            if (finf.ban)
            {
                DataRow filaEncontrada = finf.fi;
                LlenarCampos(filaEncontrada);
                estado = false;
                ban = true;

                // Este código es para saber en cuál fianza estoy ubicado
                int i = 0;
                foreach (DataRow fila in fianzas.Rows)
                {
                    if (fila["idNroFianza"].ToString().Equals(filaEncontrada["idNroFianza"].ToString())) // fila["Nro de Fianza"].ToString().Equals(filaEncontrada["Nro de Fianza"].ToString())
                        break;
                    i++;
                }

                lCantidadFianzas.Text = "Fianza " + (i + 1) + " de " + fianzas.Rows.Count;
                cont = i;
                finf.Close();
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (fianzas.Rows.Count > 0)
            {
                estado = false;
                if (!ban)
                    ban = true;
                cont = 0;
                DataRow fila = fianzas.Rows[cont];
                LlenarCampos(fila);
                lCantidadFianzas.Text = "Fianza " + (cont + 1) + " de " + fianzas.Rows.Count;
                ColorOriginalEtiquetas();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (fianzas.Rows.Count > 0)
            {
                estado = false;
                if (!ban)
                    ban = true;
                cont = fianzas.Rows.Count - 1;
                DataRow fila = fianzas.Rows[cont];
                LlenarCampos(fila);
                lCantidadFianzas.Text = "Fianza " + (cont + 1) + " de " + fianzas.Rows.Count;
                ColorOriginalEtiquetas();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (ban)
            {
                estado = false;
                if (cont < (fianzas.Rows.Count - 1))
                {
                    DataRow fila = fianzas.Rows[++cont];
                    LlenarCampos(fila);
                    lCantidadFianzas.Text = "Fianza " + (cont + 1) + " de " + fianzas.Rows.Count;
                    ColorOriginalEtiquetas();
                }
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (ban)
            {
                estado = false;
                if (cont > 0)
                {
                    DataRow fila = fianzas.Rows[--cont];
                    LlenarCampos(fila);
                    lCantidadFianzas.Text = "Fianza " + (cont + 1) + " de " + fianzas.Rows.Count;
                    ColorOriginalEtiquetas();
                }
            }
        }

        private void btnEtiqueta_Click(object sender, EventArgs e)
        {
            if (!estado)
            {
                if (fianzas.Rows.Count > 0)
                {
                    FormEtiquetas fe = new FormEtiquetas(fianzas, tbNroFianza.Text, Convert.ToInt32(tbAño.Text), tbArchivo.Text, cbContribuyente.Text, cbNaturalezaOperacion.Text);
                    fe.ShowDialog();
                    if (fe.estado)
                        if (fe.dtgFianzas != null)
                        {
                            if (fe.dtgFianzas.RowCount == 3)
                                new FormMostrarEtiqueta_3_etiquetas(fe.dtgFianzas).ShowDialog();
                            else if (fe.dtgFianzas.RowCount == 2)
                                new FormMostrarEtiqueta_2_etiquetas(fe.dtgFianzas).ShowDialog();
                            else
                                new FormMostrarEtiqueta_1_etiqueta(fe.dtgFianzas).ShowDialog();
                        }
                }
            }
        }

        public void LlenarCampos(DataRow fi)
        {
            tbNroFianza.Text = fi["Nro de Fianza"].ToString();
            cbGarante.Text = fi["Nombre_Garante"].ToString();
            tbMonto.Text = fi["Monto"].ToString();
            tbAño.Text = fi["Ano"].ToString();
            cbAgente.Text = fi["Nombre_Agente"].ToString();
            cbContribuyente.Text = fi["Nombre_Consignatario"].ToString();
            cbNaturalezaOperacion.Text = fi["NaturalezaOperacion"].ToString();

            if (Convert.ToDateTime(fi["Fecha de Emision"].ToString()) == DateTime.MinValue)
            {
                dtpEmision.Value = DateTime.Today;
                dtpEmision.Format = DateTimePickerFormat.Custom;
                dtpEmision.CustomFormat = " ";
            }
            else
            {
                dtpEmision.Value = Convert.ToDateTime(fi["Fecha de Emision"].ToString());
                dtpEmision.Format = DateTimePickerFormat.Short;
            }

            if (Convert.ToDateTime(fi["Fecha de Vencimiento"].ToString()) == DateTime.MinValue)
            {
                dtpVencimiento.Value = DateTime.Today;
                dtpVencimiento.Format = DateTimePickerFormat.Custom;
                dtpVencimiento.CustomFormat = " ";
            }
            else
            {
                dtpVencimiento.Value = Convert.ToDateTime(fi["Fecha de Vencimiento"].ToString());
                dtpVencimiento.Format = DateTimePickerFormat.Short;
            }

            if (Convert.ToDateTime(fi["Fecha Recibida"].ToString()) == DateTime.MinValue)
            {
                dtpRecibida.Value = DateTime.Today;
                dtpRecibida.Format = DateTimePickerFormat.Custom;
                dtpRecibida.CustomFormat = " ";
            }
            else
            {
                dtpRecibida.Value = Convert.ToDateTime(fi["Fecha Recibida"].ToString());
                dtpRecibida.Format = DateTimePickerFormat.Short;
            }

            tbArchivo.Text = fi["Nro Archivo"].ToString();
            tbAsunto.Text = fi["Asunto"].ToString();
            tbNotaria.Text = fi["Notaria"].ToString();
            tbTomo.Text = fi["Tomo"].ToString();


            if (fi["NroOficio"].ToString().Equals(string.Empty))
                cbOficio.Text = string.Empty;
            else
                cbOficio.Text = fi["NroOficio"].ToString();


            tbNro.Text = fi["Nro"].ToString();

            if (Convert.ToDateTime(fi["Fecha de Reg"].ToString()) == DateTime.MinValue)
            {
                dtpFechaRegistro.Value = DateTime.Today;
                dtpFechaRegistro.Format = DateTimePickerFormat.Custom;
                dtpFechaRegistro.CustomFormat = " ";
            }
            else
            {
                dtpFechaRegistro.Value = Convert.ToDateTime(fi["Fecha de Reg"].ToString());
                dtpFechaRegistro.Format = DateTimePickerFormat.Short;
            }

            ColorOriginalEtiquetas();
        }

        private void ColorOriginalEtiquetas()
        {
            lNroFianza.ForeColor = Color.Lavender;
            lGarante.ForeColor = Color.Lavender;
            lAgente.ForeColor = Color.Lavender;
            lContribuyente.ForeColor = Color.Lavender;
            lNaturalezaOperacion.ForeColor = Color.Lavender;
            lNotaria.ForeColor = Color.Lavender;
            lTomo.ForeColor = Color.Lavender;
            lNro.ForeColor = Color.Lavender;
            lOficio.ForeColor = Color.Lavender;
        }

        public Boolean VerificarCampos()
        {
            if (tbNroFianza.Text.Equals("") || cbGarante.Text.Equals("") || cbAgente.Text.Equals("") ||
                cbContribuyente.Text.Equals("") || cbNaturalezaOperacion.Text.Equals("") ||
                tbNotaria.Text.Equals("") || tbTomo.Text.Equals("") || cbOficio.Text.Equals("") || tbNro.Text.Equals(""))
            {
                if (tbNroFianza.Text.Equals(string.Empty))
                    lNroFianza.ForeColor = ColorTranslator.FromHtml("#EC2E2E");
                if (cbGarante.Text.Equals(string.Empty) || Convert.ToString(cbGarante.SelectedValue).Equals(string.Empty))
                    lGarante.ForeColor = ColorTranslator.FromHtml("#EC2E2E");
                if (cbAgente.Text.Equals(string.Empty) || Convert.ToString(cbAgente.SelectedValue).Equals(string.Empty))
                    lAgente.ForeColor = ColorTranslator.FromHtml("#EC2E2E");
                if (cbContribuyente.Text.Equals(string.Empty) || Convert.ToString(cbContribuyente.SelectedValue).Equals(string.Empty))
                    lContribuyente.ForeColor = ColorTranslator.FromHtml("#EC2E2E");
                if (cbNaturalezaOperacion.Text.Equals(string.Empty) || Convert.ToString(cbNaturalezaOperacion.SelectedValue).Equals(string.Empty))
                    lNaturalezaOperacion.ForeColor = ColorTranslator.FromHtml("#EC2E2E");
                if (tbNotaria.Text.Equals(string.Empty))
                    lNotaria.ForeColor = ColorTranslator.FromHtml("#EC2E2E");
                if (tbTomo.Text.Equals(string.Empty))
                    lTomo.ForeColor = ColorTranslator.FromHtml("#EC2E2E");
                if (cbOficio.Text.Equals(string.Empty) || Convert.ToString(cbOficio.SelectedValue).Equals(string.Empty))
                    lOficio.ForeColor = ColorTranslator.FromHtml("#EC2E2E");
                if (tbNro.Text.Equals(string.Empty))
                    lNro.ForeColor = ColorTranslator.FromHtml("#EC2E2E");

                return true;
            }
            return false;
        }

        private void btnActualizarInfo_Click(object sender, EventArgs e)
        {
            new FormActualizarInfo(this).ShowDialog();
        }

        // FECHA EMISIÓN
        private void dtpEmision_ValueChanged(object sender, EventArgs e)
        {
            dtpEmision.Format = DateTimePickerFormat.Short;
        }

        private void dtpEmision_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dtpEmision.Value = DateTime.Today;
                dtpEmision.Format = DateTimePickerFormat.Custom;
                dtpEmision.CustomFormat = " ";
            }
        }
        // FIN FECHA EMISIÓN

        // FECHA VENCIMIENTO
        private void dtpVencimiento_ValueChanged(object sender, EventArgs e)
        {
            dtpVencimiento.Format = DateTimePickerFormat.Short;
        }

        private void dtpVencimiento_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dtpVencimiento.Value = DateTime.Today;
                dtpVencimiento.Format = DateTimePickerFormat.Custom;
                dtpVencimiento.CustomFormat = " ";
            }
        }
        // FIN FECHA VENCIMIENTO

        // FECHA RECIBIDA
        private void dtpRecibida_ValueChanged(object sender, EventArgs e)
        {
            dtpRecibida.Format = DateTimePickerFormat.Short;
        }

        private void dtpRecibida_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dtpRecibida.Value = DateTime.Today;
                dtpRecibida.Format = DateTimePickerFormat.Custom;
                dtpRecibida.CustomFormat = " ";
            }
        }
        // FIN FECHA RECIBIDA

        // FECHA REGISTRO
        private void dtpFechaRegistro_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaRegistro.Format = DateTimePickerFormat.Short;
        }

        private void dtpFechaRegistro_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dtpFechaRegistro.Value = DateTime.Today;
                dtpFechaRegistro.Format = DateTimePickerFormat.Custom;
                dtpFechaRegistro.CustomFormat = " ";
            }
        }
        // FIN FECHA REGISTRO

        private void tbMonto_TextChanged(object sender, EventArgs e)
        {
            if (tbMonto.Text.Equals(string.Empty))
                tbMonto.Text = "0,00";

            double monto;
            decimal monto_dec;
            try
            {
                monto = Convert.ToDouble(tbMonto.Text);
                monto_dec = (decimal)monto;
                tbMonto.Text = monto_dec.ToString("N2");
            }
            catch (Exception)
            {
                monto = Convert.ToDouble(tbMonto.Text.Replace(".", ""));
                monto_dec = (decimal)monto;
                tbMonto.Text = monto_dec.ToString("N2");
            }
            
        }

        private void tbMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }


        private void tbNroFianza_KeyPress(object sender, KeyPressEventArgs e)
        {
            lNroFianza.ForeColor = Color.Lavender;
        }

        private void cbGarante_KeyPress(object sender, KeyPressEventArgs e)
        {
            lGarante.ForeColor = Color.Lavender;
        }

        private void cbAgente_KeyPress(object sender, KeyPressEventArgs e)
        {
            lAgente.ForeColor = Color.Lavender;
        }

        private void cbContribuyente_KeyPress(object sender, KeyPressEventArgs e)
        {
            lContribuyente.ForeColor = Color.Lavender;
        }

        private void cbNaturalezaOperacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            lNaturalezaOperacion.ForeColor = Color.Lavender;
        }

        private void tbNotaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            lNotaria.ForeColor = Color.Lavender;
        }

        private void tbTomo_KeyPress(object sender, KeyPressEventArgs e)
        {
            lTomo.ForeColor = Color.Lavender;
        }

        private void cbOficio_KeyPress(object sender, KeyPressEventArgs e)
        {
            lOficio.ForeColor = Color.Lavender;
        }

        private void tbNro_TextChanged(object sender, EventArgs e)
        {
            lNro.ForeColor = Color.Lavender;
        }   


        private void cbGarante_SelectedIndexChanged(object sender, EventArgs e)
        {
            lGarante.ForeColor = Color.Lavender;
        }

        private void cbAgente_SelectedIndexChanged(object sender, EventArgs e)
        {
            lAgente.ForeColor = Color.Lavender;
        }

        private void cbContribuyente_SelectedIndexChanged(object sender, EventArgs e)
        {
            lContribuyente.ForeColor = Color.Lavender;
        }

        private void cbNaturalezaOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            lNaturalezaOperacion.ForeColor = Color.Lavender;
        }

        private void cbOficio_SelectedIndexChanged(object sender, EventArgs e)
        {
            lOficio.ForeColor = Color.Lavender;
        }     
    }
}
