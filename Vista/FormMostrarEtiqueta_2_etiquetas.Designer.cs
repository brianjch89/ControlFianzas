namespace Vista
{
    partial class FormMostrarEtiqueta_2_etiquetas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMostrarEtiqueta_2_etiquetas));
            this.reportViewer_2_etiquetas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer_2_etiquetas
            // 
            this.reportViewer_2_etiquetas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer_2_etiquetas.BackColor = System.Drawing.Color.DimGray;
            this.reportViewer_2_etiquetas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer_2_etiquetas.LocalReport.ReportEmbeddedResource = "Vista.Etiqueta_Fianza_2_etiquetas.rdlc";
            this.reportViewer_2_etiquetas.Location = new System.Drawing.Point(0, 0);
            this.reportViewer_2_etiquetas.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer_2_etiquetas.Name = "reportViewer_2_etiquetas";
            this.reportViewer_2_etiquetas.ShowBackButton = false;
            this.reportViewer_2_etiquetas.ShowFindControls = false;
            this.reportViewer_2_etiquetas.ShowPageNavigationControls = false;
            this.reportViewer_2_etiquetas.ShowRefreshButton = false;
            this.reportViewer_2_etiquetas.ShowStopButton = false;
            this.reportViewer_2_etiquetas.Size = new System.Drawing.Size(619, 702);
            this.reportViewer_2_etiquetas.TabIndex = 0;
            this.reportViewer_2_etiquetas.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // FormMostrarEtiqueta_2_etiquetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 702);
            this.Controls.Add(this.reportViewer_2_etiquetas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "FormMostrarEtiqueta_2_etiquetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mostra Etiqueta";
            this.Load += new System.EventHandler(this.FormMostrarEtiqueta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_2_etiquetas;




    }
}