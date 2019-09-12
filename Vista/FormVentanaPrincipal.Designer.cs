namespace Vista
{
    partial class FormVentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentanaPrincipal));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lFormularioFianzas = new System.Windows.Forms.Label();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.lCopyright = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnNotificaciones = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnActualizarInfo = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLiberacion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnFianzas = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraTitulo.Controls.Add(this.lFormularioFianzas);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1200, 38);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // lFormularioFianzas
            // 
            this.lFormularioFianzas.AutoSize = true;
            this.lFormularioFianzas.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lFormularioFianzas.ForeColor = System.Drawing.Color.White;
            this.lFormularioFianzas.Location = new System.Drawing.Point(3, 9);
            this.lFormularioFianzas.Name = "lFormularioFianzas";
            this.lFormularioFianzas.Size = new System.Drawing.Size(229, 20);
            this.lFormularioFianzas.TabIndex = 4;
            this.lFormularioFianzas.Text = "Formulario Principal de Fianzas";
            this.lFormularioFianzas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lFormularioFianzas_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1122, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1162, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(220, 38);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(980, 577);
            this.panelContenedor.TabIndex = 4;
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVertical.Controls.Add(this.lCopyright);
            this.MenuVertical.Controls.Add(this.panel7);
            this.MenuVertical.Controls.Add(this.btnNotificaciones);
            this.MenuVertical.Controls.Add(this.panel6);
            this.MenuVertical.Controls.Add(this.btnActualizarInfo);
            this.MenuVertical.Controls.Add(this.panel3);
            this.MenuVertical.Controls.Add(this.btnLiberacion);
            this.MenuVertical.Controls.Add(this.panel2);
            this.MenuVertical.Controls.Add(this.btnConsultas);
            this.MenuVertical.Controls.Add(this.panel9);
            this.MenuVertical.Controls.Add(this.btnFianzas);
            this.MenuVertical.Controls.Add(this.btnInicio);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 38);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(220, 577);
            this.MenuVertical.TabIndex = 3;
            // 
            // lCopyright
            // 
            this.lCopyright.AutoSize = true;
            this.lCopyright.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lCopyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.lCopyright.Location = new System.Drawing.Point(79, 474);
            this.lCopyright.Name = "lCopyright";
            this.lCopyright.Size = new System.Drawing.Size(59, 18);
            this.lCopyright.TabIndex = 21;
            this.lCopyright.Text = "©  2019";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel7.Location = new System.Drawing.Point(0, 345);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 32);
            this.panel7.TabIndex = 14;
            // 
            // btnNotificaciones
            // 
            this.btnNotificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnNotificaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotificaciones.FlatAppearance.BorderSize = 0;
            this.btnNotificaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnNotificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificaciones.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnNotificaciones.ForeColor = System.Drawing.Color.White;
            this.btnNotificaciones.Image = ((System.Drawing.Image)(resources.GetObject("btnNotificaciones.Image")));
            this.btnNotificaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotificaciones.Location = new System.Drawing.Point(3, 345);
            this.btnNotificaciones.Name = "btnNotificaciones";
            this.btnNotificaciones.Size = new System.Drawing.Size(217, 32);
            this.btnNotificaciones.TabIndex = 13;
            this.btnNotificaciones.Text = "               Notificaciones";
            this.btnNotificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotificaciones.UseVisualStyleBackColor = false;
            this.btnNotificaciones.Click += new System.EventHandler(this.btnNotificaciones_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(0, 307);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 32);
            this.panel6.TabIndex = 12;
            // 
            // btnActualizarInfo
            // 
            this.btnActualizarInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnActualizarInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarInfo.FlatAppearance.BorderSize = 0;
            this.btnActualizarInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnActualizarInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnActualizarInfo.ForeColor = System.Drawing.Color.White;
            this.btnActualizarInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarInfo.Image")));
            this.btnActualizarInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarInfo.Location = new System.Drawing.Point(3, 307);
            this.btnActualizarInfo.Name = "btnActualizarInfo";
            this.btnActualizarInfo.Size = new System.Drawing.Size(217, 32);
            this.btnActualizarInfo.TabIndex = 11;
            this.btnActualizarInfo.Text = "               Actualizar Info";
            this.btnActualizarInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarInfo.UseVisualStyleBackColor = false;
            this.btnActualizarInfo.Click += new System.EventHandler(this.btnActualizarInfo_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(0, 269);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 32);
            this.panel3.TabIndex = 6;
            // 
            // btnLiberacion
            // 
            this.btnLiberacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLiberacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLiberacion.FlatAppearance.BorderSize = 0;
            this.btnLiberacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnLiberacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiberacion.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnLiberacion.ForeColor = System.Drawing.Color.White;
            this.btnLiberacion.Image = ((System.Drawing.Image)(resources.GetObject("btnLiberacion.Image")));
            this.btnLiberacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLiberacion.Location = new System.Drawing.Point(3, 269);
            this.btnLiberacion.Name = "btnLiberacion";
            this.btnLiberacion.Size = new System.Drawing.Size(217, 32);
            this.btnLiberacion.TabIndex = 5;
            this.btnLiberacion.Text = "               Liberación";
            this.btnLiberacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLiberacion.UseVisualStyleBackColor = false;
            this.btnLiberacion.Click += new System.EventHandler(this.btnLiberacion_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(0, 231);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 32);
            this.panel2.TabIndex = 4;
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnConsultas.ForeColor = System.Drawing.Color.White;
            this.btnConsultas.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultas.Image")));
            this.btnConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.Location = new System.Drawing.Point(3, 231);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(217, 32);
            this.btnConsultas.TabIndex = 3;
            this.btnConsultas.Text = "               Consultas";
            this.btnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel9.Location = new System.Drawing.Point(0, 193);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(5, 32);
            this.panel9.TabIndex = 2;
            // 
            // btnFianzas
            // 
            this.btnFianzas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnFianzas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFianzas.FlatAppearance.BorderSize = 0;
            this.btnFianzas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnFianzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFianzas.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnFianzas.ForeColor = System.Drawing.Color.White;
            this.btnFianzas.Image = ((System.Drawing.Image)(resources.GetObject("btnFianzas.Image")));
            this.btnFianzas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFianzas.Location = new System.Drawing.Point(3, 193);
            this.btnFianzas.Name = "btnFianzas";
            this.btnFianzas.Size = new System.Drawing.Size(217, 32);
            this.btnFianzas.TabIndex = 1;
            this.btnFianzas.Text = "               Fianzas";
            this.btnFianzas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFianzas.UseVisualStyleBackColor = false;
            this.btnFianzas.Click += new System.EventHandler(this.btnFianzas_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.Location = new System.Drawing.Point(0, 60);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(220, 49);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicio.TabIndex = 0;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // FormVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 615);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal de Fianzas";
            this.Load += new System.EventHandler(this.FormVentanaPrincipal_Load);
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Label lCopyright;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnNotificaciones;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnActualizarInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLiberacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnFianzas;
        private System.Windows.Forms.PictureBox btnInicio;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.Label lFormularioFianzas;

    }
}

