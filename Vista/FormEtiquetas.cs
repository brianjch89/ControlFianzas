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
            btnGenerarEtiquetas.Enabled = false;

            dgvEtiquetasFianza.Rows.Clear();
            tbAño.Text = año.ToString();
            ListarNroFianzas();
            cbNroFianza.Text = nFianza;
            tbArchivo.Text = archivo;
            tbNombreConsignatario.Text = contri;
            tbTipoDeFianza.Text = tipoDeFianza;

            dgvEtiquetasFianza.Rows.Add(cbNroFianza.Text, tbAño.Text, tbArchivo.Text, tbNombreConsignatario.Text, tbTipoDeFianza.Text);
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
            cbNroFianza.ValueMember = "Nro de Fianza";
        }

        private void cbNroFianza_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            if (Convert.ToInt32(tbAño.Text) >= 1996 && Convert.ToInt32(tbAño.Text) <= 2005)
                dt = c_Etiquetas.ObtenerFianza("SELECT [Nro de Fianza], [Fecha de Emision], [Nro Archivo], [Fecha de Vencimiento], [Fecha Recibida], Ano, g.Nombre_Garante, c.Nombre_Consignatario, a.Nombre_Agente, tf.DesTipFian AS NaturalezaOperacion, Asunto, Monto, Notaria, Tomo, Nro, [Fecha de Reg], o.NroOficio " +
                                               "FROM ((((([Copia de Fianzas] AS f LEFT JOIN Garantes AS g ON (g.Rif_Garante = f.Garante)) " +
                                               "LEFT JOIN Consignatarios AS c ON (c.Rif_Consignatario = f.[Rif Contribuyente])) " +
                                               "LEFT JOIN Agentes AS a ON (a.Rif_Agentes = f.[Rif Agente])) " +
                                               "LEFT JOIN [Tipo de Fianzas] AS tf ON (tf.Cod_Tf = f.Cod_Tf)) " +
                                               "LEFT JOIN Oficios AS o ON (o.Id = f.NroOficio)) " +
                                               "WHERE [Nro de Fianza] = '" + Convert.ToString(cbNroFianza.SelectedValue) + "' AND Ano = " + Convert.ToInt32(tbAño.Text));

            if (Convert.ToInt32(tbAño.Text) == 2004 || Convert.ToInt32(tbAño.Text) == 2005)
                if (dt.Rows.Count == 0)
                    dt = c_Etiquetas.ObtenerFianza("SELECT [Nro de Fianza], [Fecha de Emision], [Nro Archivo], [Fecha de Vencimiento], [Fecha Recibida], Ano, g.Nombre_Garante, c.Nombre_Consignatario, a.Nombre_Agente, tf.DesTipFian AS NaturalezaOperacion, Asunto, Monto, Notaria, Tomo, Nro, [Fecha de Reg], o.NroOficio " +
                                                   "FROM (((((Fianzas AS f LEFT JOIN Garantes AS g ON (g.Rif_Garante = f.Garante)) " +
                                                   "LEFT JOIN Consignatarios AS c ON (c.Rif_Consignatario = f.[Rif Contribuyente])) " +
                                                   "LEFT JOIN Agentes AS a ON (a.Rif_Agentes = f.[Rif Agente])) " +
                                                   "LEFT JOIN [Tipo de Fianzas] AS tf ON (tf.Cod_Tf = f.Cod_Tf)) " +
                                                   "LEFT JOIN Oficios AS o ON (o.Id = f.NroOficio)) " +
                                                   "WHERE [Nro de Fianza] = '" + Convert.ToString(cbNroFianza.SelectedValue) + "' AND Ano = " + Convert.ToInt32(tbAño.Text));

            if (Convert.ToInt32(tbAño.Text) >= 2006)
                dt = c_Etiquetas.ObtenerFianza("SELECT [Nro de Fianza], [Fecha de Emision], [Nro Archivo], [Fecha de Vencimiento], [Fecha Recibida], Ano, g.Nombre_Garante, c.Nombre_Consignatario, a.Nombre_Agente, tf.DesTipFian AS NaturalezaOperacion, Asunto, Monto, Notaria, Tomo, Nro, [Fecha de Reg], o.NroOficio " +
                                               "FROM (((((Fianzas AS f LEFT JOIN Garantes AS g ON (g.Rif_Garante = f.Garante)) " +
                                               "LEFT JOIN Consignatarios AS c ON (c.Rif_Consignatario = f.[Rif Contribuyente])) " +
                                               "LEFT JOIN Agentes AS a ON (a.Rif_Agentes = f.[Rif Agente])) " +
                                               "LEFT JOIN [Tipo de Fianzas] AS tf ON (tf.Cod_Tf = f.Cod_Tf)) " +
                                               "LEFT JOIN Oficios AS o ON (o.Id = f.NroOficio)) " +
                                               "WHERE [Nro de Fianza] = '" + Convert.ToString(cbNroFianza.SelectedValue) + "' AND Ano = " + Convert.ToInt32(tbAño.Text));

            DataRow dr = dt.NewRow();
            if (dt.Rows.Count > 0)
            {
                dr = dt.Rows[0];

                cbNroFianza.Text = Convert.ToString(cbNroFianza.SelectedValue);
                tbAño.Text = dr["Ano"].ToString();
                tbArchivo.Text = dr["Nro Archivo"].ToString();
                tbNombreConsignatario.Text = dr["Nombre_Consignatario"].ToString();
                tbTipoDeFianza.Text = dr["NaturalezaOperacion"].ToString();
            }
        }

        private void btnAgregarFianza_Click(object sender, EventArgs e)
        {
            btnEliminarFianza.Enabled = true;
            bool ban = true;
            for (int i = 0; i < dgvEtiquetasFianza.Rows.Count; i++)
            {
                DataGridViewRow fila = dgvEtiquetasFianza.Rows[i];
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
                    btnGenerarEtiquetas.Enabled = true;
                    btnAgregarFianza.Enabled = false;
                    dtgFianzas = dgvEtiquetasFianza;
                }
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
                btnGenerarEtiquetas.Enabled = false;
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

        private void tbAño_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbNombreConsignatario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = true;
        }

        private void tbTipoDeFianza_KeyPress(object sender, KeyPressEventArgs e)
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
