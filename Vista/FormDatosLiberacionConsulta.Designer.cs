namespace Vista
{
    partial class FormDatosLiberacionConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatosLiberacionConsulta));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lDatosContratoFianza = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lMotivoLibe = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.dtpFechaLiberacion = new System.Windows.Forms.DateTimePicker();
            this.lFechaLiberacion = new System.Windows.Forms.Label();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.lFechaEmisión = new System.Windows.Forms.Label();
            this.lNroFianza = new System.Windows.Forms.Label();
            this.tbNroFianza = new System.Windows.Forms.TextBox();
            this.lDatosContratoFianzaLiberado = new System.Windows.Forms.Label();
            this.cbMotivoLibe = new System.Windows.Forms.ComboBox();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraTitulo.Controls.Add(this.lDatosContratoFianza);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(389, 38);
            this.BarraTitulo.TabIndex = 36;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // lDatosContratoFianza
            // 
            this.lDatosContratoFianza.AutoSize = true;
            this.lDatosContratoFianza.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lDatosContratoFianza.ForeColor = System.Drawing.Color.White;
            this.lDatosContratoFianza.Location = new System.Drawing.Point(3, 9);
            this.lDatosContratoFianza.Name = "lDatosContratoFianza";
            this.lDatosContratoFianza.Size = new System.Drawing.Size(328, 20);
            this.lDatosContratoFianza.TabIndex = 1;
            this.lDatosContratoFianza.Text = "Datos de los Contratos de Fianzas Liberados";
            this.lDatosContratoFianza.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lDatosContratoFianza_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(351, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lMotivoLibe
            // 
            this.lMotivoLibe.AutoSize = true;
            this.lMotivoLibe.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lMotivoLibe.ForeColor = System.Drawing.Color.White;
            this.lMotivoLibe.Location = new System.Drawing.Point(15, 236);
            this.lMotivoLibe.Name = "lMotivoLibe";
            this.lMotivoLibe.Size = new System.Drawing.Size(165, 18);
            this.lMotivoLibe.TabIndex = 50;
            this.lMotivoLibe.Text = "Motivo de Liberación";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(145, 288);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(100, 32);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // dtpFechaLiberacion
            // 
            this.dtpFechaLiberacion.CustomFormat = "";
            this.dtpFechaLiberacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtpFechaLiberacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLiberacion.Location = new System.Drawing.Point(179, 194);
            this.dtpFechaLiberacion.Name = "dtpFechaLiberacion";
            this.dtpFechaLiberacion.Size = new System.Drawing.Size(122, 26);
            this.dtpFechaLiberacion.TabIndex = 4;
            // 
            // lFechaLiberacion
            // 
            this.lFechaLiberacion.AutoSize = true;
            this.lFechaLiberacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lFechaLiberacion.ForeColor = System.Drawing.Color.White;
            this.lFechaLiberacion.Location = new System.Drawing.Point(12, 196);
            this.lFechaLiberacion.Name = "lFechaLiberacion";
            this.lFechaLiberacion.Size = new System.Drawing.Size(161, 18);
            this.lFechaLiberacion.TabIndex = 49;
            this.lFechaLiberacion.Text = "Fecha de Liberación";
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.CustomFormat = "";
            this.dtpFechaEmision.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEmision.Location = new System.Drawing.Point(153, 156);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(122, 26);
            this.dtpFechaEmision.TabIndex = 3;
            // 
            // lFechaEmisión
            // 
            this.lFechaEmisión.AutoSize = true;
            this.lFechaEmisión.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lFechaEmisión.ForeColor = System.Drawing.Color.White;
            this.lFechaEmisión.Location = new System.Drawing.Point(10, 162);
            this.lFechaEmisión.Name = "lFechaEmisión";
            this.lFechaEmisión.Size = new System.Drawing.Size(137, 18);
            this.lFechaEmisión.TabIndex = 47;
            this.lFechaEmisión.Text = "Fecha de Emisión";
            // 
            // lNroFianza
            // 
            this.lNroFianza.AutoSize = true;
            this.lNroFianza.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lNroFianza.ForeColor = System.Drawing.Color.White;
            this.lNroFianza.Location = new System.Drawing.Point(10, 124);
            this.lNroFianza.Margin = new System.Windows.Forms.Padding(0);
            this.lNroFianza.Name = "lNroFianza";
            this.lNroFianza.Size = new System.Drawing.Size(113, 18);
            this.lNroFianza.TabIndex = 44;
            this.lNroFianza.Text = "Nro. de Fianza";
            // 
            // tbNroFianza
            // 
            this.tbNroFianza.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbNroFianza.ForeColor = System.Drawing.Color.Maroon;
            this.tbNroFianza.Location = new System.Drawing.Point(128, 118);
            this.tbNroFianza.Margin = new System.Windows.Forms.Padding(0);
            this.tbNroFianza.MaxLength = 35;
            this.tbNroFianza.Name = "tbNroFianza";
            this.tbNroFianza.Size = new System.Drawing.Size(250, 26);
            this.tbNroFianza.TabIndex = 2;
            this.tbNroFianza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNroFianza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNroFianza_KeyPress);
            // 
            // lDatosContratoFianzaLiberado
            // 
            this.lDatosContratoFianzaLiberado.AutoSize = true;
            this.lDatosContratoFianzaLiberado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lDatosContratoFianzaLiberado.ForeColor = System.Drawing.Color.Lavender;
            this.lDatosContratoFianzaLiberado.Location = new System.Drawing.Point(46, 65);
            this.lDatosContratoFianzaLiberado.Margin = new System.Windows.Forms.Padding(0);
            this.lDatosContratoFianzaLiberado.Name = "lDatosContratoFianzaLiberado";
            this.lDatosContratoFianzaLiberado.Size = new System.Drawing.Size(298, 18);
            this.lDatosContratoFianzaLiberado.TabIndex = 42;
            this.lDatosContratoFianzaLiberado.Text = "Datos del contrato de Fianza - Liberado";
            this.lDatosContratoFianzaLiberado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMotivoLibe
            // 
            this.cbMotivoLibe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMotivoLibe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMotivoLibe.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbMotivoLibe.FormattingEnabled = true;
            this.cbMotivoLibe.Location = new System.Drawing.Point(186, 233);
            this.cbMotivoLibe.Name = "cbMotivoLibe";
            this.cbMotivoLibe.Size = new System.Drawing.Size(192, 26);
            this.cbMotivoLibe.TabIndex = 5;
            // 
            // FormDatosLiberacionConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(389, 336);
            this.Controls.Add(this.cbMotivoLibe);
            this.Controls.Add(this.lMotivoLibe);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.dtpFechaLiberacion);
            this.Controls.Add(this.lFechaLiberacion);
            this.Controls.Add(this.dtpFechaEmision);
            this.Controls.Add(this.lFechaEmisión);
            this.Controls.Add(this.lNroFianza);
            this.Controls.Add(this.tbNroFianza);
            this.Controls.Add(this.lDatosContratoFianzaLiberado);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDatosLiberacionConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datos de los Contratos de Fianzas Liberados";
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label lDatosContratoFianza;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lMotivoLibe;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DateTimePicker dtpFechaLiberacion;
        private System.Windows.Forms.Label lFechaLiberacion;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.Label lFechaEmisión;
        private System.Windows.Forms.Label lNroFianza;
        private System.Windows.Forms.TextBox tbNroFianza;
        private System.Windows.Forms.Label lDatosContratoFianzaLiberado;
        private System.Windows.Forms.ComboBox cbMotivoLibe;
    }
}