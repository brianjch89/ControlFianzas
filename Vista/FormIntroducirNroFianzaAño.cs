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
    public partial class FormIntroducirNroFianzaAño : Form
    {
        private long idfianza;
        public string añoFianzas = string.Empty;
        public int año, cont = 0;
        public Boolean ban;
        public DataTable dt = new DataTable();
        public DataRow fi = null;

        public FormIntroducirNroFianzaAño()
        {
            idfianza = long.MinValue;
            ban = false;
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

        private void lConsultaConfrontacion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cbNroFianza.Text != string.Empty && tbAño.Text != string.Empty)
            {
                if (Convert.ToInt32(tbAño.Text) >= 0)
                {
                    idfianza = Convert.ToInt32(cbNroFianza.SelectedValue);
                    año = Convert.ToInt32(tbAño.Text);
                    if (año >= 0 && año <= 2005)
                        dt = new ControladorIntroducirNroFianza().ObtenerFianza("SELECT idNroFianza, [Nro de Fianza], [Fecha de Emision], [Nro Archivo], [Fecha de Vencimiento], [Fecha Recibida], Ano, g.Nombre_Garante, c.Nombre_Consignatario, a.Nombre_Agente, tf.DesTipFian AS NaturalezaOperacion, Asunto, Monto, Notaria, Tomo, Nro, [Fecha de Reg], o.NroOficio " +
                                                                                "FROM ((((([Copia de Fianzas] AS f LEFT JOIN Garantes AS g ON (g.Rif_Garante = f.Garante)) " +
                                                                                "LEFT JOIN Consignatarios AS c ON (c.Rif_Consignatario = f.[Rif Contribuyente])) " +
                                                                                "LEFT JOIN Agentes AS a ON (a.Rif_Agentes = f.[Rif Agente])) " +
                                                                                "LEFT JOIN [Tipo de Fianzas] AS tf ON (tf.Cod_Tf = f.Cod_Tf)) " +
                                                                                "LEFT JOIN Oficios AS o ON (o.Id = f.NroOficio)) " +
                                                                                "WHERE idNroFianza = " + idfianza); //"WHERE [Nro de Fianza] = '" + fianza + "' AND Ano = " + año);

                    if (año == 2004 || año == 2005)
                        if (dt.Rows.Count == 0)
                            dt = new ControladorIntroducirNroFianza().ObtenerFianza("SELECT idNroFianza, [Nro de Fianza], [Fecha de Emision], [Nro Archivo], [Fecha de Vencimiento], [Fecha Recibida], Ano, g.Nombre_Garante, c.Nombre_Consignatario, a.Nombre_Agente, tf.DesTipFian AS NaturalezaOperacion, Asunto, Monto, Notaria, Tomo, Nro, [Fecha de Reg], o.NroOficio " +
                                                                                    "FROM (((((Fianzas AS f LEFT JOIN Garantes AS g ON (g.Rif_Garante = f.Garante)) " +
                                                                                    "LEFT JOIN Consignatarios AS c ON (c.Rif_Consignatario = f.[Rif Contribuyente])) " +
                                                                                    "LEFT JOIN Agentes AS a ON (a.Rif_Agentes = f.[Rif Agente])) " +
                                                                                    "LEFT JOIN [Tipo de Fianzas] AS tf ON (tf.Cod_Tf = f.Cod_Tf)) " +
                                                                                    "LEFT JOIN Oficios AS o ON (o.Id = f.NroOficio)) " +
                                                                                    "WHERE idNroFianza = " + idfianza); //"WHERE [Nro de Fianza] = '" + fianza + "' AND Ano = " + año);

                    if (año >= 2006)
                        dt = new ControladorIntroducirNroFianza().ObtenerFianza("SELECT idNroFianza, [Nro de Fianza], [Fecha de Emision], [Nro Archivo], [Fecha de Vencimiento], [Fecha Recibida], Ano, g.Nombre_Garante, c.Nombre_Consignatario, a.Nombre_Agente, tf.DesTipFian AS NaturalezaOperacion, Asunto, Monto, Notaria, Tomo, Nro, [Fecha de Reg], o.NroOficio " +
                                                                                "FROM (((((Fianzas AS f LEFT JOIN Garantes AS g ON (g.Rif_Garante = f.Garante)) " +
                                                                                "LEFT JOIN Consignatarios AS c ON (c.Rif_Consignatario = f.[Rif Contribuyente])) " +
                                                                                "LEFT JOIN Agentes AS a ON (a.Rif_Agentes = f.[Rif Agente])) " +
                                                                                "LEFT JOIN [Tipo de Fianzas] AS tf ON (tf.Cod_Tf = f.Cod_Tf)) " +
                                                                                "LEFT JOIN Oficios AS o ON (o.Id = f.NroOficio)) " +
                                                                                "WHERE idNroFianza = " + idfianza); //"WHERE [Nro de Fianza] = '" + fianza + "' AND Ano = " + año);

                    if (dt.Rows.Count == 0)
                        new FormAviso("No se pudo hallar la fianza.", 262, 82).ShowDialog();
                    else
                    {
                        ban = true;
                        fi = dt.Rows[0];
                        this.Close();
                    }
                }
                else
                    new FormAviso("Ingrese un año válido", 210, 56).ShowDialog();
            }
            else
                new FormAviso("Debe ingresar el número de fianza y el año.", 380, 141).ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setListadoFianzas(DataTable fianzas)
        {
            cbNroFianza.DataSource = fianzas;
            cbNroFianza.DisplayMember = "Nro de Fianza";
            cbNroFianza.ValueMember = "idNroFianza";
            cbNroFianza.SelectedIndex = -1;
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

        private void tbAño_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbAño.Text.Length == 4)
            {
                cbNroFianza.Enabled = true;
                setListadoFianzas(new ControladorConsultas().ObtenerCantidadFianzas(Convert.ToInt32(tbAño.Text)));
                lAñoValido.Visible = false;
                cbNroFianza.Focus();
            }
            else if (tbAño.Text.Length < 4)
            {
                cbNroFianza.SelectedIndex = -1;
                cbNroFianza.Enabled = false;
                lAñoValido.Visible = true;
            }
        }
    }
}
