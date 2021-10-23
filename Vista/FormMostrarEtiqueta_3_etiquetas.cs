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
    public partial class FormMostrarEtiqueta_3_etiquetas : Form
    {
        DataGridView dgvFianzas;

        public FormMostrarEtiqueta_3_etiquetas(DataGridView dgvF)
        {
            dgvFianzas = dgvF;
            InitializeComponent();
        }

        private void FormMostrarEtiqueta_Load(object sender, EventArgs e)
        {
            ReportParameter[] reportParameters = new ReportParameter[12];
            reportParameters[0] = new ReportParameter("Param_Año1", dgvFianzas.Rows[0].Cells[1].Value.ToString() + " / " + dgvFianzas.Rows[0].Cells[2].Value.ToString());
            reportParameters[1] = new ReportParameter("Param_Contribuyente1", dgvFianzas.Rows[0].Cells[3].Value.ToString());
            reportParameters[2] = new ReportParameter("Param_NroDeFianza1", dgvFianzas.Rows[0].Cells[0].Value.ToString());
            reportParameters[3] = new ReportParameter("Param_TipoDeFianza1", dgvFianzas.Rows[0].Cells[4].Value.ToString());

            reportParameters[4] = new ReportParameter("Param_Año2", dgvFianzas.Rows[1].Cells[1].Value.ToString() + " / " + dgvFianzas.Rows[1].Cells[2].Value.ToString());
            reportParameters[5] = new ReportParameter("Param_Contribuyente2", dgvFianzas.Rows[1].Cells[3].Value.ToString());
            reportParameters[6] = new ReportParameter("Param_NroDeFianza2", dgvFianzas.Rows[1].Cells[0].Value.ToString());
            reportParameters[7] = new ReportParameter("Param_TipoDeFianza2", dgvFianzas.Rows[1].Cells[4].Value.ToString());

            reportParameters[8] = new ReportParameter("Param_Año3", dgvFianzas.Rows[2].Cells[1].Value.ToString() + " / " + dgvFianzas.Rows[2].Cells[2].Value.ToString());
            reportParameters[9] = new ReportParameter("Param_Contribuyente3", dgvFianzas.Rows[2].Cells[3].Value.ToString());
            reportParameters[10] = new ReportParameter("Param_NroDeFianza3", dgvFianzas.Rows[2].Cells[0].Value.ToString());
            reportParameters[11] = new ReportParameter("Param_TipoDeFianza3", dgvFianzas.Rows[2].Cells[4].Value.ToString());
            
            foreach (var item in reportParameters)
                this.reportViewer_3_etiquetas.LocalReport.SetParameters(item);

            this.reportViewer_3_etiquetas.LocalReport.Refresh();
            this.reportViewer_3_etiquetas.RefreshReport();
            this.reportViewer_3_etiquetas.RefreshReport();
        }
    }
}
