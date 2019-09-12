namespace Vista
{
    partial class FormDatosLiberacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatosLiberacion));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lDatosContratoFianza = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lDatosContratoFianzaLiberado = new System.Windows.Forms.Label();
            this.lNroFianza = new System.Windows.Forms.Label();
            this.tbNroFianza = new System.Windows.Forms.TextBox();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.lFechaEmisión = new System.Windows.Forms.Label();
            this.dtpFechaLiberacion = new System.Windows.Forms.DateTimePicker();
            this.lFechaLiberacion = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lMotivoLibe = new System.Windows.Forms.Label();
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
            this.BarraTitulo.TabIndex = 35;
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
            // lDatosContratoFianzaLiberado
            // 
            this.lDatosContratoFianzaLiberado.AutoSize = true;
            this.lDatosContratoFianzaLiberado.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lDatosContratoFianzaLiberado.ForeColor = System.Drawing.Color.Lavender;
            this.lDatosContratoFianzaLiberado.Location = new System.Drawing.Point(46, 65);
            this.lDatosContratoFianzaLiberado.Margin = new System.Windows.Forms.Padding(0);
            this.lDatosContratoFianzaLiberado.Name = "lDatosContratoFianzaLiberado";
            this.lDatosContratoFianzaLiberado.Size = new System.Drawing.Size(298, 18);
            this.lDatosContratoFianzaLiberado.TabIndex = 2;
            this.lDatosContratoFianzaLiberado.Text = "Datos del contrato de Fianza - Liberado";
            this.lDatosContratoFianzaLiberado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lNroFianza.TabIndex = 3;
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
            this.tbNroFianza.TabIndex = 3;
            this.tbNroFianza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNroFianza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNroFianza_KeyPress);
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.CustomFormat = "";
            this.dtpFechaEmision.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEmision.Location = new System.Drawing.Point(153, 156);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(122, 26);
            this.dtpFechaEmision.TabIndex = 4;
            this.dtpFechaEmision.ValueChanged += new System.EventHandler(this.dtpFechaEmision_ValueChanged);
            this.dtpFechaEmision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaEmision_KeyPress);
            this.dtpFechaEmision.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpFechaEmision_MouseDown);
            // 
            // lFechaEmisión
            // 
            this.lFechaEmisión.AutoSize = true;
            this.lFechaEmisión.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lFechaEmisión.ForeColor = System.Drawing.Color.White;
            this.lFechaEmisión.Location = new System.Drawing.Point(10, 162);
            this.lFechaEmisión.Name = "lFechaEmisión";
            this.lFechaEmisión.Size = new System.Drawing.Size(137, 18);
            this.lFechaEmisión.TabIndex = 5;
            this.lFechaEmisión.Text = "Fecha de Emisión";
            // 
            // dtpFechaLiberacion
            // 
            this.dtpFechaLiberacion.CustomFormat = "";
            this.dtpFechaLiberacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtpFechaLiberacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLiberacion.Location = new System.Drawing.Point(179, 194);
            this.dtpFechaLiberacion.Name = "dtpFechaLiberacion";
            this.dtpFechaLiberacion.Size = new System.Drawing.Size(122, 26);
            this.dtpFechaLiberacion.TabIndex = 5;
            this.dtpFechaLiberacion.ValueChanged += new System.EventHandler(this.dtpFechaLiberacion_ValueChanged);
            this.dtpFechaLiberacion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpFechaLiberacion_MouseDown);
            // 
            // lFechaLiberacion
            // 
            this.lFechaLiberacion.AutoSize = true;
            this.lFechaLiberacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lFechaLiberacion.ForeColor = System.Drawing.Color.White;
            this.lFechaLiberacion.Location = new System.Drawing.Point(12, 196);
            this.lFechaLiberacion.Name = "lFechaLiberacion";
            this.lFechaLiberacion.Size = new System.Drawing.Size(161, 18);
            this.lFechaLiberacion.TabIndex = 9;
            this.lFechaLiberacion.Text = "Fecha de Liberación";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(212, 288);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 32);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(81, 288);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(98, 32);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lMotivoLibe
            // 
            this.lMotivoLibe.AutoSize = true;
            this.lMotivoLibe.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lMotivoLibe.ForeColor = System.Drawing.Color.White;
            this.lMotivoLibe.Location = new System.Drawing.Point(15, 236);
            this.lMotivoLibe.Name = "lMotivoLibe";
            this.lMotivoLibe.Size = new System.Drawing.Size(165, 18);
            this.lMotivoLibe.TabIndex = 39;
            this.lMotivoLibe.Text = "Motivo de Liberación";
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
            this.cbMotivoLibe.TabIndex = 6;
            // 
            // FormDatosLiberacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(389, 336);
            this.Controls.Add(this.cbMotivoLibe);
            this.Controls.Add(this.lMotivoLibe);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dtpFechaLiberacion);
            this.Controls.Add(this.lFechaLiberacion);
            this.Controls.Add(this.dtpFechaEmision);
            this.Controls.Add(this.lFechaEmisión);
            this.Controls.Add(this.lNroFianza);
            this.Controls.Add(this.tbNroFianza);
            this.Controls.Add(this.lDatosContratoFianzaLiberado);
            this.Controls.Add(this.BarraTitulo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDatosLiberacion";
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
        private System.Windows.Forms.Label lDatosContratoFianzaLiberado;
        private System.Windows.Forms.Label lNroFianza;
        private System.Windows.Forms.TextBox tbNroFianza;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.Label lFechaEmisión;
        private System.Windows.Forms.DateTimePicker dtpFechaLiberacion;
        private System.Windows.Forms.Label lFechaLiberacion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lMotivoLibe;
        private System.Windows.Forms.ComboBox cbMotivoLibe;
    }
}