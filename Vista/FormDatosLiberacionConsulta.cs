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
    public partial class FormDatosLiberacionConsulta : Form
    {
        ControladorDatosLiberacion c_DatosLiberacion = new ControladorDatosLiberacion();

        public FormDatosLiberacionConsulta()
        {
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

        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void lDatosContratoFianza_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetNroFianza(string NroFianza)
        {
            tbNroFianza.Text = NroFianza;
        }

        public void SetFechaEmision(DateTime FechaEmision)
        {
            dtpFechaEmision.Value = FechaEmision;
        }

        public void DatosRestantesLiberacion(DataTable fi)
        {
            DataRow f = fi.Rows[0];

            if (Convert.ToDateTime(f["Fecha Liberacion"].ToString()) == DateTime.MinValue)
            {
                dtpFechaLiberacion.Value = DateTime.Today;
                dtpFechaLiberacion.Format = DateTimePickerFormat.Custom;
                dtpFechaLiberacion.CustomFormat = " ";
            }
            else
            {
                dtpFechaLiberacion.Value = Convert.ToDateTime(f["Fecha Liberacion"].ToString()).Date;
                DataTable desc = c_DatosLiberacion.ObtenerInfo("SELECT Descripcion FROM Motivos WHERE Cod_Lib = " + Convert.ToByte(f["Cod_Lib"].ToString()), "Descripcion");
                f = desc.Rows[0];
                cbMotivoLibe.Text = f["Descripcion"].ToString();
            }
        }

        // FECHA EMISIÓN
        private void dtpFechaEmision_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaEmision.Format = DateTimePickerFormat.Short;
        }

        private void dtpFechaEmision_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dtpFechaEmision.Value = DateTime.Today;
                dtpFechaEmision.Format = DateTimePickerFormat.Custom;
                dtpFechaEmision.CustomFormat = " ";
            }
        }
        // FIN FECHA EMISIÓN

        private void dtpFechaLiberacion_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaLiberacion.Format = DateTimePickerFormat.Short;
        }

        private void dtpFechaLiberacion_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dtpFechaLiberacion.Value = DateTime.Today;
                dtpFechaLiberacion.Format = DateTimePickerFormat.Custom;
                dtpFechaLiberacion.CustomFormat = " ";
            }
        }

        private void tbNroFianza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = true;
        }
    }
}
