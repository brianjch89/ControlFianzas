namespace Vista
{
    partial class FormEtiquetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEtiquetas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lNroFianza = new System.Windows.Forms.Label();
            this.tbAño = new System.Windows.Forms.TextBox();
            this.lAño = new System.Windows.Forms.Label();
            this.lArchivo = new System.Windows.Forms.Label();
            this.tbArchivo = new System.Windows.Forms.TextBox();
            this.lContribuyente = new System.Windows.Forms.Label();
            this.tbNombreConsignatario = new System.Windows.Forms.TextBox();
            this.lNaturalezaOperacion = new System.Windows.Forms.Label();
            this.lIntroduzcaAño = new System.Windows.Forms.Label();
            this.btnAgregarFianza = new System.Windows.Forms.Button();
            this.btnGenerarEtiquetas = new System.Windows.Forms.Button();
            this.tbTipoDeFianza = new System.Windows.Forms.TextBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lInformacionEtiquetas = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.dgvEtiquetasFianza = new System.Windows.Forms.DataGridView();
            this.NroDeFianza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Año = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroArchivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contribuyente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NaturalezaDeLaOperación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbNroFianza = new System.Windows.Forms.ComboBox();
            this.btnEliminarFianza = new System.Windows.Forms.Button();
            this.lFecha = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtiquetasFianza)).BeginInit();
            this.SuspendLayout();
            // 
            // lNroFianza
            // 
            this.lNroFianza.AutoSize = true;
            this.lNroFianza.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lNroFianza.ForeColor = System.Drawing.Color.Lavender;
            this.lNroFianza.Location = new System.Drawing.Point(944, 81);
            this.lNroFianza.Margin = new System.Windows.Forms.Padding(0);
            this.lNroFianza.Name = "lNroFianza";
            this.lNroFianza.Size = new System.Drawing.Size(142, 23);
            this.lNroFianza.TabIndex = 2;
            this.lNroFianza.Text = "Nro. de Fianza";
            // 
            // tbAño
            // 
            this.tbAño.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbAño.ForeColor = System.Drawing.Color.Maroon;
            this.tbAño.Location = new System.Drawing.Point(1107, 123);
            this.tbAño.Margin = new System.Windows.Forms.Padding(0);
            this.tbAño.MaxLength = 4;
            this.tbAño.Name = "tbAño";
            this.tbAño.Size = new System.Drawing.Size(68, 30);
            this.tbAño.TabIndex = 4;
            this.tbAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAño_KeyPress);
            // 
            // lAño
            // 
            this.lAño.AutoSize = true;
            this.lAño.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lAño.ForeColor = System.Drawing.Color.Lavender;
            this.lAño.Location = new System.Drawing.Point(1048, 127);
            this.lAño.Margin = new System.Windows.Forms.Padding(0);
            this.lAño.Name = "lAño";
            this.lAño.Size = new System.Drawing.Size(47, 23);
            this.lAño.TabIndex = 15;
            this.lAño.Text = "Año";
            // 
            // lArchivo
            // 
            this.lArchivo.AutoSize = true;
            this.lArchivo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lArchivo.ForeColor = System.Drawing.Color.Lavender;
            this.lArchivo.Location = new System.Drawing.Point(931, 176);
            this.lArchivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lArchivo.Name = "lArchivo";
            this.lArchivo.Size = new System.Drawing.Size(153, 23);
            this.lArchivo.TabIndex = 20;
            this.lArchivo.Text = "Nro. de Archivo";
            // 
            // tbArchivo
            // 
            this.tbArchivo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbArchivo.ForeColor = System.Drawing.Color.Maroon;
            this.tbArchivo.Location = new System.Drawing.Point(1107, 172);
            this.tbArchivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbArchivo.Name = "tbArchivo";
            this.tbArchivo.Size = new System.Drawing.Size(68, 30);
            this.tbArchivo.TabIndex = 5;
            this.tbArchivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbArchivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbArchivo_KeyPress);
            // 
            // lContribuyente
            // 
            this.lContribuyente.AutoSize = true;
            this.lContribuyente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lContribuyente.ForeColor = System.Drawing.Color.Lavender;
            this.lContribuyente.Location = new System.Drawing.Point(944, 222);
            this.lContribuyente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lContribuyente.Name = "lContribuyente";
            this.lContribuyente.Size = new System.Drawing.Size(141, 23);
            this.lContribuyente.TabIndex = 21;
            this.lContribuyente.Text = "Contribuyente";
            // 
            // tbNombreConsignatario
            // 
            this.tbNombreConsignatario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbNombreConsignatario.Location = new System.Drawing.Point(1107, 218);
            this.tbNombreConsignatario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNombreConsignatario.MaxLength = 255;
            this.tbNombreConsignatario.Name = "tbNombreConsignatario";
            this.tbNombreConsignatario.Size = new System.Drawing.Size(319, 30);
            this.tbNombreConsignatario.TabIndex = 6;
            this.tbNombreConsignatario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNombreConsignatario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombreConsignatario_KeyPress);
            // 
            // lNaturalezaOperacion
            // 
            this.lNaturalezaOperacion.AutoSize = true;
            this.lNaturalezaOperacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lNaturalezaOperacion.ForeColor = System.Drawing.Color.Lavender;
            this.lNaturalezaOperacion.Location = new System.Drawing.Point(808, 268);
            this.lNaturalezaOperacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNaturalezaOperacion.Name = "lNaturalezaOperacion";
            this.lNaturalezaOperacion.Size = new System.Drawing.Size(270, 23);
            this.lNaturalezaOperacion.TabIndex = 24;
            this.lNaturalezaOperacion.Text = "Naturaleza de la Operación";
            // 
            // lIntroduzcaAño
            // 
            this.lIntroduzcaAño.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lIntroduzcaAño.ForeColor = System.Drawing.Color.LightGreen;
            this.lIntroduzcaAño.Location = new System.Drawing.Point(43, 89);
            this.lIntroduzcaAño.Margin = new System.Windows.Forms.Padding(0);
            this.lIntroduzcaAño.Name = "lIntroduzcaAño";
            this.lIntroduzcaAño.Size = new System.Drawing.Size(732, 47);
            this.lIntroduzcaAño.TabIndex = 9;
            this.lIntroduzcaAño.Text = "Ingrese el Número de Fianza para poder generar la etiqueta de la misma";
            this.lIntroduzcaAño.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarFianza
            // 
            this.btnAgregarFianza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(40)))), ((int)(((byte)(191)))));
            this.btnAgregarFianza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarFianza.FlatAppearance.BorderSize = 0;
            this.btnAgregarFianza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(93)))), ((int)(((byte)(191)))));
            this.btnAgregarFianza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarFianza.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFianza.ForeColor = System.Drawing.Color.White;
            this.btnAgregarFianza.Location = new System.Drawing.Point(872, 332);
            this.btnAgregarFianza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarFianza.Name = "btnAgregarFianza";
            this.btnAgregarFianza.Size = new System.Drawing.Size(215, 39);
            this.btnAgregarFianza.TabIndex = 1;
            this.btnAgregarFianza.UseVisualStyleBackColor = false;
            this.btnAgregarFianza.Click += new System.EventHandler(this.btnAgregarFianza_Click);
            // 
            // btnGenerarEtiquetas
            // 
            this.btnGenerarEtiquetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btnGenerarEtiquetas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerarEtiquetas.FlatAppearance.BorderSize = 0;
            this.btnGenerarEtiquetas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnGenerarEtiquetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarEtiquetas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarEtiquetas.ForeColor = System.Drawing.Color.White;
            this.btnGenerarEtiquetas.Location = new System.Drawing.Point(1107, 332);
            this.btnGenerarEtiquetas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGenerarEtiquetas.Name = "btnGenerarEtiquetas";
            this.btnGenerarEtiquetas.Size = new System.Drawing.Size(215, 39);
            this.btnGenerarEtiquetas.TabIndex = 2;
            this.btnGenerarEtiquetas.Text = "Generar Etiquetas";
            this.btnGenerarEtiquetas.UseVisualStyleBackColor = false;
            this.btnGenerarEtiquetas.Click += new System.EventHandler(this.btnGenerarEtiquetas_Click);
            // 
            // tbTipoDeFianza
            // 
            this.tbTipoDeFianza.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbTipoDeFianza.Location = new System.Drawing.Point(1107, 265);
            this.tbTipoDeFianza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTipoDeFianza.MaxLength = 255;
            this.tbTipoDeFianza.Name = "tbTipoDeFianza";
            this.tbTipoDeFianza.Size = new System.Drawing.Size(319, 30);
            this.tbTipoDeFianza.TabIndex = 7;
            this.tbTipoDeFianza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTipoDeFianza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTipoDeFianza_KeyPress);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraTitulo.Controls.Add(this.lInformacionEtiquetas);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1487, 47);
            this.BarraTitulo.TabIndex = 38;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // lInformacionEtiquetas
            // 
            this.lInformacionEtiquetas.AutoSize = true;
            this.lInformacionEtiquetas.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lInformacionEtiquetas.ForeColor = System.Drawing.Color.White;
            this.lInformacionEtiquetas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lInformacionEtiquetas.Location = new System.Drawing.Point(4, 11);
            this.lInformacionEtiquetas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lInformacionEtiquetas.Name = "lInformacionEtiquetas";
            this.lInformacionEtiquetas.Size = new System.Drawing.Size(287, 22);
            this.lInformacionEtiquetas.TabIndex = 10;
            this.lInformacionEtiquetas.Text = "Información para las Etiquetas";
            this.lInformacionEtiquetas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lInformacionEtiquetas_MouseDown);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1440, 7);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 31);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvEtiquetasFianza
            // 
            this.dgvEtiquetasFianza.AllowUserToAddRows = false;
            this.dgvEtiquetasFianza.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvEtiquetasFianza.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEtiquetasFianza.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEtiquetasFianza.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEtiquetasFianza.ColumnHeadersHeight = 30;
            this.dgvEtiquetasFianza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEtiquetasFianza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroDeFianza,
            this.Año,
            this.NroArchivo,
            this.Contribuyente,
            this.NaturalezaDeLaOperación});
            this.dgvEtiquetasFianza.EnableHeadersVisualStyles = false;
            this.dgvEtiquetasFianza.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvEtiquetasFianza.Location = new System.Drawing.Point(44, 155);
            this.dgvEtiquetasFianza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEtiquetasFianza.Name = "dgvEtiquetasFianza";
            this.dgvEtiquetasFianza.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEtiquetasFianza.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEtiquetasFianza.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEtiquetasFianza.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEtiquetasFianza.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEtiquetasFianza.Size = new System.Drawing.Size(725, 146);
            this.dgvEtiquetasFianza.TabIndex = 8;
            // 
            // NroDeFianza
            // 
            this.NroDeFianza.FillWeight = 60F;
            this.NroDeFianza.HeaderText = "Nro. de Fianza";
            this.NroDeFianza.Name = "NroDeFianza";
            this.NroDeFianza.Width = 180;
            // 
            // Año
            // 
            this.Año.HeaderText = "Año";
            this.Año.Name = "Año";
            this.Año.Width = 50;
            // 
            // NroArchivo
            // 
            this.NroArchivo.FillWeight = 60F;
            this.NroArchivo.HeaderText = "Nro. de Archivo";
            this.NroArchivo.Name = "NroArchivo";
            this.NroArchivo.Width = 130;
            // 
            // Contribuyente
            // 
            this.Contribuyente.HeaderText = "Contribuyente";
            this.Contribuyente.Name = "Contribuyente";
            this.Contribuyente.Width = 290;
            // 
            // NaturalezaDeLaOperación
            // 
            this.NaturalezaDeLaOperación.HeaderText = "Naturaleza de la Operación";
            this.NaturalezaDeLaOperación.Name = "NaturalezaDeLaOperación";
            this.NaturalezaDeLaOperación.Width = 240;
            // 
            // cbNroFianza
            // 
            this.cbNroFianza.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNroFianza.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNroFianza.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbNroFianza.ForeColor = System.Drawing.Color.Maroon;
            this.cbNroFianza.FormattingEnabled = true;
            this.cbNroFianza.Location = new System.Drawing.Point(1107, 78);
            this.cbNroFianza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNroFianza.Name = "cbNroFianza";
            this.cbNroFianza.Size = new System.Drawing.Size(332, 31);
            this.cbNroFianza.TabIndex = 3;
            this.cbNroFianza.SelectedIndexChanged += new System.EventHandler(this.cbNroFianza_SelectedIndexChanged);
            // 
            // btnEliminarFianza
            // 
            this.btnEliminarFianza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(61)))), ((int)(((byte)(24)))));
            this.btnEliminarFianza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarFianza.FlatAppearance.BorderSize = 0;
            this.btnEliminarFianza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(86)))), ((int)(((byte)(49)))));
            this.btnEliminarFianza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarFianza.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFianza.ForeColor = System.Drawing.Color.White;
            this.btnEliminarFianza.Location = new System.Drawing.Point(44, 332);
            this.btnEliminarFianza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarFianza.Name = "btnEliminarFianza";
            this.btnEliminarFianza.Size = new System.Drawing.Size(215, 39);
            this.btnEliminarFianza.TabIndex = 39;
            this.btnEliminarFianza.Text = "Eliminar Fianza";
            this.btnEliminarFianza.UseVisualStyleBackColor = false;
            this.btnEliminarFianza.Click += new System.EventHandler(this.btnEliminarFianza_Click);
            // 
            // lFecha
            // 
            this.lFecha.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lFecha.ForeColor = System.Drawing.Color.Lime;
            this.lFecha.Location = new System.Drawing.Point(287, 325);
            this.lFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(321, 57);
            this.lFecha.TabIndex = 40;
            this.lFecha.Text = "Presione este botón para eliminar una fianza ingresada por error.";
            this.lFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormEtiquetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1487, 400);
            this.Controls.Add(this.lFecha);
            this.Controls.Add(this.btnEliminarFianza);
            this.Controls.Add(this.cbNroFianza);
            this.Controls.Add(this.dgvEtiquetasFianza);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.tbTipoDeFianza);
            this.Controls.Add(this.btnAgregarFianza);
            this.Controls.Add(this.btnGenerarEtiquetas);
            this.Controls.Add(this.lIntroduzcaAño);
            this.Controls.Add(this.lNaturalezaOperacion);
            this.Controls.Add(this.tbNombreConsignatario);
            this.Controls.Add(this.lContribuyente);
            this.Controls.Add(this.lArchivo);
            this.Controls.Add(this.tbArchivo);
            this.Controls.Add(this.tbAño);
            this.Controls.Add(this.lAño);
            this.Controls.Add(this.lNroFianza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEtiquetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Información para las Etiquetas";
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtiquetasFianza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNroFianza;
        private System.Windows.Forms.TextBox tbAño;
        private System.Windows.Forms.Label lAño;
        private System.Windows.Forms.Label lArchivo;
        private System.Windows.Forms.TextBox tbArchivo;
        private System.Windows.Forms.Label lContribuyente;
        private System.Windows.Forms.TextBox tbNombreConsignatario;
        private System.Windows.Forms.Label lNaturalezaOperacion;
        private System.Windows.Forms.Label lIntroduzcaAño;
        private System.Windows.Forms.Button btnAgregarFianza;
        private System.Windows.Forms.Button btnGenerarEtiquetas;
        private System.Windows.Forms.TextBox tbTipoDeFianza;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Label lInformacionEtiquetas;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.DataGridView dgvEtiquetasFianza;
        private System.Windows.Forms.ComboBox cbNroFianza;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroDeFianza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Año;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contribuyente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NaturalezaDeLaOperación;
        private System.Windows.Forms.Button btnEliminarFianza;
        private System.Windows.Forms.Label lFecha;
    }
}