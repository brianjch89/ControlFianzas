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

namespace Vista
{
    public partial class FormVentanaPrincipal : Form
    {
        FormInicio fi = new FormInicio();
        FormFianzas ff = new FormFianzas();
        FormConsultas fc = new FormConsultas();
        FormLiberacion fl = new FormLiberacion();

        List<Form> f = new List<Form>();

        public FormVentanaPrincipal()
        {
            InitializeComponent();
            f.Add(fi); // FormInicio
            f.Add(ff); // FormFianzas
            f.Add(fc); // FormConsultas
            f.Add(fl); // FormEdicion

            FormNotificaciones fn = new FormNotificaciones();
            DataTable dt = fn.c_Notificaciones.ObtenerFianzasPorVencer(DateTime.Today.Month, DateTime.Today.Year);
            if (dt.Rows.Count > 0) // Si hay fianzas por vencerse dentro de 3 meses...
                btnNotificaciones.BackColor = ColorTranslator.FromHtml("#EC2E2E");
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


        private void FormVentanaPrincipal_Load(object sender, EventArgs e)
        {
            btnInicio_Click(null, e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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



        private void AbrirFormHijo(object FormHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            Form fh = FormHijo as Form; // En esta línea fue creado un formulario con un nombre.
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh; // Establecemos la instancia como contenedor de datos del panel
            fh.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (!fi.Visible)
            {
                AbrirFormHijo(fi);
                OcultarForms(fi);
            }
        }

        private void btnFianzas_Click(object sender, EventArgs e)
        {
            ff = new FormFianzas();
            if (!ff.Visible)
            {
                FormIntroducirAño fia = new FormIntroducirAño();
                fia.ShowDialog();
                if (fia.ban)
                {
                    ff.SetAño(fia.año);
                    ff.ObtenerFianzas(fia.año, 1);
                    ff.SetNumeroArchivo();
                    AbrirFormHijo(ff);
                    OcultarForms(ff);
                }
            }
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            fc = new FormConsultas();
            if (!fc.Visible)
            {
                FormIntroducirNroFianzaAño finfa = new FormIntroducirNroFianzaAño();
                finfa.ShowDialog();
                if (finfa.ban)
                {
                    fc.InformacionFianza(finfa.fi);
                    AbrirFormHijo(fc);
                    OcultarForms(fc);
                }
            }
        }

        // Se cambió el nombre del botón de "Edición" a "Liberación".
        private void btnLiberacion_Click(object sender, EventArgs e)
        {
            if (!fl.Visible)
            {
                fl.CargarDatosPrimeraFianza();
                AbrirFormHijo(fl);
                OcultarForms(fl);
            }
        }

        private void btnActualizarInfo_Click(object sender, EventArgs e)
        {
            if (!fi.Visible)
            {
                AbrirFormHijo(fi);
                OcultarForms(fi);
                new FormActualizarInfo(ff).ShowDialog();
            }
            else
            {
                new FormActualizarInfo(ff).ShowDialog();
                OcultarForms(fi);
            }
        }

        private void btnNotificaciones_Click(object sender, EventArgs e)
        {
            new FormNotificaciones().ShowDialog();
        }

        // Este método cambia a false el valor de la propiedad Visible de los Forms que, con anterioridad, se mostraron al
        // ser invocados con el método Show() y el valor de Visible cambió a true.
        private void OcultarForms(Form f)
        {
            foreach (Form forma in this.f)
                if (forma != f && forma.Visible)
                    forma.Visible = false;
        }

        private void lFormularioFianzas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
