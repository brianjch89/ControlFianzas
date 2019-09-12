namespace Vista
{
    partial class FormIntroducirNroFianza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIntroducirNroFianza));
            this.lIntroduzcaNroFianza = new System.Windows.Forms.Label();
            this.lNroFianzaCNC = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lConsultaConfrontacion = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.cbNroFianza = new System.Windows.Forms.ComboBox();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lIntroduzcaNroFianza
            // 
            this.lIntroduzcaNroFianza.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lIntroduzcaNroFianza.ForeColor = System.Drawing.Color.White;
            this.lIntroduzcaNroFianza.Location = new System.Drawing.Point(45, 56);
            this.lIntroduzcaNroFianza.Margin = new System.Windows.Forms.Padding(0);
            this.lIntroduzcaNroFianza.Name = "lIntroduzcaNroFianza";
            this.lIntroduzcaNroFianza.Size = new System.Drawing.Size(288, 72);
            this.lIntroduzcaNroFianza.TabIndex = 4;
            this.lIntroduzcaNroFianza.Text = "Ingrese o seleccione el Número de Contrato de Fianza a Consultar y luego presione" +
    " el Botón Aceptar";
            this.lIntroduzcaNroFianza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lNroFianzaCNC
            // 
            this.lNroFianzaCNC.AutoSize = true;
            this.lNroFianzaCNC.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lNroFianzaCNC.ForeColor = System.Drawing.Color.Lavender;
            this.lNroFianzaCNC.Location = new System.Drawing.Point(9, 151);
            this.lNroFianzaCNC.Margin = new System.Windows.Forms.Padding(0);
            this.lNroFianzaCNC.Name = "lNroFianzaCNC";
            this.lNroFianzaCNC.Size = new System.Drawing.Size(113, 18);
            this.lNroFianzaCNC.TabIndex = 5;
            this.lNroFianzaCNC.Text = "Nro. de Fianza";
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
            this.btnCancelar.Location = new System.Drawing.Point(208, 196);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 32);
            this.btnCancelar.TabIndex = 19;
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
            this.btnAceptar.Location = new System.Drawing.Point(77, 196);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(98, 32);
            this.btnAceptar.TabIndex = 18;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraTitulo.Controls.Add(this.lConsultaConfrontacion);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(385, 38);
            this.BarraTitulo.TabIndex = 20;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // lConsultaConfrontacion
            // 
            this.lConsultaConfrontacion.AutoSize = true;
            this.lConsultaConfrontacion.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lConsultaConfrontacion.ForeColor = System.Drawing.Color.White;
            this.lConsultaConfrontacion.Location = new System.Drawing.Point(3, 9);
            this.lConsultaConfrontacion.Name = "lConsultaConfrontacion";
            this.lConsultaConfrontacion.Size = new System.Drawing.Size(299, 20);
            this.lConsultaConfrontacion.TabIndex = 4;
            this.lConsultaConfrontacion.Text = "Consulta por Número de Confrontación";
            this.lConsultaConfrontacion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lConsultaConfrontacion_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(347, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cbNroFianza
            // 
            this.cbNroFianza.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNroFianza.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNroFianza.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbNroFianza.ForeColor = System.Drawing.Color.Maroon;
            this.cbNroFianza.FormattingEnabled = true;
            this.cbNroFianza.Location = new System.Drawing.Point(126, 148);
            this.cbNroFianza.Margin = new System.Windows.Forms.Padding(0);
            this.cbNroFianza.Name = "cbNroFianza";
            this.cbNroFianza.Size = new System.Drawing.Size(250, 26);
            this.cbNroFianza.TabIndex = 1;
            // 
            // FormIntroducirNroFianza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(50)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(385, 246);
            this.Controls.Add(this.cbNroFianza);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lNroFianzaCNC);
            this.Controls.Add(this.lIntroduzcaNroFianza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIntroducirNroFianza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta por Número de Confrontación";
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lIntroduzcaNroFianza;
        private System.Windows.Forms.Label lNroFianzaCNC;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label lConsultaConfrontacion;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.ComboBox cbNroFianza;
    }
}