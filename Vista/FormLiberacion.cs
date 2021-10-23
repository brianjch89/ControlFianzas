using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Controlador;

namespace Vista
{
    public partial class FormLiberacion : Form
    {
        DataTable fianzas;
        ControladorLiberacion c_Liberacion;
        int cont;

        public FormLiberacion()
        {
            InitializeComponent();
            c_Liberacion = new ControladorLiberacion();
            cont = 0;
        }

        public void CargarDatosPrimeraFianza()
        {
            fianzas = c_Liberacion.ObtenerFianzas();
            ObtenerInformacionFianza(fianzas.Rows[cont]);
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            cont = 0;
            ObtenerInformacionFianza(fianzas.Rows[cont]);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            cont = fianzas.Rows.Count - 1;
            ObtenerInformacionFianza(fianzas.Rows[cont]);
        }

        private void bAnteriorEdicion_Click(object sender, EventArgs e)
        {
            cont--;
            if (cont >= 0)
                ObtenerInformacionFianza(fianzas.Rows[cont]);
            else
                cont++;
        }

        private void btnSiguienteEdicion_Click(object sender, EventArgs e)
        {
            cont++;
            if (cont < fianzas.Rows.Count)
                ObtenerInformacionFianza(fianzas.Rows[cont]);
            else
                cont--;
        }

        private void ObtenerInformacionFianza(DataRow fianza)
        {
            tbNroFianza.Text = fianza["Nro de Fianza"].ToString();
            cbGarante.Text = fianza["Nombre_Garante"].ToString();
            tbMonto.Text = fianza["Monto"].ToString();
            tbAño.Text = fianza["Ano"].ToString();
            cbAgente.Text = fianza["Nombre_Agente"].ToString();
            cbContribuyente.Text = fianza["Nombre_Consignatario"].ToString();
            cbNaturalezaOperacion.Text = fianza["NaturalezaOperacion"].ToString();

            if (Convert.ToDateTime(fianza["Fecha de Emision"].ToString()) == DateTime.MinValue)
            {
                dtpEmision.Value = DateTimePicker.MinimumDateTime;
                dtpEmision.Format = DateTimePickerFormat.Custom;
                dtpEmision.CustomFormat = " ";
            }
            else
            {
                dtpEmision.Value = Convert.ToDateTime(fianza["Fecha de Emision"].ToString());
                dtpEmision.Format = DateTimePickerFormat.Short;
            }

            if (Convert.ToDateTime(fianza["Fecha de Vencimiento"].ToString()) == DateTime.MinValue)
            {
                dtpVencimiento.Value = DateTimePicker.MinimumDateTime;
                dtpVencimiento.Format = DateTimePickerFormat.Custom;
                dtpVencimiento.CustomFormat = " ";
            }
            else
            {
                dtpVencimiento.Value = Convert.ToDateTime(fianza["Fecha de Vencimiento"].ToString());
                dtpVencimiento.Format = DateTimePickerFormat.Short;
            }

            if (Convert.ToDateTime(fianza["Fecha Recibida"].ToString()) == DateTime.MinValue)
            {
                dtpRecibida.Value = DateTimePicker.MinimumDateTime;
                dtpRecibida.Format = DateTimePickerFormat.Custom;
                dtpRecibida.CustomFormat = " ";
            }
            else
            {
                dtpRecibida.Value = Convert.ToDateTime(fianza["Fecha Recibida"].ToString());
                dtpRecibida.Format = DateTimePickerFormat.Short;
            }

            tbArchivo.Text = fianza["Nro Archivo"].ToString();
            tbAsunto.Text = fianza["Asunto"].ToString();
            tbNotaria.Text = fianza["Notaria"].ToString();
            tbTomo.Text = fianza["Tomo"].ToString();
            cbOficio.Text = fianza["NroOficio"].ToString();
            tbNro.Text = fianza["Nro"].ToString();

            if (Convert.ToDateTime(fianza["Fecha de Reg"].ToString()) == DateTime.MinValue)
            {
                dtpFechaRegistro.Value = DateTimePicker.MinimumDateTime;
                dtpFechaRegistro.Format = DateTimePickerFormat.Custom;
                dtpFechaRegistro.CustomFormat = " ";
            }
            else
            {
                dtpFechaRegistro.Value = Convert.ToDateTime(fianza["Fecha de Reg"].ToString());
                dtpFechaRegistro.Format = DateTimePickerFormat.Short;
            }

            lFianzasAlmacenadas.Text = "Fianza " + (cont + 1) + " de " + fianzas.Rows.Count;
        }

