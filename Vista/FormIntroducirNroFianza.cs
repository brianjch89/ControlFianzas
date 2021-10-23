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
    public partial class FormIntroducirNroFianza : Form
    {
        public long idfianza;
        int año;
        public Boolean ban;
        public DataTable fianzas;
        public DataRow fi = null;

        public FormIntroducirNroFianza(int a)
        {
            idfianza = long.MinValue;
            año = a;
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

        public void setListadoFianzas(DataTable fian)
        {
            fianzas = fian;
            cbNroFianza.DataSource = fianzas;
            cbNroFianza.DisplayMember = "Nro de Fianza";
            cbNroFianza.ValueMember = "idNroFianza"; // cbNroFianza.ValueMember = "Nro de Fianza";
            cbNroFianza.SelectedIndex = -1;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cbNroFianza.Text != string.Empty)
            {
                idfianza = Convert.ToInt32(cbNroFianza.SelectedValue);

                foreach (DataRow fila in fianzas.Rows)
                    if (fila["idNroFianza"].ToString().Equals(idfianza.ToString()))
                    {
                        ban = true;
                        fi = fila;
                        this.Close();
                        break;
                    }

                if (fi == null)
                    new FormAviso("No se pudo hallar la fianza.", 262, 82).ShowDialog();




                //if (año >= 0 && año <= 2005)
                //    dt = new ControladorIntroducirNroFianza().ObtenerFianza("SELECT idNroFianza, [Nro de Fianza], [Fecha de Emision], [Nro Archivo], [Fecha de Vencimiento], [Fecha Recibida], Ano, g.Nombre_Garante, c.Nombre_Consignatario, a.Nombre_Agente, tf.DesTipFian AS NaturalezaOperacion, Asunto, Monto, Notaria, Tomo, Nro, [Fecha de Reg], o.NroOficio " +
                //                                                            "FROM ((((([Copia de Fianzas] AS f LEFT JOIN Garantes AS g ON (g.Rif_Garante = f.Garante)) " +
                //                                                            "LEFT JOIN Consignatarios AS c ON (c.Rif_Consignatario = f.[Rif Contribuyente])) " +
                //                                                            "LEFT JOIN Agentes AS a ON (a.Rif_Agentes = f.[Rif Agente])) " +
                //                                                            "LEFT JOIN [Tipo de Fianzas] AS tf ON (tf.Cod_Tf = f.Cod_Tf)) " +
                //                                                            "LEFT JOIN Oficios AS o ON (o.Id = f.NroOficio)) " +
                //                                                            "WHERE idNroFianza = " + idfianza); // "WHERE [Nro de Fianza] = '" + fianza + "' AND Ano = " + año);

                //if (año == 2004 || año == 2005)
                //    if (dt.Rows.Count == 0)
                //        dt = new ControladorIntroducirNroFianza().ObtenerFianza("SELECT idNroFianza, [Nro de Fianza], [Fecha de Emision], [Nro Archivo], [Fecha de Vencimiento], [Fecha Recibida], Ano, g.Nombre_Garante, c.Nombre_Consignatario, a.Nombre_Agente, tf.DesTipFian AS NaturalezaOperacion, Asunto, Monto, Notaria, Tomo, Nro, [Fecha de Reg], o.NroOficio " +
                //                                                                "FROM (((((Fianzas AS f LEFT JOIN Garantes AS g ON (g.Rif_Garante = f.Garante)) " +
                //                                                                "LEFT JOIN Consignatarios AS c ON (c.Rif_Consignatario = f.[Rif Contribuyente])) " +
                //                                                                "LEFT JOIN Agentes AS a ON (a.Rif_Agentes = f.[Rif Agente])) " +
                //                                                                "LEFT JOIN [Tipo de Fianzas] AS tf ON (tf.Cod_Tf = f.Cod_Tf)) " +
                //                                                                "LEFT JOIN Oficios AS o ON (o.Id = f.NroOficio)) " +
                //                                                                "WHERE idNroFianza = " + idfianza); // "WHERE [Nro de Fianza] = '" + fianza + "' AND Ano = " + año);

                //if (año >= 2006)
                //    dt = new ControladorIntroducirNroFianza().ObtenerFianza("SELECT idNroFianza, [Nro de Fianza], [Fecha de Emision], [Nro Archivo], [Fecha de Vencimiento], [Fecha Recibida], Ano, g.Nombre_Garante, c.Nombre_Consignatario, a.Nombre_Agente, tf.DesTipFian AS NaturalezaOperacion, Asunto, Monto, Notaria, Tomo, Nro, [Fecha de Reg], o.NroOficio " +
                //                                                            "FROM (((((Fianzas AS f LEFT JOIN Garantes AS g ON (g.Rif_Garante = f.Garante)) " +
                //                                                            "LEFT JOIN Consignatarios AS c ON (c.Rif_Consignatario = f.[Rif Contribuyente])) " +
                //                                                            "LEFT JOIN Agentes AS a ON (a.Rif_Agentes = f.[Rif Agente])) " +
                //                                                            "LEFT JOIN [Tipo de Fianzas] AS tf ON (tf.Cod_Tf = f.Cod_Tf)) " +
                //                                                            "LEFT JOIN Oficios AS o ON (o.Id = f.NroOficio)) " +
                //                                                            "WHERE idNroFianza = " + idfianza); // "WHERE [Nro de Fianza] = '" + fianza + "' AND Ano = " + año);

                //if (dt.Rows.Count == 0)
                //    new FormAviso("No se pudo hallar la fianza.", 262, 82).ShowDialog();
                //else
                //{
                //    ban = true;
                //    fi = dt.Rows[0];
                //    this.Close();
                //}
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
