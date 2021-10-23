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

using Microsoft.Reporting.WinForms;
using System.Xml;

namespace Vista
{
    public partial class FormMostrarEtiqueta_1_etiqueta : Form
    {
        DataGridView dgvFianzas;

        public FormMostrarEtiqueta_1_etiqueta(DataGridView dgvF)
        {
            dgvFianzas = dgvF;
            InitializeComponent();
        }

        private void FormMostrarEtiqueta_Load(object sender, EventArgs e)
        {
            ReportParameter[] reportParameters = new ReportParameter[4];
            reportParameters[0] = new ReportParameter("Param_Año1", dgvFianzas.Rows[0].Cells[1].Value.ToString() + " / " + dgvFianzas.Rows[0].Cells[2].Value.ToString());
            reportParameters[1] = new ReportParameter("Param_Contribuyente1", dgvFianzas.Rows[0].Cells[3].Value.ToString());
            reportParameters[2] = new ReportParameter("Param_NroDeFianza1", dgvFianzas.Rows[0].Cells[0].Value.ToString());
            reportParameters[3] = new ReportParameter("Param_TipoDeFianza1", dgvFianzas.Rows[0].Cells[4].Value.ToString());

            foreach (var item in reportParameters)
                this.reportViewer_1_etiqueta.LocalReport.SetParameters(item);

            this.reportViewer_1_etiqueta.LocalReport.Refresh();
            this.reportViewer_1_etiqueta.RefreshReport();
        }
    }
}
