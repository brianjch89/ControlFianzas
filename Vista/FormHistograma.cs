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
    public partial class FormHistograma : Form
    {
        public FormHistograma()
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

        public void CrearHistograma(string mes1, string mes2, string mes3, int porVencerseMes1, int porVencerseMes2, int porVencerseMes3)
        {
            chart1.Series["Series1"].LegendText = "Fianzas por vencerse";

            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add(mes1, porVencerseMes1);
            dic.Add(mes2, porVencerseMes2);
            dic.Add(mes3, porVencerseMes3);

            foreach (KeyValuePair<string, int> d in dic)
                chart1.Series["Series1"].Points.AddXY(d.Key, d.Value);
        }
    }
}
