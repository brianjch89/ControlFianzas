namespace Vista
{
    partial class FormInicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.pbSENIAT = new System.Windows.Forms.PictureBox();
            this.lHorainicio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lFechaInicio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSENIAT)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSENIAT
            // 
            this.pbSENIAT.Image = ((System.Drawing.Image)(resources.GetObject("pbSENIAT.Image")));
            this.pbSENIAT.Location = new System.Drawing.Point(189, 232);
            this.pbSENIAT.Name = "pbSENIAT";
            this.pbSENIAT.Size = new System.Drawing.Size(601, 296);
            this.pbSENIAT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSENIAT.TabIndex = 0;
            this.pbSENIAT.TabStop = false;
            // 
            // lHorainicio
            // 
            this.lHorainicio.AutoSize = true;
            this.lHorainicio.Font = new System.Drawing.Font("Century Gothic", 60F);
            this.lHorainicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.lHorainicio.Location = new System.Drawing.Point(164, 38);
            this.lHorainicio.Name = "lHorainicio";
            this.lHorainicio.Size = new System.Drawing.Size(0, 96);
            this.lHorainicio.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lFechaInicio
            // 
            this.lFechaInicio.AutoSize = true;
            this.lFechaInicio.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lFechaInicio.ForeColor = System.Drawing.Color.SeaGreen;
            this.lFechaInicio.Location = new System.Drawing.Point(180, 130);
            this.lFechaInicio.Margin = new System.Windows.Forms.Padding(0);
            this.lFechaInicio.Name = "lFechaInicio";
            this.lFechaInicio.Size = new System.Drawing.Size(0, 33);
            this.lFechaInicio.TabIndex = 2;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(980, 577);
            this.Controls.Add(this.lFechaInicio);
            this.Controls.Add(this.lHorainicio);
            this.Controls.Add(this.pbSENIAT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pbSENIAT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSENIAT;
        private System.Windows.Forms.Label lHorainicio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lFechaInicio;
    }
}