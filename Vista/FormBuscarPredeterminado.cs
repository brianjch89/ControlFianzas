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
    public partial class FormBuscarPredeterminado : Form
    {
        public Boolean ban;
        public DataTable dt;
        int opcion = int.MinValue;

        public FormBuscarPredeterminado(string etiqueta, int opc)
        {
            ban = false;
            opcion = opc;
            InitializeComponent();
            lIngresarInformacion.Text = etiqueta;
            cbIngresarInformacion.Focus();
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

        private void lBuscarPredeterminado_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setListado(DataTable predeterminados)
        {
            cbIngresarInformacion.DataSource = predeterminados;

            if (opcion == 1)
            {
                cbIngresarInformacion.DisplayMember = "Rif_Consignatario";
                cbIngresarInformacion.ValueMember = "Rif_Consignatario";
            }
            else if (opcion == 2)
            {
                cbIngresarInformacion.DisplayMember = "Rif_Agentes";
                cbIngresarInformacion.ValueMember = "Rif_Agentes";
            }
            else if (opcion == 3)
            {
                cbIngresarInformacion.DisplayMember = "Rif_Garante";
                cbIngresarInformacion.ValueMember = "Rif_Garante";
            }
            else if (opcion == 4)
            {
                cbIngresarInformacion.DisplayMember = "DesTipFianza";
                cbIngresarInformacion.ValueMember = "DesTipFianza";
            }
            else if (opcion == 5)
            {
                cbIngresarInformacion.DisplayMember = "NroOficio";
                cbIngresarInformacion.ValueMember = "NroOficio";
            }
            else if (opcion == 6)
            {
                cbIngresarInformacion.DisplayMember = "Nombre";
                cbIngresarInformacion.ValueMember = "Nombre";
            }
            else
            {
                cbIngresarInformacion.DisplayMember = "Descripcion";
                cbIngresarInformacion.ValueMember = "Descripcion";
            }
            cbIngresarInformacion.SelectedIndex = -1;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (opcion == 1) // CONSIGNATARIOS
            {
                if (cbIngresarInformacion.Text != string.Empty)
                {
                    dt = new ControladorActualizarInfo().BuscarPredeterminado("SELECT Rif_Consignatario, Nombre_Consignatario, Siglas, Representante, Dirección, Telefono, email FROM Consignatarios WHERE Rif_Consignatario = '" + cbIngresarInformacion.Text + "'", 1);

                    if (dt.Rows.Count == 0)
                    {
                        new FormAviso("No se encontró el Consignatario.", 298, 100).ShowDialog();
                        cbIngresarInformacion.Focus();
                    }
                    else
                    {
                        ban = true;
                        this.Close();
                    }
                }
                else
                {
                    new FormAviso("Debe ingresar el RIF del Consignatario.", 341, 122).ShowDialog();
                    cbIngresarInformacion.Focus();
                }
            }
            else if (opcion == 2) // AGENTES
            {
                if (cbIngresarInformacion.Text != string.Empty)
                {
                    dt = new ControladorActualizarInfo().BuscarPredeterminado("SELECT Rif_Agentes, Nombre_Agente, Siglas_Agente, Representante, [Domicilio Fiscal], Telefono FROM Agentes WHERE Rif_Agentes = '" + cbIngresarInformacion.Text + "'", 2);

                    if (dt.Rows.Count == 0)
                    {
                        new FormAviso("No se encontró el Agente.", 252, 77).ShowDialog();
                        cbIngresarInformacion.Focus();
                    }
                    else
                    {
                        ban = true;
                        this.Close();
                    }
                }
                else
                {
                    new FormAviso("Debe ingresar el RIF del Agente.", 297, 100).ShowDialog();
                    cbIngresarInformacion.Focus();
                }
            }
            else if (opcion == 3)
            {
                if (cbIngresarInformacion.Text != string.Empty)
                {
                    dt = new ControladorActualizarInfo().BuscarPredeterminado("SELECT Rif_Garante, Nombre_Garante, Siglas, Direccion, Telefono, Nro_Aprobacion, OficioNro, Fecha_Oficio FROM Garantes WHERE Rif_Garante = '" + cbIngresarInformacion.Text + "'", 3);

                    if (dt.Rows.Count == 0)
                    {
                        new FormAviso("No se encontró el Garante.", 255, 79).ShowDialog();
                        cbIngresarInformacion.Focus();
                    }
                    else
                    {
                        ban = true;
                        this.Close();
                    }
                }
                else
                {
                    new FormAviso("Debe ingresar el RIF del Garante.", 304, 103).ShowDialog();
                    cbIngresarInformacion.Focus();
                }
            }
            else if (opcion == 4) // NATURALEZA DE LA OPERACION
            {
                if (cbIngresarInformacion.Text != string.Empty)
                {
                    dt = new ControladorActualizarInfo().BuscarPredeterminado("SELECT * FROM [Tipo de Fianzas] WHERE DesTipFianza = '" + cbIngresarInformacion.Text + "'", 4);

                    if (dt.Rows.Count == 0)
                        new FormAviso("No se encontró la Operacion.", 276, 89).ShowDialog();
                    else
                    {
                        ban = true;
                        this.Close();
                    }
                }
                else
                {
                    new FormAviso("Debe ingresar la descripción de la Operacion.", 404, 153).ShowDialog();
                    cbIngresarInformacion.Focus();
                }
            }
            else if (opcion == 5) // OFICIOS
            {
                if (cbIngresarInformacion.Text != string.Empty)
                {
                    dt = new ControladorActualizarInfo().BuscarPredeterminado("SELECT NroOficio, [Fecha de Oficio], Fecha_Vence, tf.DesTipFian AS TipoDeFianza, c.Nombre_Consignatario " +
                                                                              "FROM ((Oficios AS o LEFT JOIN [Tipo de Fianzas] AS tf ON (o.Cod_Tipo = tf.Cod_Tf)) " +
                                                                              "LEFT JOIN Consignatarios AS c ON (o.Rif = c.Rif_Consignatario)) " +
                                                                              "WHERE NroOficio = '" + cbIngresarInformacion.Text + "'", 5);

                    if (dt.Rows.Count == 0)
                        new FormAviso("No se encontró el Oficio.", 243, 73).ShowDialog();
                    else
                    {
                        ban = true;
                        this.Close();
                    }
                }
                else
                {
                    new FormAviso("Debe ingresar el Número del Oficio.", 328, 115).ShowDialog();
                    cbIngresarInformacion.Focus();
                }
            }
            else if (opcion == 6) // GERENTES
            {
                if (cbIngresarInformacion.Text != string.Empty)
                {
                    dt = new ControladorActualizarInfo().BuscarPredeterminado("SELECT * FROM Gerente WHERE Nombre = '" + cbIngresarInformacion.Text + "'", 6);

                    if (dt.Rows.Count == 0)
                        new FormAviso("No se encontró al Gerente.", 262, 82).ShowDialog();
                    else
                    {
                        ban = true;
                        this.Close();
                    }
                }
                else
                {
                    new FormAviso("Debe ingresar el nombre completo del Gerente.", 416, 159).ShowDialog();
                    cbIngresarInformacion.Focus();
                }
            }
            else // MOTIVOS DE LIBERACIÓN
            {
                if (cbIngresarInformacion.Text != string.Empty)
                {
                    dt = new ControladorActualizarInfo().BuscarPredeterminado("SELECT * FROM Motivos WHERE Descripcion = '" + cbIngresarInformacion.Text + "'", 7);

                    if (dt.Rows.Count == 0)
                        new FormAviso("No se encontró el Motivo de Liberación.", 353, 128).ShowDialog();
                    else
                    {
                        ban = true;
                        this.Close();
                    }
                }
                else
                {
                    new FormAviso("Debe ingresar la descripción del Motivo de Liberación.", 469, 186).ShowDialog();
                    cbIngresarInformacion.Focus();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
