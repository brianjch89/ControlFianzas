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
    public partial class FormConsultas : Form
    {
        ControladorConsultas c_Consultas;
        DataRow fi = null;

        public FormConsultas()
        {
            c_Consultas = new ControladorConsultas();
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lFecha.Text = DateTime.Now.ToString("D");
            lHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        public void InformacionFianza(DataRow fianza)
        {
            fi = fianza;
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
        }

        private void btnDatosLiberacion_Click(object sender, EventArgs e)
        {
            FormDatosLiberacionConsulta fdlc = new FormDatosLiberacionConsulta();

            fdlc.SetNroFianza(tbNroFianza.Text);
            fdlc.SetFechaEmision(dtpEmision.Value.Date);
            DataTable f = c_Consultas.ObtenerDatosLiberación(fi["idNroFianza"].ToString(), Convert.ToInt32(tbAño.Text));
            fdlc.DatosRestantesLiberacion(f);

            fdlc.ShowDialog();
        }

        // MÉTODOS PARA QUE NO SE PUEDAN EDITAR LOS CAMPOS DE TEXTO
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

        private void dtpFechaRegistro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = true;
        }

        private void dtpEmision_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
        // FIN

        private void tbMonto_TextChanged(object sender, EventArgs e)
        {
            double monto = Convert.ToDouble(tbMonto.Text);
            decimal monto_dec = (decimal)monto;
            tbMonto.Text = monto_dec.ToString("N2");
        }
    }
}
