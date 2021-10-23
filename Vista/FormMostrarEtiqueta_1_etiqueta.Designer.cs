namespace Vista
{
    partial class FormMostrarEtiqueta_1_etiqueta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMostrarEtiqueta_1_etiqueta));
            this.reportViewer_1_etiqueta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer_1_etiqueta
            // 
            this.reportViewer_1_etiqueta.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer_1_etiqueta.BackColor = System.Drawing.Color.DimGray;
            this.reportViewer_1_etiqueta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer_1_etiqueta.LocalReport.ReportEmbeddedResource = "Vista.Etiqueta_Fianza_1_etiqueta.rdlc";
            this.reportViewer_1_etiqueta.Location = new System.Drawing.Point(0, 0);
            this.reportViewer_1_etiqueta.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer_1_etiqueta.Name = "reportViewer_1_etiqueta";
            this.reportViewer_1_etiqueta.ShowBackButton = false;
            this.reportViewer_1_etiqueta.ShowFindControls = false;
            this.reportViewer_1_etiqueta.ShowPageNavigationControls = false;
            this.reportViewer_1_etiqueta.ShowRefreshButton = false;
            this.reportViewer_1_etiqueta.ShowStopButton = false;
            this.reportViewer_1_etiqueta.Size = new System.Drawing.Size(619, 702);
            this.reportViewer_1_etiqueta.TabIndex = 0;
            this.reportViewer_1_etiqueta.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // FormMostrarEtiqueta_1_etiqueta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 702);
            this.Controls.Add(this.reportViewer_1_etiqueta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "FormMostrarEtiqueta_1_etiqueta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mostra Etiqueta";
            this.Load += new System.EventHandler(this.FormMostrarEtiqueta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_1_etiqueta;




    }
}