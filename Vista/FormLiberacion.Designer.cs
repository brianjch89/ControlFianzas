namespace Vista
{
    partial class FormLiberacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLiberacion));
            this.panelIncluirFianzas = new System.Windows.Forms.Panel();
            this.lHoraEdicion = new System.Windows.Forms.Label();
            this.lFechaEdicion = new System.Windows.Forms.Label();
            this.lLiberacionFianza = new System.Windows.Forms.Label();
            this.tbAño = new System.Windows.Forms.TextBox();
            this.lNroFianza = new System.Windows.Forms.Label();
            this.lAño = new System.Windows.Forms.Label();
            this.lGarante = new System.Windows.Forms.Label();
            this.cbNaturalezaOperacion = new System.Windows.Forms.ComboBox();
            this.lMonto = new System.Windows.Forms.Label();
            this.cbContribuyente = new System.Windows.Forms.ComboBox();
            this.lAgenda = new System.Windows.Forms.Label();
            this.cbAgente = new System.Windows.Forms.ComboBox();
            this.lContribuyente = new System.Windows.Forms.Label();
            this.cbGarante = new System.Windows.Forms.ComboBox();
            this.lNaturalezaOperacion = new System.Windows.Forms.Label();
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.tbNroFianza = new System.Windows.Forms.TextBox();
            this.panelFechasFianzas = new System.Windows.Forms.Panel();
            this.lFianzasAlmacenadas = new System.Windows.Forms.Label();
            this.lSistemaPECDF = new System.Windows.Forms.Label();
            this.lArchivo = new System.Windows.Forms.Label();
            this.dtpRecibida = new System.Windows.Forms.DateTimePicker();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpEmision = new System.Windows.Forms.DateTimePicker();
            this.tbArchivo = new System.Windows.Forms.TextBox();
            this.lEmisión = new System.Windows.Forms.Label();
            this.lVencimiento = new System.Windows.Forms.Label();
            this.lRecibida = new System.Windows.Forms.Label();
            this.panelAsuntoOficio = new System.Windows.Forms.Panel();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.lFechaRegistro = new System.Windows.Forms.Label();
            this.lNro = new System.Windows.Forms.Label();
            this.tbNro = new System.Windows.Forms.TextBox();
            this.lTomo = new System.Windows.Forms.Label();
            this.tbTomo = new System.Windows.Forms.TextBox();
            this.tbNotaria = new System.Windows.Forms.TextBox();
            this.lNotaria = new System.Windows.Forms.Label();
            this.lOficio = new System.Windows.Forms.Label();
            this.cbOficio = new System.Windows.Forms.ComboBox();
            this.tbAsunto = new System.Windows.Forms.TextBox();
            this.lAsunto = new System.Windows.Forms.Label();
            this.panelInferiorBotones = new System.Windows.Forms.Panel();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnSiguienteEdicion = new System.Windows.Forms.Button();
            this.bAnteriorEdicion = new System.Windows.Forms.Button();
            this.btnBuscarLiberacion = new System.Windows.Forms.Button();
            this.btnDatosLiberacion = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelIncluirFianzas.SuspendLayout();
            this.panelFechasFianzas.SuspendLayout();
            this.panelAsuntoOficio.SuspendLayout();
            this.panelInferiorBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelIncluirFianzas
            // 
            this.panelIncluirFianzas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelIncluirFianzas.Controls.Add(this.lHoraEdicion);
            this.panelIncluirFianzas.Controls.Add(this.lFechaEdicion);
            this.panelIncluirFianzas.Controls.Add(this.lLiberacionFianza);
            this.panelIncluirFianzas.Controls.Add(this.tbAño);
            this.panelIncluirFianzas.Controls.Add(this.lNroFianza);
            this.panelIncluirFianzas.Controls.Add(this.lAño);
            this.panelIncluirFianzas.Controls.Add(this.lGarante);
            this.panelIncluirFianzas.Controls.Add(this.cbNaturalezaOperacion);
            this.panelIncluirFianzas.Controls.Add(this.lMonto);
            this.panelIncluirFianzas.Controls.Add(this.cbContribuyente);
            this.panelIncluirFianzas.Controls.Add(this.lAgenda);
            this.panelIncluirFianzas.Controls.Add(this.cbAgente);
            this.panelIncluirFianzas.Controls.Add(this.lContribuyente);
            this.panelIncluirFianzas.Controls.Add(this.cbGarante);
            this.panelIncluirFianzas.Controls.Add(this.lNaturalezaOperacion);
            this.panelIncluirFianzas.Controls.Add(this.tbMonto);
            this.panelIncluirFianzas.Controls.Add(this.tbNroFianza);
            this.panelIncluirFianzas.Location = new System.Drawing.Point(0, 0);
            this.panelIncluirFianzas.Name = "panelIncluirFianzas";
            this.panelIncluirFianzas.Size = new System.Drawing.Size(500, 303);
            this.panelIncluirFianzas.TabIndex = 17;
            // 
            // lHoraEdicion
            // 
            this.lHoraEdicion.AutoSize = true;
            this.lHoraEdicion.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lHoraEdicion.ForeColor = System.Drawing.Color.Lime;
            this.lHoraEdicion.Location = new System.Drawing.Point(3, 26);
            this.lHoraEdicion.Name = "lHoraEdicion";
            this.lHoraEdicion.Size = new System.Drawing.Size(0, 20);
            this.lHoraEdicion.TabIndex = 21;
            // 
            // lFechaEdicion
            // 
            this.lFechaEdicion.AutoSize = true;
            this.lFechaEdicion.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lFechaEdicion.ForeColor = System.Drawing.Color.Lime;
            this.lFechaEdicion.Location = new System.Drawing.Point(3, 3);
            this.lFechaEdicion.Name = "lFechaEdicion";
            this.lFechaEdicion.Size = new System.Drawing.Size(0, 20);
            this.lFechaEdicion.TabIndex = 20;
            // 
            // lLiberacionFianza
            // 
            this.lLiberacionFianza.AutoSize = true;
            this.lLiberacionFianza.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lLiberacionFianza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.lLiberacionFianza.Location = new System.Drawing.Point(240, 20);
            this.lLiberacionFianza.Name = "lLiberacionFianza";
            this.lLiberacionFianza.Size = new System.Drawing.Size(244, 26);
            this.lLiberacionFianza.TabIndex = 0;
            this.lLiberacionFianza.Text = "Liberación de Fianzas";
            // 
            // tbAño
            // 
            this.tbAño.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbAño.ForeColor = System.Drawing.Color.Maroon;
            this.tbAño.Location = new System.Drawing.Point(432, 140);
            this.tbAño.Margin = new System.Windows.Forms.Padding(0);
            this.tbAño.MaxLength = 4;
            this.tbAño.Name = "tbAño";
            this.tbAño.Size = new System.Drawing.Size(52, 26);
            this.tbAño.TabIndex = 4;
            this.tbAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAño_KeyPress);
            // 
            // lNroFianza
            // 
            this.lNroFianza.AutoSize = true;
            this.lNroFianza.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lNroFianza.ForeColor = System.Drawing.Color.Lavender;
            this.lNroFianza.Location = new System.Drawing.Point(116, 74);
            this.lNroFianza.Margin = new System.Windows.Forms.Padding(0);
            this.lNroFianza.Name = "lNroFianza";
            this.lNroFianza.Size = new System.Drawing.Size(113, 18);
            this.lNroFianza.TabIndex = 1;
            this.lNroFianza.Text = "Nro. de Fianza";
            // 
            // lAño
            // 
            this.lAño.AutoSize = true;
            this.lAño.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lAño.ForeColor = System.Drawing.Color.Lavender;
            this.lAño.Location = new System.Drawing.Point(387, 143);
            this.lAño.Margin = new System.Windows.Forms.Padding(0);
            this.lAño.Name = "lAño";
            this.lAño.Size = new System.Drawing.Size(38, 18);
            this.lAño.TabIndex = 13;
            this.lAño.Text = "Año";
            // 
            // lGarante
            // 
            this.lGarante.AutoSize = true;
            this.lGarante.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lGarante.ForeColor = System.Drawing.Color.Lavender;
            this.lGarante.Location = new System.Drawing.Point(157, 107);
            this.lGarante.Margin = new System.Windows.Forms.Padding(0);
            this.lGarante.Name = "lGarante";
            this.lGarante.Size = new System.Drawing.Size(69, 18);
            this.lGarante.TabIndex = 2;
            this.lGarante.Text = "Garante";
            // 
            // cbNaturalezaOperacion
            // 
            this.cbNaturalezaOperacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNaturalezaOperacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNaturalezaOperacion.DisplayMember = "DesTipFian";
            this.cbNaturalezaOperacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbNaturalezaOperacion.FormattingEnabled = true;
            this.cbNaturalezaOperacion.Location = new System.Drawing.Point(234, 247);
            this.cbNaturalezaOperacion.Name = "cbNaturalezaOperacion";
            this.cbNaturalezaOperacion.Size = new System.Drawing.Size(250, 26);
            this.cbNaturalezaOperacion.TabIndex = 7;
            this.cbNaturalezaOperacion.ValueMember = "DesTipFian";
            this.cbNaturalezaOperacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNaturalezaOperacion_KeyPress);
            // 
            // lMonto
            // 
            this.lMonto.AutoSize = true;
            this.lMonto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lMonto.ForeColor = System.Drawing.Color.Lavender;
            this.lMonto.Location = new System.Drawing.Point(170, 143);
            this.lMonto.Margin = new System.Windows.Forms.Padding(0);
            this.lMonto.Name = "lMonto";
            this.lMonto.Size = new System.Drawing.Size(55, 18);
            this.lMonto.TabIndex = 3;
            this.lMonto.Text = "Monto";
            // 
            // cbContribuyente
            // 
            this.cbContribuyente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbContribuyente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbContribuyente.DisplayMember = "Nombre_Consignatario";
            this.cbContribuyente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbContribuyente.FormattingEnabled = true;
            this.cbContribuyente.Location = new System.Drawing.Point(234, 210);
            this.cbContribuyente.Name = "cbContribuyente";
            this.cbContribuyente.Size = new System.Drawing.Size(250, 26);
            this.cbContribuyente.TabIndex = 6;
            this.cbContribuyente.ValueMember = "Nombre_Consignatario";
            this.cbContribuyente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbContribuyente_KeyPress);
            // 
            // lAgenda
            // 
            this.lAgenda.AutoSize = true;
            this.lAgenda.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lAgenda.ForeColor = System.Drawing.Color.Lavender;
            this.lAgenda.Location = new System.Drawing.Point(164, 177);
            this.lAgenda.Name = "lAgenda";
            this.lAgenda.Size = new System.Drawing.Size(62, 18);
            this.lAgenda.TabIndex = 4;
            this.lAgenda.Text = "Agente";
            // 
            // cbAgente
            // 
            this.cbAgente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAgente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAgente.DisplayMember = "Nombre_Agente";
            this.cbAgente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbAgente.FormattingEnabled = true;
            this.cbAgente.Location = new System.Drawing.Point(234, 174);
            this.cbAgente.Name = "cbAgente";
            this.cbAgente.Size = new System.Drawing.Size(250, 26);
            this.cbAgente.TabIndex = 5;
            this.cbAgente.ValueMember = "Nombre_Agente";
            this.cbAgente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAgente_KeyPress);
            // 
            // lContribuyente
            // 
            this.lContribuyente.AutoSize = true;
            this.lContribuyente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lContribuyente.ForeColor = System.Drawing.Color.Lavender;
            this.lContribuyente.Location = new System.Drawing.Point(114, 213);
            this.lContribuyente.Name = "lContribuyente";
            this.lContribuyente.Size = new System.Drawing.Size(113, 18);
            this.lContribuyente.TabIndex = 5;
            this.lContribuyente.Text = "Contribuyente";
            // 
            // cbGarante
            // 
            this.cbGarante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGarante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGarante.DisplayMember = "Nombre_Garante";
            this.cbGarante.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbGarante.FormattingEnabled = true;
            this.cbGarante.Location = new System.Drawing.Point(234, 104);
            this.cbGarante.Margin = new System.Windows.Forms.Padding(0);
            this.cbGarante.Name = "cbGarante";
            this.cbGarante.Size = new System.Drawing.Size(250, 26);
            this.cbGarante.TabIndex = 2;
            this.cbGarante.ValueMember = "Nombre_Garante";
            this.cbGarante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbGarante_KeyPress);
            // 
            // lNaturalezaOperacion
            // 
            this.lNaturalezaOperacion.AutoSize = true;
            this.lNaturalezaOperacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lNaturalezaOperacion.ForeColor = System.Drawing.Color.Lavender;
            this.lNaturalezaOperacion.Location = new System.Drawing.Point(15, 250);
            this.lNaturalezaOperacion.Name = "lNaturalezaOperacion";
            this.lNaturalezaOperacion.Size = new System.Drawing.Size(215, 18);
            this.lNaturalezaOperacion.TabIndex = 6;
            this.lNaturalezaOperacion.Text = "Naturaleza de la Operación";
            // 
            // tbMonto
            // 
            this.tbMonto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbMonto.Location = new System.Drawing.Point(234, 140);
            this.tbMonto.Margin = new System.Windows.Forms.Padding(0);
            this.tbMonto.Name = "tbMonto";
            this.tbMonto.Size = new System.Drawing.Size(140, 26);
            this.tbMonto.TabIndex = 3;
            this.tbMonto.Text = "0,00";
            this.tbMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbMonto.TextChanged += new System.EventHandler(this.tbMonto_TextChanged);
            this.tbMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMonto_KeyPress);
            // 
            // tbNroFianza
            // 
            this.tbNroFianza.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbNroFianza.ForeColor = System.Drawing.Color.Maroon;
            this.tbNroFianza.Location = new System.Drawing.Point(234, 68);
            this.tbNroFianza.Margin = new System.Windows.Forms.Padding(0);
            this.tbNroFianza.MaxLength = 35;
            this.tbNroFianza.Name = "tbNroFianza";
            this.tbNroFianza.Size = new System.Drawing.Size(250, 26);
            this.tbNroFianza.TabIndex = 1;
            this.tbNroFianza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNroFianza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNroFianza_KeyPress);
            // 
            // panelFechasFianzas
            // 
            this.panelFechasFianzas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelFechasFianzas.Controls.Add(this.lFianzasAlmacenadas);
            this.panelFechasFianzas.Controls.Add(this.lSistemaPECDF);
            this.panelFechasFianzas.Controls.Add(this.lArchivo);
            this.panelFechasFianzas.Controls.Add(this.dtpRecibida);
            this.panelFechasFianzas.Controls.Add(this.dtpVencimiento);
            this.panelFechasFianzas.Controls.Add(this.dtpEmision);
            this.panelFechasFianzas.Controls.Add(this.tbArchivo);
            this.panelFechasFianzas.Controls.Add(this.lEmisión);
            this.panelFechasFianzas.Controls.Add(this.lVencimiento);
            this.panelFechasFianzas.Controls.Add(this.lRecibida);
            this.panelFechasFianzas.Location = new System.Drawing.Point(500, 0);
            this.panelFechasFianzas.Name = "panelFechasFianzas";
            this.panelFechasFianzas.Size = new System.Drawing.Size(480, 303);
            this.panelFechasFianzas.TabIndex = 18;
            // 
            // lFianzasAlmacenadas
            // 
            this.lFianzasAlmacenadas.AutoSize = true;
            this.lFianzasAlmacenadas.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lFianzasAlmacenadas.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lFianzasAlmacenadas.Location = new System.Drawing.Point(6, 9);
            this.lFianzasAlmacenadas.Name = "lFianzasAlmacenadas";
            this.lFianzasAlmacenadas.Size = new System.Drawing.Size(0, 20);
            this.lFianzasAlmacenadas.TabIndex = 20;
            // 
            // lSistemaPECDF
            // 
            this.lSistemaPECDF.AutoSize = true;
            this.lSistemaPECDF.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.lSistemaPECDF.ForeColor = System.Drawing.Color.SeaGreen;
            this.lSistemaPECDF.Location = new System.Drawing.Point(77, 245);
            this.lSistemaPECDF.Name = "lSistemaPECDF";
            this.lSistemaPECDF.Size = new System.Drawing.Size(329, 23);
            this.lSistemaPECDF.TabIndex = 19;
            this.lSistemaPECDF.Text = "Sistema para el Control de Fianzas";
            this.lSistemaPECDF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lArchivo
            // 
            this.lArchivo.AutoSize = true;
            this.lArchivo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lArchivo.ForeColor = System.Drawing.Color.Lavender;
            this.lArchivo.Location = new System.Drawing.Point(188, 191);
            this.lArchivo.Name = "lArchivo";
            this.lArchivo.Size = new System.Drawing.Size(65, 18);
            this.lArchivo.TabIndex = 18;
            this.lArchivo.Text = "Archivo";
            // 
            // dtpRecibida
            // 
            this.dtpRecibida.CustomFormat = "";
            this.dtpRecibida.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtpRecibida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRecibida.Location = new System.Drawing.Point(234, 143);
            this.dtpRecibida.Name = "dtpRecibida";
            this.dtpRecibida.Size = new System.Drawing.Size(122, 26);
            this.dtpRecibida.TabIndex = 10;
            this.dtpRecibida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpRecibida_KeyPress);
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.CustomFormat = "";
            this.dtpVencimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimiento.Location = new System.Drawing.Point(234, 106);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(122, 26);
            this.dtpVencimiento.TabIndex = 9;
            this.dtpVencimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpVencimiento_KeyPress);
            // 
            // dtpEmision
            // 
            this.dtpEmision.CustomFormat = "";
            this.dtpEmision.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtpEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmision.Location = new System.Drawing.Point(234, 66);
            this.dtpEmision.Name = "dtpEmision";
            this.dtpEmision.Size = new System.Drawing.Size(122, 26);
            this.dtpEmision.TabIndex = 8;
            this.dtpEmision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpEmision_KeyPress);
            // 
            // tbArchivo
            // 
            this.tbArchivo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbArchivo.ForeColor = System.Drawing.Color.Maroon;
            this.tbArchivo.Location = new System.Drawing.Point(259, 187);
            this.tbArchivo.Name = "tbArchivo";
            this.tbArchivo.Size = new System.Drawing.Size(52, 26);
            this.tbArchivo.TabIndex = 11;
            this.tbArchivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbArchivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbArchivo_KeyPress);
            // 
            // lEmisión
            // 
            this.lEmisión.AutoSize = true;
            this.lEmisión.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lEmisión.ForeColor = System.Drawing.Color.Lavender;
            this.lEmisión.Location = new System.Drawing.Point(164, 72);
            this.lEmisión.Name = "lEmisión";
            this.lEmisión.Size = new System.Drawing.Size(63, 18);
            this.lEmisión.TabIndex = 1;
            this.lEmisión.Text = "Emisión";
            // 
            // lVencimiento
            // 
            this.lVencimiento.AutoSize = true;
            this.lVencimiento.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lVencimiento.ForeColor = System.Drawing.Color.Lavender;
            this.lVencimiento.Location = new System.Drawing.Point(124, 108);
            this.lVencimiento.Name = "lVencimiento";
            this.lVencimiento.Size = new System.Drawing.Size(103, 18);
            this.lVencimiento.TabIndex = 2;
            this.lVencimiento.Text = "Vencimiento";
            // 
            // lRecibida
            // 
            this.lRecibida.AutoSize = true;
            this.lRecibida.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lRecibida.ForeColor = System.Drawing.Color.Lavender;
            this.lRecibida.Location = new System.Drawing.Point(152, 144);
            this.lRecibida.Name = "lRecibida";
            this.lRecibida.Size = new System.Drawing.Size(75, 18);
            this.lRecibida.TabIndex = 3;
            this.lRecibida.Text = "Recibida";
            // 
            // panelAsuntoOficio
            // 
            this.panelAsuntoOficio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelAsuntoOficio.Controls.Add(this.dtpFechaRegistro);
            this.panelAsuntoOficio.Controls.Add(this.lFechaRegistro);
            this.panelAsuntoOficio.Controls.Add(this.lNro);
            this.panelAsuntoOficio.Controls.Add(this.tbNro);
            this.panelAsuntoOficio.Controls.Add(this.lTomo);
            this.panelAsuntoOficio.Controls.Add(this.tbTomo);
            this.panelAsuntoOficio.Controls.Add(this.tbNotaria);
            this.panelAsuntoOficio.Controls.Add(this.lNotaria);
            this.panelAsuntoOficio.Controls.Add(this.lOficio);
            this.panelAsuntoOficio.Controls.Add(this.cbOficio);
            this.panelAsuntoOficio.Controls.Add(this.tbAsunto);
            this.panelAsuntoOficio.Controls.Add(this.lAsunto);
            this.panelAsuntoOficio.Location = new System.Drawing.Point(0, 303);
            this.panelAsuntoOficio.Name = "panelAsuntoOficio";
            this.panelAsuntoOficio.Size = new System.Drawing.Size(980, 225);
            this.panelAsuntoOficio.TabIndex = 19;
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.CustomFormat = "";
            this.dtpFechaRegistro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(724, 178);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(122, 26);
            this.dtpFechaRegistro.TabIndex = 17;
            this.dtpFechaRegistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaRegistro_KeyPress);
            // 
            // lFechaRegistro
            // 
            this.lFechaRegistro.AutoSize = true;
            this.lFechaRegistro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lFechaRegistro.ForeColor = System.Drawing.Color.Lavender;
            this.lFechaRegistro.Location = new System.Drawing.Point(716, 144);
            this.lFechaRegistro.Name = "lFechaRegistro";
            this.lFechaRegistro.Size = new System.Drawing.Size(140, 18);
            this.lFechaRegistro.TabIndex = 19;
            this.lFechaRegistro.Text = "Fecha de Registro";
            // 
            // lNro
            // 
            this.lNro.AutoSize = true;
            this.lNro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lNro.ForeColor = System.Drawing.Color.Lavender;
            this.lNro.Location = new System.Drawing.Point(698, 99);
            this.lNro.Name = "lNro";
            this.lNro.Size = new System.Drawing.Size(34, 18);
            this.lNro.TabIndex = 17;
            this.lNro.Text = "Nro";
            // 
            // tbNro
            // 
            this.tbNro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbNro.Location = new System.Drawing.Point(738, 95);
            this.tbNro.MaxLength = 3;
            this.tbNro.Name = "tbNro";
            this.tbNro.Size = new System.Drawing.Size(89, 26);
            this.tbNro.TabIndex = 16;
            this.tbNro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbNro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNro_KeyPress);
            // 
            // lTomo
            // 
            this.lTomo.AutoSize = true;
            this.lTomo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lTomo.ForeColor = System.Drawing.Color.Lavender;
            this.lTomo.Location = new System.Drawing.Point(405, 182);
            this.lTomo.Name = "lTomo";
            this.lTomo.Size = new System.Drawing.Size(48, 18);
            this.lTomo.TabIndex = 15;
            this.lTomo.Text = "Tomo";
            // 
            // tbTomo
            // 
            this.tbTomo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbTomo.Location = new System.Drawing.Point(460, 178);
            this.tbTomo.MaxLength = 3;
            this.tbTomo.Name = "tbTomo";
            this.tbTomo.Size = new System.Drawing.Size(130, 26);
            this.tbTomo.TabIndex = 14;
            this.tbTomo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTomo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTomo_KeyPress);
            // 
            // tbNotaria
            // 
            this.tbNotaria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.tbNotaria.Location = new System.Drawing.Point(113, 178);
            this.tbNotaria.MaxLength = 255;
            this.tbNotaria.Name = "tbNotaria";
            this.tbNotaria.Size = new System.Drawing.Size(250, 26);
            this.tbNotaria.TabIndex = 13;
            this.tbNotaria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNotaria_KeyPress);
            // 
            // lNotaria
            // 
            this.lNotaria.AutoSize = true;
            this.lNotaria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lNotaria.ForeColor = System.Drawing.Color.Lavender;
            this.lNotaria.Location = new System.Drawing.Point(45, 182);
            this.lNotaria.Name = "lNotaria";
            this.lNotaria.Size = new System.Drawing.Size(62, 18);
            this.lNotaria.TabIndex = 13;
            this.lNotaria.Text = "Notaría";
            // 
            // lOficio
            // 
            this.lOficio.AutoSize = true;
            this.lOficio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lOficio.ForeColor = System.Drawing.Color.Lavender;
            this.lOficio.Location = new System.Drawing.Point(756, 12);
            this.lOficio.Name = "lOficio";
            this.lOficio.Size = new System.Drawing.Size(53, 18);
            this.lOficio.TabIndex = 11;
            this.lOficio.Text = "Oficio";
            // 
            // cbOficio
            // 
            this.cbOficio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbOficio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOficio.DisplayMember = "NroOficio";
            this.cbOficio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbOficio.FormattingEnabled = true;
            this.cbOficio.Location = new System.Drawing.Point(656, 42);
            this.cbOficio.Name = "cbOficio";
            this.cbOficio.Size = new System.Drawing.Size(250, 26);
            this.cbOficio.TabIndex = 15;
            this.cbOficio.ValueMember = "NroOficio";
            this.cbOficio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbOficio_KeyPress);
            // 
            // tbAsunto
            // 
            this.tbAsunto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.tbAsunto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbAsunto.Location = new System.Drawing.Point(46, 42);
            this.tbAsunto.Multiline = true;
            this.tbAsunto.Name = "tbAsunto";
            this.tbAsunto.Size = new System.Drawing.Size(482, 120);
            this.tbAsunto.TabIndex = 12;
            this.tbAsunto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAsunto_KeyPress);
            // 
            // lAsunto
            // 
            this.lAsunto.AutoSize = true;
            this.lAsunto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lAsunto.ForeColor = System.Drawing.Color.Lavender;
            this.lAsunto.Location = new System.Drawing.Point(43, 12);
            this.lAsunto.Name = "lAsunto";
            this.lAsunto.Size = new System.Drawing.Size(57, 18);
            this.lAsunto.TabIndex = 2;
            this.lAsunto.Text = "Asunto";
            // 
            // panelInferiorBotones
            // 
            this.panelInferiorBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.panelInferiorBotones.Controls.Add(this.btnUltimo);
            this.panelInferiorBotones.Controls.Add(this.btnPrimero);
            this.panelInferiorBotones.Controls.Add(this.btnSiguienteEdicion);
            this.panelInferiorBotones.Controls.Add(this.bAnteriorEdicion);
            this.panelInferiorBotones.Controls.Add(this.btnBuscarLiberacion);
            this.panelInferiorBotones.Controls.Add(this.btnDatosLiberacion);
            this.panelInferiorBotones.Location = new System.Drawing.Point(0, 526);
            this.panelInferiorBotones.Name = "panelInferiorBotones";
            this.panelInferiorBotones.Size = new System.Drawing.Size(980, 51);
            this.panelInferiorBotones.TabIndex = 20;
            // 
            // btnUltimo
            // 
            this.btnUltimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(40)))), ((int)(((byte)(191)))));
            this.btnUltimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUltimo.FlatAppearance.BorderSize = 0;
            this.btnUltimo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(93)))), ((int)(((byte)(191)))));
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.ForeColor = System.Drawing.Color.White;
            this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
            this.btnUltimo.Location = new System.Drawing.Point(583, 0);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(70, 40);
            this.btnUltimo.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnUltimo, "Última fianza");
            this.btnUltimo.UseVisualStyleBackColor = false;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnPrimero
            // 
            this.btnPrimero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(40)))), ((int)(((byte)(191)))));
            this.btnPrimero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrimero.FlatAppearance.BorderSize = 0;
            this.btnPrimero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(93)))), ((int)(((byte)(191)))));
            this.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.ForeColor = System.Drawing.Color.White;
            this.btnPrimero.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimero.Image")));
            this.btnPrimero.Location = new System.Drawing.Point(337, 0);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(70, 40);
            this.btnPrimero.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnPrimero, "Primera fianza");
            this.btnPrimero.UseVisualStyleBackColor = false;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnSiguienteEdicion
            // 
            this.btnSiguienteEdicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(40)))), ((int)(((byte)(191)))));
            this.btnSiguienteEdicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguienteEdicion.FlatAppearance.BorderSize = 0;
            this.btnSiguienteEdicion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(93)))), ((int)(((byte)(191)))));
            this.btnSiguienteEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguienteEdicion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguienteEdicion.ForeColor = System.Drawing.Color.White;
            this.btnSiguienteEdicion.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguienteEdicion.Image")));
            this.btnSiguienteEdicion.Location = new System.Drawing.Point(501, 0);
            this.btnSiguienteEdicion.Name = "btnSiguienteEdicion";
            this.btnSiguienteEdicion.Size = new System.Drawing.Size(70, 40);
            this.btnSiguienteEdicion.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnSiguienteEdicion, "Fianza siguiente");
            this.btnSiguienteEdicion.UseVisualStyleBackColor = false;
            this.btnSiguienteEdicion.Click += new System.EventHandler(this.btnSiguienteEdicion_Click);
            // 
            // bAnteriorEdicion
            // 
            this.bAnteriorEdicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(40)))), ((int)(((byte)(191)))));
            this.bAnteriorEdicion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAnteriorEdicion.FlatAppearance.BorderSize = 0;
            this.bAnteriorEdicion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(93)))), ((int)(((byte)(191)))));
            this.bAnteriorEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAnteriorEdicion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAnteriorEdicion.ForeColor = System.Drawing.Color.White;
            this.bAnteriorEdicion.Image = ((System.Drawing.Image)(resources.GetObject("bAnteriorEdicion.Image")));
            this.bAnteriorEdicion.Location = new System.Drawing.Point(419, 0);
            this.bAnteriorEdicion.Name = "bAnteriorEdicion";
            this.bAnteriorEdicion.Size = new System.Drawing.Size(70, 40);
            this.bAnteriorEdicion.TabIndex = 5;
            this.toolTip1.SetToolTip(this.bAnteriorEdicion, "Fianza anterior");
            this.bAnteriorEdicion.UseVisualStyleBackColor = false;
            this.bAnteriorEdicion.Click += new System.EventHandler(this.bAnteriorEdicion_Click);
            // 
            // btnBuscarLiberacion
            // 
            this.btnBuscarLiberacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btnBuscarLiberacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarLiberacion.FlatAppearance.BorderSize = 0;
            this.btnBuscarLiberacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnBuscarLiberacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarLiberacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLiberacion.ForeColor = System.Drawing.Color.White;
            this.btnBuscarLiberacion.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarLiberacion.Image")));
            this.btnBuscarLiberacion.Location = new System.Drawing.Point(211, 0);
            this.btnBuscarLiberacion.Name = "btnBuscarLiberacion";
            this.btnBuscarLiberacion.Size = new System.Drawing.Size(70, 40);
            this.btnBuscarLiberacion.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnBuscarLiberacion, "Buscar fianza");
            this.btnBuscarLiberacion.UseVisualStyleBackColor = false;
            this.btnBuscarLiberacion.Click += new System.EventHandler(this.btnBuscarLiberacion_Click);
            // 
            // btnDatosLiberacion
            // 
            this.btnDatosLiberacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btnDatosLiberacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatosLiberacion.FlatAppearance.BorderSize = 0;
            this.btnDatosLiberacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.btnDatosLiberacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatosLiberacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatosLiberacion.ForeColor = System.Drawing.Color.White;
            this.btnDatosLiberacion.Image = ((System.Drawing.Image)(resources.GetObject("btnDatosLiberacion.Image")));
            this.btnDatosLiberacion.Location = new System.Drawing.Point(711, 0);
            this.btnDatosLiberacion.Name = "btnDatosLiberacion";
            this.btnDatosLiberacion.Size = new System.Drawing.Size(70, 40);
            this.btnDatosLiberacion.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnDatosLiberacion, "Datos de Liberación");
            this.btnDatosLiberacion.UseVisualStyleBackColor = false;
            this.btnDatosLiberacion.Click += new System.EventHandler(this.btnDatosLiberacion_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormLiberacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(980, 577);
            this.Controls.Add(this.panelInferiorBotones);
            this.Controls.Add(this.panelAsuntoOficio);
            this.Controls.Add(this.panelFechasFianzas);
            this.Controls.Add(this.panelIncluirFianzas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLiberacion";
            this.Text = "0";
            this.panelIncluirFianzas.ResumeLayout(false);
            this.panelIncluirFianzas.PerformLayout();
            this.panelFechasFianzas.ResumeLayout(false);
            this.panelFechasFianzas.PerformLayout();
            this.panelAsuntoOficio.ResumeLayout(false);
            this.panelAsuntoOficio.PerformLayout();
            this.panelInferiorBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelIncluirFianzas;
        private System.Windows.Forms.Label lHoraEdicion;
        private System.Windows.Forms.Label lFechaEdicion;
        private System.Windows.Forms.Label lLiberacionFianza;
        private System.Windows.Forms.TextBox tbAño;
        private System.Windows.Forms.Label lNroFianza;
        private System.Windows.Forms.Label lAño;
        private System.Windows.Forms.Label lGarante;
        private System.Windows.Forms.ComboBox cbNaturalezaOperacion;
        private System.Windows.Forms.Label lMonto;
        private System.Windows.Forms.ComboBox cbContribuyente;
        private System.Windows.Forms.Label lAgenda;
        private System.Windows.Forms.ComboBox cbAgente;
        private System.Windows.Forms.Label lContribuyente;
        private System.Windows.Forms.ComboBox cbGarante;
        private System.Windows.Forms.Label lNaturalezaOperacion;
        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.TextBox tbNroFianza;
        private System.Windows.Forms.Panel panelFechasFianzas;
        private System.Windows.Forms.Label lFianzasAlmacenadas;
        private System.Windows.Forms.Label lSistemaPECDF;
        private System.Windows.Forms.Label lArchivo;
        private System.Windows.Forms.DateTimePicker dtpRecibida;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.DateTimePicker dtpEmision;
        private System.Windows.Forms.TextBox tbArchivo;
        private System.Windows.Forms.Label lEmisión;
        private System.Windows.Forms.Label lVencimiento;
        private System.Windows.Forms.Label lRecibida;
        private System.Windows.Forms.Panel panelAsuntoOficio;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label lFechaRegistro;
        private System.Windows.Forms.Label lNro;
        private System.Windows.Forms.TextBox tbNro;
        private System.Windows.Forms.Label lTomo;
        private System.Windows.Forms.TextBox tbTomo;
        private System.Windows.Forms.TextBox tbNotaria;
        private System.Windows.Forms.Label lNotaria;
        private System.Windows.Forms.Label lOficio;
        private System.Windows.Forms.ComboBox cbOficio;
        private System.Windows.Forms.TextBox tbAsunto;
        private System.Windows.Forms.Label lAsunto;
        private System.Windows.Forms.Panel panelInferiorBotones;
        private System.Windows.Forms.Button btnDatosLiberacion;
        private System.Windows.Forms.Button btnBuscarLiberacion;
        private System.Windows.Forms.Button btnSiguienteEdicion;
        private System.Windows.Forms.Button bAnteriorEdicion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnPrimero;

    }
}