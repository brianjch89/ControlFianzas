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
    public partial class FormEtiquetas : Form
    {
        ControladorEtiquetas c_Etiquetas = new ControladorEtiquetas();
        int cont = 1;
        public DataGridView dtgFianzas = null;
        public bool estado = false;
        DataTable fianzas;

        public FormEtiquetas(DataTable f, string nFianza, int año, string archivo, string contri, string tipoDeFianza)
        {
            InitializeComponent();
            fianzas = f;
            btnAgregarFianza.Text = "Agregar (" + cont + ")";
            //btnGenerarEtiquetas.Enabled = false;

            dgvEtiquetasFianza.Rows.Clear();
            tbAño.Text = año.ToString();
            ListarNroFianzas();
            cbNroFianza.Text = nFianza;
            tbArchivo.Text = archivo;
            tbNombreConsignatario.Text = contri;
            tbTipoDeFianza.Text = tipoDeFianza;

            dgvEtiquetasFianza.Rows.Add(cbNroFianza.Text, tbAño.Text, tbArchivo.Text, tbNombreConsignatario.Text, tbTipoDeFianza.Text);
            dtgFianzas = dgvEtiquetasFianza;
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

        private void lInformacionEtiquetas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListarNroFianzas()
        {
            cbNroFianza.DataSource = fianzas;
            cbNroFianza.DisplayMember = "Nro de Fianza";
            cbNroFianza.ValueMember = "idNroFianza";
        }

        private void cbNroFianza_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            ListarNroFianzas();
            long idFianza = Convert.ToInt32(cbNroFianza.SelectedValue);

            foreach (DataRow fila in fianzas.Rows)
            {
                if (fila["idNroFianza"].ToString().Equals(idFianza.ToString()))
                {
                    cbNroFianza.Text = fila["Nro de Fianza"].ToString();
                    tbAño.Text = fila["Ano"].ToString();
                    tbArchivo.Text = fila["Nro Archivo"].ToString();
                    tbNombreConsignatario.Text = fila["Nombre_Consignatario"].ToString();
                    tbTipoDeFianza.Text = fila["NaturalezaOperacion"].ToString();
                }
            }
        }

        private void btnAgregarFianza_Click(object sender, EventArgs e)
        {
            btnEliminarFianza.Enabled = true;
            btnGenerarEtiquetas.Enabled = true;
            bool ban = true;
            foreach (DataGridViewRow fila in dgvEtiquetasFianza.Rows)
            {
                if (fila.Cells[0].Value.ToString().Equals(cbNroFianza.Text))
                {
                    new FormAviso("El número de fianza ya está en la lista. Por favor, verifique los datos.", 545, 223).ShowDialog();
                    ban = false;
                    break;
                }
            }

            if (ban)
            {
                dgvEtiquetasFianza.Rows.Add(cbNroFianza.Text, tbAño.Text, tbArchivo.Text, tbNombreConsignatario.Text, tbTipoDeFianza.Text);
                btnAgregarFianza.Text = "Agregar (" + ++cont + ")";
                if (cont == 3)
                {
                    //btnGenerarEtiquetas.Enabled = true;
                    btnAgregarFianza.Enabled = false;
                    //dtgFianzas = dgvEtiquetasFianza;
                }
                dtgFianzas = dgvEtiquetasFianza;
            }
        }

        private void btnGenerarEtiquetas_Click(object sender, EventArgs e)
        {
            estado = true;
            this.Close();
        }

        private void btnEliminarFianza_Click(object sender, EventArgs e)
        {
            if (cont == 3)
            {
                btnAgregarFianza.Enabled = true;
                //btnGenerarEtiquetas.Enabled = false;
            }

            dgvEtiquetasFianza.Rows.RemoveAt(dgvEtiquetasFianza.CurrentRow.Index);
            btnAgregarFianza.Text = "Agregar (" + --cont + ")";

            if (cont == 0)
            {
                btnEliminarFianza.Enabled = false;
                btnAgregarFianza.Enabled = true;
                btnGenerarEtiquetas.Enabled = false;
            }
        }

        private void BloquearTextField(object sender, KeyPressEventArgs e)
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
            BloquearTextField(sender, e);
        }

        private void tbArchivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            BloquearTextField(sender, e);
        }

        private void tbNombreConsignatario_KeyPress(object sender, KeyPressEventArgs e)
        {
            BloquearTextField(sender, e);
        }

        private void tbTipoDeFianza_KeyPress(object sender, KeyPressEventArgs e)
        {
            BloquearTextField(sender, e);
        }
    }
}
