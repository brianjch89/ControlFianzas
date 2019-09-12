using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lHorainicio.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lFechaInicio.Text = DateTime.Now.ToString("D");
        }

        public void ColorEntrada()
        {
            this.BackColor = Color.FromArgb(49, 50, 82); // 49; 66; 82
        }

        public void ColorSalida()
        {
            this.BackColor = Color.FromArgb(49, 66, 82); // 26, 32, 40
        }

        private void lHorainicio_MouseEnter(object sender, EventArgs e)
        {
            ColorEntrada();
        }

        private void lHorainicio_MouseLeave(object sender, EventArgs e)
        {
            ColorSalida();
        }

        private void lFechaInicio_MouseEnter(object sender, EventArgs e)
        {
            ColorEntrada();
        }

        private void lFechaInicio_MouseLeave(object sender, EventArgs e)
        {
            ColorSalida();
        }

        private void pbSENIAT_MouseEnter(object sender, EventArgs e)
        {
            ColorEntrada();
        }

        private void pbSENIAT_MouseLeave(object sender, EventArgs e)
        {
            ColorSalida();
        }
    }
}
