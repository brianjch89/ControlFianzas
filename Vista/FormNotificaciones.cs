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

using System.Globalization;

using Controlador;

namespace Vista
{
    public partial class FormNotificaciones : Form
    {
        public ControladorNotificaciones c_Notificaciones = new ControladorNotificaciones();
        String[] meses;
        int porVencerse = int.MinValue;

        public FormNotificaciones()
        {
            InitializeComponent();
        }

        private void FormNotificaciones_Load(object sender, EventArgs e)
        {
            ListarMes();
            ObtenerFianzasPorVencer(DateTime.Today.Month);
            cbMes.SelectedValue = DateTime.Today.Month;
        }

        private void ListarMes()
        {
            DataTable Meses = new DataTable();
            Meses.Columns.Add("NumeroMes");
            Meses.Columns.Add("NombreMes");

            meses = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;

            DataRow mes = null;
            for (int i = 0; i < 12; i++)
            {
                mes = Meses.NewRow();
                mes["NumeroMes"] = (i + 1);
                mes["NombreMes"] = meses[i];
                Meses.Rows.Add(mes);
            }

            cbMes.DataSource = Meses;
            cbMes.DisplayMember = "NombreMes";
            cbMes.ValueMember = "NumeroMes";
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

        private void lModuloReportes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int CalcularFianzasPorVencerse(DataTable f, int mes, int op)
        {
            DataRow fi = f.NewRow();
            int hoy = DateTime.Today.Day, porVencerse = f.Rows.Count;
            for (int i = 0; i < f.Rows.Count; i++)
            {
                fi = f.Rows[i];
                if (op == 1)
                    dgvFianzasPorVencer.Rows.Add(fi["Nro de Fianza"].ToString(), fi["Nro Archivo"].ToString(), Convert.ToDateTime(fi["Fecha de Vencimiento"].ToString()).ToShortDateString(), fi["Ano"].ToString(), fi["Nombre_Garante"].ToString(), fi["Nombre_Agente"].ToString());

                if ((DateTime.Today.Month - mes) >= 4)
                {
                    if (op == 1)
                        dgvFianzasPorVencer.Rows[i].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F0431E"); // Rojo
                    porVencerse--;
                }
                else if ((DateTime.Today.Month - mes) == 3)
                {
                    if (Convert.ToDateTime(fi["Fecha de Vencimiento"].ToString()).Day <= hoy)
                    {
                        if (op == 1)
                            dgvFianzasPorVencer.Rows[i].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#F0431E"); // Rojo
                        porVencerse--;
                        if (porVencerse == 0 && op == 1)
                        {
                            lFianzasVencidas.Visible = true;
                            //vencidas = f.Rows.Count;
                        }
                    }
                }

                if (mes == 11 && op == 0) // Cuando el mes seleccionado es Enero
                {
                    if ((Convert.ToInt32(Convert.ToString(cbMes.SelectedValue)) + 1) == DateTime.Today.Month)
                    {
                        if (Convert.ToDateTime(fi["Fecha de Vencimiento"].ToString()).Day <= hoy)
                            porVencerse--;
                    }
                    else if ((Convert.ToInt32(Convert.ToString(cbMes.SelectedValue)) + 1) < DateTime.Today.Month)
                        porVencerse--;
                }

                if (mes == 12 && op == 0) // Cuando el mes seleccionado es Febrero
                {
                    if ((Convert.ToInt32(Convert.ToString(cbMes.SelectedValue)) + 1) == DateTime.Today.Month)
                    {
                        if (Convert.ToDateTime(fi["Fecha de Vencimiento"].ToString()).Day <= hoy)
                            porVencerse--;
                    }
                    else if ((Convert.ToInt32(Convert.ToString(cbMes.SelectedValue)) + 1) < DateTime.Today.Month)
                        porVencerse--;
                }
            }
            return porVencerse;
        }

        private void ObtenerFianzasPorVencer(int mes)
        {
            DataTable f = c_Notificaciones.ObtenerFianzasPorVencer(mes); // Obtengo todas las fianzas que se van a vencer dentro de 3 meses.
            if ((DateTime.Today.Month - mes) >= 4)
                lFianzasVencidas.Visible = true;
            else
                lFianzasVencidas.Visible = false;

            dgvFianzasPorVencer.Rows.Clear();
            porVencerse = CalcularFianzasPorVencerse(f, mes, 1);

            if (mes < 10)
            {
                lFianzasPorVencer.Text = "Fianzas por vencerse en " + meses[mes + 2] + " de " + DateTime.Today.Year + ":\n" + porVencerse + " fianzas";
                lCantidadFianzasVencidas.Text = "Fianzas vencidas en " + meses[mes + 2] + " de " + DateTime.Today.Year + ":\n" + (f.Rows.Count - porVencerse) + " fianzas";
            }

            else if (mes >= 10)
            {
                lFianzasPorVencer.Text = "Fianzas por vencerse en " + meses[mes - 10] + " de " + (DateTime.Today.Year + 1) + ":\n" + porVencerse + " fianzas";
                lCantidadFianzasVencidas.Text = "Fianzas vencidas en " + meses[mes - 10] + " de " + (DateTime.Today.Year + 1) + ":\n" + (f.Rows.Count - porVencerse) + " fianzas";
            }
            dgvFianzasPorVencer.ClearSelection();
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(cbMes.SelectedValue) != "System.Data.DataRowView")
                ObtenerFianzasPorVencer(Convert.ToInt32(Convert.ToString(cbMes.SelectedValue)));
            dgvFianzasPorVencer.Focus();
        }

        private void btnHistograma_Click(object sender, EventArgs e)
        {
            FormHistograma fh = new FormHistograma();
            int mes = Convert.ToInt32(Convert.ToString(cbMes.SelectedValue));
            string mes1 = string.Empty, mes2 = string.Empty, mes3 = string.Empty;
            if (mes >= 10)
            {
                if (mes == 10)
                {
                    mes2 = meses[mes + 1];
                    mes3 = meses[mes - 10];
                }
                else if (mes == 12)
                    mes1 = meses[mes - 12];
                if (mes == 10 || mes == 11)
                    mes1 = meses[mes];
                if (mes == 11 || mes == 12)
                {
                    mes2 = meses[mes - 11];
                    mes3 = meses[mes - 10];
                }
            }
            else
            {
                mes1 = meses[mes];
                mes2 = meses[mes + 1];
                mes3 = meses[mes + 2];
            }

            if (mes >= 3)
                fh.CrearHistograma(mes1, mes2, mes3, CalcularFianzasPorVencerse(c_Notificaciones.ObtenerFianzasPorVencer(mes - 2), (mes - 2), 0), CalcularFianzasPorVencerse(c_Notificaciones.ObtenerFianzasPorVencer(mes - 1), (mes - 1), 0), porVencerse);
            else if (mes == 1)
                fh.CrearHistograma(mes1, mes2, mes3, CalcularFianzasPorVencerse(c_Notificaciones.ObtenerFianzasPorVencer(11), 11, 0), CalcularFianzasPorVencerse(c_Notificaciones.ObtenerFianzasPorVencer(12), 12, 0), porVencerse);
            else if (mes == 2)
                fh.CrearHistograma(mes1, mes2, mes3, CalcularFianzasPorVencerse(c_Notificaciones.ObtenerFianzasPorVencer(12), 12, 0), CalcularFianzasPorVencerse(c_Notificaciones.ObtenerFianzasPorVencer(1), 1, 0), porVencerse);
            fh.ShowDialog();
        }
    }
}
