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
    public partial class FormDatosLiberacion : Form
    {
        ControladorDatosLiberacion c_DatosLiberacion = new ControladorDatosLiberacion();
        int año;
        string idFianza;

        public FormDatosLiberacion(string idF)
        {
            InitializeComponent();
            ListarMotivosLiberacion();
            idFianza = idF;
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

        private void btnCancelar_Click(object sender, EventArgs e)
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

        public void DatosRestantesLiberacion(DataTable fi, int año)
        {
            this.año = año;
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

        public void ListarMotivosLiberacion()
        {
            DataTable mo = c_DatosLiberacion.ObtenerInfo("SELECT Descripcion FROM Motivos", "Descripcion");

            foreach (DataRow fila in mo.Rows)
                cbMotivoLibe.Items.Add(fila["Descripcion"].ToString());
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int filasAfectadas = int.MinValue;
            if ((dtpFechaLiberacion.Format == DateTimePickerFormat.Custom) || (cbMotivoLibe.Text.Equals(string.Empty)))
                new FormAviso("Debe ingresar la fecha de liberación y el motivo de la misma.", 510, 206).ShowDialog();
            else
            {
                if (año >= 0 && año <= 2005)
                {
                    // Si la fianza aún no se ha liberado...
                    if (c_DatosLiberacion.Cadena("SELECT [Fecha Liberacion] FROM [Copia de Fianzas] WHERE idNroFianza = " + Convert.ToInt32(idFianza), "Fecha Liberacion").Equals(string.Empty))
                    {
                        // Primero obtengo el código del motivo de liberación de la fianza.
                        int codigo = Convert.ToInt32(c_DatosLiberacion.Cadena("SELECT Cod_Lib FROM Motivos WHERE Descripcion = '" + cbMotivoLibe.Text + "'", "Cod_Lib"));

                        // Luego almaceno la información de la liberación de la fianza.
                        filasAfectadas = c_DatosLiberacion.LiberarFianza("UPDATE [Copia de Fianzas] SET [Fecha Liberacion] = '" + dtpFechaLiberacion.Value.Date + "', Cod_Lib = " + codigo + " WHERE idNroFianza = " + Convert.ToInt32(idFianza));
                        if (filasAfectadas > 0)
                            // Por último, se avisa al usuario que la fianza ha sido liberada.
                            new FormAviso("La fianza se ha liberado exitosamente.", 336, 119).ShowDialog();
                    }
                    else
                    {
                        // Primero obtengo el código del motivo de liberación de la fianza.
                        int codigo = Convert.ToInt32(c_DatosLiberacion.Cadena("SELECT Cod_Lib FROM Motivos WHERE Descripcion = '" + cbMotivoLibe.Text + "'", "Cod_Lib"));

                        // Luego almaceno la información de la liberación de la fianza.
                        filasAfectadas = c_DatosLiberacion.LiberarFianza("UPDATE [Copia de Fianzas] SET [Fecha Liberacion] = '" + dtpFechaLiberacion.Value.Date + "', Cod_Lib = " + codigo + " WHERE idNroFianza = " + Convert.ToInt32(idFianza));
                        if (filasAfectadas > 0)
                            // Por último, se avisa al usuario que ha sido actualizado los datos de liberación de la fianza.
                            new FormAviso("Los datos de liberación han sido actualizados.", 390, 146).ShowDialog();
                    }
                }

                if (año == 2004 || año == 2005)
                {
                    if (filasAfectadas == 0)
                    {
                        // Si la fianza aún no se ha liberado...
                        if (c_DatosLiberacion.Cadena("SELECT [Fecha Liberacion] FROM Fianzas WHERE idNroFianza = " + Convert.ToInt32(idFianza), "Fecha Liberacion").Equals(string.Empty))
                        {
                            // Primero obtengo el código del motivo de liberación de la fianza.
                            int codigo = Convert.ToInt32(c_DatosLiberacion.Cadena("SELECT Cod_Lib FROM Motivos WHERE Descripcion = '" + cbMotivoLibe.Text + "'", "Cod_Lib"));

                            // Luego almaceno la información de la liberación de la fianza.
                            filasAfectadas = c_DatosLiberacion.LiberarFianza("UPDATE Fianzas SET [Fecha Liberacion] = '" + dtpFechaLiberacion.Value.Date + "', Cod_Lib = " + codigo + " WHERE idNroFianza = " + Convert.ToInt32(idFianza));
                            if (filasAfectadas > 0)
                                // Por último, se avisa al usuario que la fianza ha sido liberada.
                                new FormAviso("La fianza se ha liberado exitosamente.", 336, 119).ShowDialog();
                        }
                        else
                        {
                            // Primero obtengo el código del motivo de liberación de la fianza.
                            int codigo = Convert.ToInt32(c_DatosLiberacion.Cadena("SELECT Cod_Lib FROM Motivos WHERE Descripcion = '" + cbMotivoLibe.Text + "'", "Cod_Lib"));

                            //Luego almaceno la información de la liberación de la fianza.
                            filasAfectadas = c_DatosLiberacion.LiberarFianza("UPDATE Fianzas SET [Fecha Liberacion] = '" + dtpFechaLiberacion.Value.Date + "', Cod_Lib = " + codigo + " WHERE idNroFianza = " + Convert.ToInt32(idFianza));
                            if (filasAfectadas > 0)
                                // Por último, se avisa al usuario que ha sido actualizado los datos de liberación de la fianza.
                                new FormAviso("Los datos de liberación han sido actualizados.", 390, 146).ShowDialog();
                        }
                    }
                }

                if (año >= 2006)
                {
                    // Si la fianza aún no se ha liberado...
                    if (c_DatosLiberacion.Cadena("SELECT [Fecha Liberacion] FROM Fianzas WHERE idNroFianza = " + Convert.ToInt32(idFianza), "Fecha Liberacion").Equals(string.Empty)) //dtpFechaLiberacion.Value.ToString().Equals(string.Empty)
                    {
                        // Primero obtengo el código del motivo de liberación de la fianza.
                        int codigo = Convert.ToInt32(c_DatosLiberacion.Cadena("SELECT Cod_Lib FROM Motivos WHERE Descripcion = '" + cbMotivoLibe.Text + "'", "Cod_Lib"));

                        //Luego almaceno la información de la liberación de la fianza.
                        filasAfectadas = c_DatosLiberacion.LiberarFianza("UPDATE Fianzas SET [Fecha Liberacion] = '" + dtpFechaLiberacion.Value.Date + "', Cod_Lib = " + codigo + " WHERE idNroFianza = " + Convert.ToInt32(idFianza));
                        if (filasAfectadas > 0)
                            // Por último, se avisa al usuario que la fianza ha sido liberada.
                            new FormAviso("La fianza se ha liberado exitosamente.", 336, 119).ShowDialog();
                    }
                    else
                    {
                        // Primero obtengo el código del motivo de liberación de la fianza.
                        int codigo = Convert.ToInt32(c_DatosLiberacion.Cadena("SELECT Cod_Lib FROM Motivos WHERE Descripcion = '" + cbMotivoLibe.Text + "'", "Cod_Lib"));

                        // Luego almaceno la información de la liberación de la fianza.
                        filasAfectadas = c_DatosLiberacion.LiberarFianza("UPDATE Fianzas SET [Fecha Liberacion] = '" + dtpFechaLiberacion.Value.Date + "', Cod_Lib = " + codigo + " WHERE idNroFianza = " + Convert.ToInt32(idFianza));
                        if (filasAfectadas > 0)
                            // Por último, se avisa al usuario que ha sido actualizado los datos de liberación de la fianza.
                            new FormAviso("Los datos de liberación han sido actualizados.", 390, 146).ShowDialog();
                    }
                }
            }
        }

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
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void dtpFechaEmision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
