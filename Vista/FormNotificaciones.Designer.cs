namespace Vista
{
    partial class FormNotificaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotificaciones));
            this.dgvFianzasPorVencer = new System.Windows.Forms.DataGridView();
            this.NroDeFianza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroArchivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDeVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Garante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lFianzasPorVencer = new System.Windows.Forms.Label();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lNotificaciones = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.lSeleccioneMes = new System.Windows.Forms.Label();
            this.lFianzasVencidas = new System.Windows.Forms.Label();
            this.lCantidadFianzasVencidas = new System.Windows.Forms.Label();
            this.btnHistograma = new System.Windows.Forms.Button();
            this.lHora = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFianzasPorVencer)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFianzasPorVencer
            // 
            this.dgvFianzasPorVencer.AllowUserToAddRows = false;
            this.dgvFianzasPorVencer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvFianzasPorVencer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFianzasPorVencer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFianzasPorVencer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFianzasPorVencer.ColumnHeadersHeight = 30;
            this.dgvFianzasPorVencer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFianzasPorVencer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroDeFianza,
            this.NroArchivo,
            this.FechaDeVencimiento,
            this.Año,
            this.Garante,
            this.Agente});
            this.dgvFianzasPorVencer.EnableHeadersVisualStyles = false;
            this.dgvFianzasPorVencer.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvFianzasPorVencer.Location = new System.Drawing.Point(44, 129);
            this.dgvFianzasPorVencer.Name = "dgvFianzasPorVencer";
            this.dgvFianzasPorVencer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFianzasPorVencer.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFianzasPorVencer.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvFianzasPorVencer.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFianzasPorVencer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFianzasPorVencer.Size = new System.Drawing.Size(961, 264);
            this.dgvFianzasPorVencer.TabIndex = 0;
            // 
            // NroDeFianza
            // 
            this.NroDeFianza.FillWeight = 60F;
            this.NroDeFianza.HeaderText = "Nro. de Fianza";
            this.NroDeFianza.Name = "NroDeFianza";
            this.NroDeFianza.Width = 170;
            // 
            // NroArchivo
            // 
            this.NroArchivo.FillWeight = 60F;
            this.NroArchivo.HeaderText = "Nro. de Archivo";
            this.NroArchivo.Name = "NroArchivo";
            this.NroArchivo.Width = 130;
            // 
            // FechaDeVencimiento
            // 
            this.FechaDeVencimiento.HeaderText = "Fecha de Vencimiento";
            this.FechaDeVencimiento.Name = "FechaDeVencimiento";
            this.FechaDeVencimiento.Width = 180;
            // 
            // Año
            // 
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            this.Año.Width = 50;
            // 
            // Garante
            // 
            this.Garante.HeaderText = "Garante";
            this.Garante.Name = "Garante";
            this.Garante.Width = 200;
            // 
            // Agente
            // 
            this.Agente.HeaderText = "Agente";
            this.Agente.Name = "Agente";
            this.Agente.Width = 200;
            // 
            // lFianzasPorVencer
            // 
            this.lFianzasPorVencer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lFianzasPorVencer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lFianzasPorVencer.ForeColor = System.Drawing.Color.Lime;
            this.lFianzasPorVencer.Location = new System.Drawing.Point(79, 406);
            this.lFianzasPorVencer.Name = "lFianzasPorVencer";
            this.lFianzasPorVencer.Size = new System.Drawing.Size(344, 47);
            this.lFianzasPorVencer.TabIndex = 5;
            this.lFianzasPorVencer.Text = "Fianzas por vencerse dentro de 3 meses: 0 fianzas";
            this.lFianzasPorVencer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraTitulo.Controls.Add(this.lNotificaciones);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1020, 38);
            this.BarraTitulo.TabIndex = 2;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // lNotificaciones
            // 
            this.lNotificaciones.AutoSize = true;
            this.lNotificaciones.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lNotificaciones.ForeColor = System.Drawing.Color.White;
            this.lNotificaciones.Location = new System.Drawing.Point(3, 9);
            this.lNotificaciones.Name = "lNotificaciones";
            this.lNotificaciones.Size = new System.Drawing.Size(114, 20);
            this.lNotificaciones.TabIndex = 4;
            this.lNotificaciones.Text = "Notificaciones";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(982, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cbMes
            // 
            this.cbMes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(244, 74);
            this.cbMes.Margin = new System.Windows.Forms.Padding(0);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(129, 26);
            this.cbMes.TabIndex = 3;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            // 
            // lSeleccioneMes
            // 
            this.lSeleccioneMes.AutoSize = true;
            this.lSeleccioneMes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lSeleccioneMes.ForeColor = System.Drawing.Color.LightGreen;
            this.lSeleccioneMes.Location = new System.Drawing.Point(79, 77);
            this.lSeleccioneMes.Margin = new System.Windows.Forms.Padding(0);
            this.lSeleccioneMes.Name = "lSeleccioneMes";
            this.lSeleccioneMes.Size = new System.Drawing.Size(149, 18);
            this.lSeleccioneMes.TabIndex = 10;
            this.lSeleccioneMes.Text = "Seleccione el mes:";
            this.lSeleccioneMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lFianzasVencidas
            // 
            this.lFianzasVencidas.AutoSize = true;
            this.lFianzasVencidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(93)))), ((int)(((byte)(60)))));
            this.lFianzasVencidas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lFianzasVencidas.ForeColor = System.Drawing.Color.Black;
            this.lFianzasVencidas.Location = new System.Drawing.Point(446, 90);
            this.lFianzasVencidas.Margin = new System.Windows.Forms.Padding(0);
            this.lFianzasVencidas.Name = "lFianzasVencidas";
            this.lFianzasVencidas.Size = new System.Drawing.Size(148, 18);
            this.lFianzasVencidas.TabIndex = 11;
            this.lFianzasVencidas.Text = "FIANZAS VENCIDAS";
            this.lFianzasVencidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lFianzasVencidas.Visible = false;
            // 
            // lCantidadFianzasVencidas
            // 
            this.lCantidadFianzasVencidas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lCantidadFianzasVencidas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lCantidadFianzasVencidas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(83)))), ((int)(((byte)(48)))));
            this.lCantidadFianzasVencidas.Location = new System.Drawing.Point(595, 406);
            this.lCantidadFianzasVencidas.Name = "lCantidadFianzasVencidas";
            this.lCantidadFianzasVencidas.Size = new System.Drawing.Size(344, 47);
            this.lCantidadFianzasVencidas.TabIndex = 6;
            this.lCantidadFianzasVencidas.Text = "Fianzas por vencerse dentro de 3 meses: 0 fianzas";
            this.lCantidadFianzasVencidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHistograma
            // 
            this.btnHistograma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(40)))), ((int)(((byte)(191)))));
            this.btnHistograma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistograma.FlatAppearance.BorderSize = 0;
            this.btnHistograma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(93)))), ((int)(((byte)(191)))));
            this.btnHistograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistograma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistograma.ForeColor = System.Drawing.Color.White;
            this.btnHistograma.Image = ((System.Drawing.Image)(resources.GetObject("btnHistograma.Image")));
            this.btnHistograma.Location = new System.Drawing.Point(851, 68);
            this.btnHistograma.Name = "btnHistograma";
            this.btnHistograma.Size = new System.Drawing.Size(70, 40);
            this.btnHistograma.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnHistograma, "Histograma de Fianzas");
            this.btnHistograma.UseVisualStyleBackColor = false;
            this.btnHistograma.Click += new System.EventHandler(this.btnHistograma_Click);
            // 
            // lHora
            // 
            this.lHora.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lHora.ForeColor = System.Drawing.Color.Lime;
            this.lHora.Location = new System.Drawing.Point(652, 48);
            this.lHora.Name = "lHora";
            this.lHora.Size = new System.Drawing.Size(185, 76);
            this.lHora.TabIndex = 23;
            this.lHora.Text = "Presione este botón para poder visualizar un histograma de fianzas";
            this.lHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormNotificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1020, 471);
            this.Controls.Add(this.lHora);
            this.Controls.Add(this.btnHistograma);
            this.Controls.Add(this.lCantidadFianzasVencidas);
            this.Controls.Add(this.lFianzasVencidas);
            this.Controls.Add(this.lSeleccioneMes);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.lFianzasPorVencer);
            this.Controls.Add(this.dgvFianzasPorVencer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNotificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Notificaciones";
            this.Load += new System.EventHandler(this.FormNotificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFianzasPorVencer)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFianzasPorVencer;
        private System.Windows.Forms.Label lFianzasPorVencer;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label lNotificaciones;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label lSeleccioneMes;
        private System.Windows.Forms.Label lFianzasVencidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDeFianza;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDeVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn Garante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Agente;
        private System.Windows.Forms.Label lCantidadFianzasVencidas;
        private System.Windows.Forms.Button btnHistograma;
        private System.Windows.Forms.Label lHora;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}