        private void LlenarCampos(DataRow fi)
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
                dtpEmision.Value = DateTimePicker.MinimumDateTime;
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
                dtpVencimiento.Value = DateTimePicker.MinimumDateTime;
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
                dtpRecibida.Value = DateTimePicker.MinimumDateTime;
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
            cbOficio.Text = fi["NroOficio"].ToString();
            tbNro.Text = fi["Nro"].ToString();

            if (Convert.ToDateTime(fi["Fecha de Reg"].ToString()) == DateTime.MinValue)
            {
                dtpFechaRegistro.Value = DateTimePicker.MinimumDateTime;
                dtpFechaRegistro.Format = DateTimePickerFormat.Custom;
                dtpFechaRegistro.CustomFormat = " ";
            }
            else
            {
                dtpFechaRegistro.Value = Convert.ToDateTime(fi["Fecha de Reg"].ToString());
                dtpFechaRegistro.Format = DateTimePickerFormat.Short;
            }

            lFianzasAlmacenadas.Text = "Fianza " + (cont + 1) + " de " + fianzas.Rows.Count;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lFechaEdicion.Text = DateTime.Now.ToString("D");
            lHoraEdicion.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnBuscarLiberacion_Click(object sender, EventArgs e)
        {
            FormIntroducirNroFianzaAño finfa = new FormIntroducirNroFianzaAño();
            finfa.ShowDialog();
            if (finfa.ban)
            {
                DataTable dt = finfa.dt;

                if (dt.Rows.Count > 0)
                {
                    DataRow filaEncontrada = dt.Rows[0];
                    LlenarCampos(filaEncontrada);

                    int i = 0;
                    foreach (DataRow fila in fianzas.Rows)
                    {
                        if (fila["Nro de Fianza"].ToString().Equals(filaEncontrada["Nro de Fianza"].ToString()))
                            break;
                        i++;
                    }

                    lFianzasAlmacenadas.Text = "Fianza " + (i + 1) + " de " + fianzas.Rows.Count;
                    cont = i;
                }
                else
                    new FormAviso("El número de fianza buscado no existe o no pertenece al año ingresado anteriormente.", 450, 200).ShowDialog();
            }
        }

        private void btnDatosLiberacion_Click(object sender, EventArgs e)
        {
            FormDatosLiberacion fdl = new FormDatosLiberacion(fianzas.Rows[cont]["idNroFianza"].ToString());

            fdl.SetNroFianza(tbNroFianza.Text);
            fdl.SetFechaEmision(dtpEmision.Value.Date);
            DataTable f = c_Liberacion.ObtenerDatosLiberación(fianzas.Rows[cont]["idNroFianza"].ToString(), Convert.ToInt32(tbAño.Text)); // tbNroFianza.Text, Convert.ToInt32(tbAño.Text)
            fdl.DatosRestantesLiberacion(f, Convert.ToInt32(tbAño.Text));

            fdl.ShowDialog();
        }

        private void tbMonto_TextChanged(object sender, EventArgs e)
        {
            double monto = Convert.ToDouble(tbMonto.Text);
            decimal monto_dec = (decimal)monto;
            tbMonto.Text = monto_dec.ToString("N2");
        }

        // MÉTODOS PARA IMPEDIR QUE EL USUARIO ESCRIBA SOBRE LOS CONTROLES DE LOS MISMOS
        private void tbNroFianza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = true;
        }

        private void cbGarante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = true;
        }

        private void tbMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = true;
        }

        private void tbAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = true;
        }

        private void cbAgente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = true;
        }

        private void cbContribuyente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = true;
        }

        private void cbNaturalezaOperacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = true;
        }

        private void dtpEmision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = true;
        }

        private void dtpVencimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = true;
        }

        private void dtpRecibida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = true;
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

        private void tbAsunto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = true;
        }

        private void cbOficio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = true;
        }

        private void tbNro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = true;
        }

        private void tbNotaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = true;
        }

        private void tbTomo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = true;
        }

        private void dtpFechaRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = true;
        }
        // FIN MÉTODOS PARA IMPEDIR QUE EL USUARIO ESCRIBA SOBRE LOS CONTROLES DE LOS MISMOS
    }
}