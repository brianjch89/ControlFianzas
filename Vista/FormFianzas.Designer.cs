namespace Vista
{
    partial class FormFianzas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFianzas));
            this.lIncluirFianza = new System.Windows.Forms.Label();
            this.lNroFianza = new System.Windows.Forms.Label();
            this.lGarante = new System.Windows.Forms.Label();
            this.lMonto = new System.Windows.Forms.Label();
            this.lAgente = new System.Windows.Forms.Label();
            this.lContribuyente = new System.Windows.Forms.Label();
            this.lNaturalezaOperacion = new System.Windows.Forms.Label();
            this.tbNroFianza = new System.Windows.Forms.TextBox();
            this.tbMonto = new System.Windows.Forms.TextBox();
            this.cbGarante = new System.Windows.Forms.ComboBox();
            this.cbAgente = new System.Windows.Forms.ComboBox();
            this.cbContribuyente = new System.Windows.Forms.ComboBox();
            this.cbNaturalezaOperacion = new System.Windows.Forms.ComboBox();
            this.lAño = new System.Windows.Forms.Label();
            this.tbAño = new System.Windows.Forms.TextBox();
            this.panelIncluirFianzas = new System.Windows.Forms.Panel();
            this.lHora = new System.Windows.Forms.Label();
            this.lFecha = new System.Windows.Forms.Label();
            this.panelFechasFianzas = new System.Windows.Forms.Panel();
            this.lCantidadFianzas = new System.Windows.Forms.Label();
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnActualizarInfo = new System.Windows.Forms.Button();
            this.btnEtiqueta = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelIncluirFianzas.SuspendLayout();
            this.panelFechasFianzas.SuspendLayout();
            this.panelAsuntoOficio.SuspendLayout();
            this.panelInferiorBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lIncluirFianza
            // 
            this.lIncluirFianza.AutoSize = true;
            this.lIncluirFianza.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lIncluirFianza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.lIncluirFianza.Location = new System.Drawing.Point(327, 20);
            this.lIncluirFianza.Name = "lIncluirFianza";
            this.lIncluirFianza.Size = new System.Drawing.Size(160, 26);
            this.lIncluirFianza.TabIndex = 0;
            this.lIncluirFianza.Text = "Incluir Fianzas";
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
            // lAgente
            // 
            this.lAgente.AutoSize = true;
            this.lAgente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lAgente.ForeColor = System.Drawing.Color.Lavender;
            this.lAgente.Location = new System.Drawing.Point(164, 177);
            this.lAgente.Name = "lAgente";
            this.lAgente.Size = new System.Drawing.Size(62, 18);
            this.lAgente.TabIndex = 4;
            this.lAgente.Text = "Agente";
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
            // cbGarante
            // 
            this.cbGarante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGarante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGarante.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbGarante.FormattingEnabled = true;
            this.cbGarante.Location = new System.Drawing.Point(234, 104);
            this.cbGarante.Margin = new System.Windows.Forms.Padding(0);
            this.cbGarante.Name = "cbGarante";
            this.cbGarante.Size = new System.Drawing.Size(250, 26);
            this.cbGarante.TabIndex = 2;
            this.cbGarante.SelectedIndexChanged += new System.EventHandler(this.cbGarante_SelectedIndexChanged);
            this.cbGarante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbGarante_KeyPress);
            // 
            // cbAgente
            // 
            this.cbAgente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAgente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAgente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbAgente.FormattingEnabled = true;
            this.cbAgente.Location = new System.Drawing.Point(233, 174);
            this.cbAgente.Name = "cbAgente";
            this.cbAgente.Size = new System.Drawing.Size(250, 26);
            this.cbAgente.TabIndex = 5;
            this.cbAgente.SelectedIndexChanged += new System.EventHandler(this.cbAgente_SelectedIndexChanged);
            this.cbAgente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbAgente_KeyPress);
            // 
            // cbContribuyente
            // 
            this.cbContribuyente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbContribuyente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbContribuyente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbContribuyente.FormattingEnabled = true;
            this.cbContribuyente.Location = new System.Drawing.Point(234, 210);
            this.cbContribuyente.Name = "cbContribuyente";
            this.cbContribuyente.Size = new System.Drawing.Size(250, 26);
            this.cbContribuyente.TabIndex = 6;
            this.cbContribuyente.SelectedIndexChanged += new System.EventHandler(this.cbContribuyente_SelectedIndexChanged);
            this.cbContribuyente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbContribuyente_KeyPress);
            // 
            // cbNaturalezaOperacion
            // 
            this.cbNaturalezaOperacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNaturalezaOperacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNaturalezaOperacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbNaturalezaOperacion.FormattingEnabled = true;
            this.cbNaturalezaOperacion.Location = new System.Drawing.Point(234, 247);
            this.cbNaturalezaOperacion.Name = "cbNaturalezaOperacion";
            this.cbNaturalezaOperacion.Size = new System.Drawing.Size(250, 26);
            this.cbNaturalezaOperacion.TabIndex = 7;
            this.cbNaturalezaOperacion.SelectedIndexChanged += new System.EventHandler(this.cbNaturalezaOperacion_SelectedIndexChanged);
            this.cbNaturalezaOperacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNaturalezaOperacion_KeyPress);
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
            // panelIncluirFianzas
            // 
            this.panelIncluirFianzas.Controls.Add(this.lHora);
            this.panelIncluirFianzas.Controls.Add(this.lFecha);
            this.panelIncluirFianzas.Controls.Add(this.lIncluirFianza);
            this.panelIncluirFianzas.Controls.Add(this.tbAño);
            this.panelIncluirFianzas.Controls.Add(this.lNroFianza);
            this.panelIncluirFianzas.Controls.Add(this.lAño);
            this.panelIncluirFianzas.Controls.Add(this.lGarante);
            this.panelIncluirFianzas.Controls.Add(this.cbNaturalezaOperacion);
            this.panelIncluirFianzas.Controls.Add(this.lMonto);
            this.panelIncluirFianzas.Controls.Add(this.cbContribuyente);
            this.panelIncluirFianzas.Controls.Add(this.lAgente);
            this.panelIncluirFianzas.Controls.Add(this.cbAgente);
            this.panelIncluirFianzas.Controls.Add(this.lContribuyente);
            this.panelIncluirFianzas.Controls.Add(this.cbGarante);
            this.panelIncluirFianzas.Controls.Add(this.lNaturalezaOperacion);
            this.panelIncluirFianzas.Controls.Add(this.tbMonto);
            this.panelIncluirFianzas.Controls.Add(this.tbNroFianza);
            this.panelIncluirFianzas.Location = new System.Drawing.Point(0, 0);
            this.panelIncluirFianzas.Name = "panelIncluirFianzas";
            this.panelIncluirFianzas.Size = new System.Drawing.Size(500, 303);
            this.panelIncluirFianzas.TabIndex = 15;
            // 
            // lHora
            // 
            this.lHora.AutoSize = true;
            this.lHora.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lHora.ForeColor = System.Drawing.Color.Lime;
            this.lHora.Location = new System.Drawing.Point(3, 26);
            this.lHora.Name = "lHora";
            this.lHora.Size = new System.Drawing.Size(0, 20);
            this.lHora.TabIndex = 21;
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.lFecha.ForeColor = System.Drawing.Color.Lime;
            this.lFecha.Location = new System.Drawing.Point(3, 3);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(0, 20);
            this.lFecha.TabIndex = 20;
            // 
            // panelFechasFianzas
            // 
            this.panelFechasFianzas.Controls.Add(this.lCantidadFianzas);
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
            this.panelFechasFianzas.TabIndex = 16;
            // 
            // lCantidadFianzas
            // 
            this.lCantidadFianzas.AutoSize = true;
            this.lCantidadFianzas.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lCantidadFianzas.ForeColor = System.Drawing.Color.White;
            this.lCantidadFianzas.Location = new System.Drawing.Point(23, 26);
            this.lCantidadFianzas.Name = "lCantidadFianzas";
            this.lCantidadFianzas.Size = new System.Drawing.Size(0, 20);
            this.lCantidadFianzas.TabIndex = 20;
            this.lCantidadFianzas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.dtpRecibida.ValueChanged += new System.EventHandler(this.dtpRecibida_ValueChanged);
            this.dtpRecibida.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpRecibida_MouseDown);
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
            this.dtpVencimiento.ValueChanged += new System.EventHandler(this.dtpVencimiento_ValueChanged);
            this.dtpVencimiento.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpVencimiento_MouseDown);
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
            this.dtpEmision.ValueChanged += new System.EventHandler(this.dtpEmision_ValueChanged);
            this.dtpEmision.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpEmision_MouseDown);
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
            this.panelAsuntoOficio.TabIndex = 17;
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
            this.dtpFechaRegistro.ValueChanged += new System.EventHandler(this.dtpFechaRegistro_ValueChanged);
            this.dtpFechaRegistro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtpFechaRegistro_MouseDown);
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
            this.tbNro.TextChanged += new System.EventHandler(this.tbNro_TextChanged);
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
            this.cbOficio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbOficio.FormattingEnabled = true;
            this.cbOficio.Location = new System.Drawing.Point(656, 42);
            this.cbOficio.Name = "cbOficio";
            this.cbOficio.Size = new System.Drawing.Size(250, 26);
            this.cbOficio.TabIndex = 15;
            this.cbOficio.SelectedIndexChanged += new System.EventHandler(this.cbOficio_SelectedIndexChanged);
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
            this.panelInferiorBotones.Controls.Add(this.btnAgregar);
            this.panelInferiorBotones.Controls.Add(this.btnUltimo);
            this.panelInferiorBotones.Controls.Add(this.btnPrimero);
            this.panelInferiorBotones.Controls.Add(this.btnSiguiente);
            this.panelInferiorBotones.Controls.Add(this.btnAnterior);
            this.panelInferiorBotones.Controls.Add(this.btnActualizarInfo);
            this.panelInferiorBotones.Controls.Add(this.btnEtiqueta);
            this.panelInferiorBotones.Controls.Add(this.btnBuscar);
            this.panelInferiorBotones.Controls.Add(this.btnNuevo);
            this.panelInferiorBotones.Location = new System.Drawing.Point(0, 526);
            this.panelInferiorBotones.Name = "panelInferiorBotones";
            this.panelInferiorBotones.Size = new System.Drawing.Size(980, 51);
            this.panelInferiorBotones.TabIndex = 18;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(48, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(70, 40);
            this.btnAgregar.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnAgregar, "Nueva fianza");
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.btnUltimo.TabIndex = 10;
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
            this.btnPrimero.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnPrimero, "Primera fianza");
            this.btnPrimero.UseVisualStyleBackColor = false;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(40)))), ((int)(((byte)(191)))));
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(93)))), ((int)(((byte)(191)))));
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Location = new System.Drawing.Point(501, 0);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(70, 40);
            this.btnSiguiente.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnSiguiente, "Fianza siguiente");
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(40)))), ((int)(((byte)(191)))));
            this.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(93)))), ((int)(((byte)(191)))));
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.Color.White;
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(419, 0);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(70, 40);
            this.btnAnterior.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnAnterior, "Fianza anterior");
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnActualizarInfo
            // 
            this.btnActualizarInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btnActualizarInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarInfo.FlatAppearance.BorderSize = 0;
            this.btnActualizarInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.btnActualizarInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarInfo.ForeColor = System.Drawing.Color.White;
            this.btnActualizarInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarInfo.Image")));
            this.btnActualizarInfo.Location = new System.Drawing.Point(845, 0);
            this.btnActualizarInfo.Name = "btnActualizarInfo";
            this.btnActualizarInfo.Size = new System.Drawing.Size(70, 40);
            this.btnActualizarInfo.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnActualizarInfo, "Actualizar Información");
            this.btnActualizarInfo.UseVisualStyleBackColor = false;
            this.btnActualizarInfo.Click += new System.EventHandler(this.btnActualizarInfo_Click);
            // 
            // btnEtiqueta
            // 
            this.btnEtiqueta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btnEtiqueta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEtiqueta.FlatAppearance.BorderSize = 0;
            this.btnEtiqueta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.btnEtiqueta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtiqueta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEtiqueta.ForeColor = System.Drawing.Color.White;
            this.btnEtiqueta.Image = ((System.Drawing.Image)(resources.GetObject("btnEtiqueta.Image")));
            this.btnEtiqueta.Location = new System.Drawing.Point(763, 0);
            this.btnEtiqueta.Name = "btnEtiqueta";
            this.btnEtiqueta.Size = new System.Drawing.Size(70, 40);
            this.btnEtiqueta.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnEtiqueta, "Etiqueta");
            this.btnEtiqueta.UseVisualStyleBackColor = false;
            this.btnEtiqueta.Click += new System.EventHandler(this.btnEtiqueta_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(211, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(70, 40);
            this.btnBuscar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar fianza");
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(92)))), ((int)(((byte)(255)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(130, 0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(70, 40);
            this.btnNuevo.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnNuevo, "Guardar fianza");
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormFianzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(980, 577);
            this.Controls.Add(this.panelInferiorBotones);
            this.Controls.Add(this.panelAsuntoOficio);
            this.Controls.Add(this.panelFechasFianzas);
            this.Controls.Add(this.panelIncluirFianzas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFianzas";
            this.Text = "Fianzas";
            this.Load += new System.EventHandler(this.Fianzas_Load);
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

        private System.Windows.Forms.Label lIncluirFianza;
        private System.Windows.Forms.Label lNroFianza;
        private System.Windows.Forms.Label lGarante;
        private System.Windows.Forms.Label lMonto;
        private System.Windows.Forms.Label lAgente;
        private System.Windows.Forms.Label lContribuyente;
        private System.Windows.Forms.Label lNaturalezaOperacion;
        private System.Windows.Forms.TextBox tbNroFianza;
        private System.Windows.Forms.TextBox tbMonto;
        private System.Windows.Forms.ComboBox cbGarante;
        private System.Windows.Forms.ComboBox cbAgente;
        private System.Windows.Forms.ComboBox cbContribuyente;
        private System.Windows.Forms.ComboBox cbNaturalezaOperacion;
        private System.Windows.Forms.Label lAño;
        private System.Windows.Forms.TextBox tbAño;
        private System.Windows.Forms.Panel panelIncluirFianzas;
        private System.Windows.Forms.Panel panelFechasFianzas;
        private System.Windows.Forms.Label lArchivo;
        private System.Windows.Forms.DateTimePicker dtpRecibida;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.DateTimePicker dtpEmision;
        private System.Windows.Forms.Label lEmisión;
        private System.Windows.Forms.Label lVencimiento;
        private System.Windows.Forms.Label lRecibida;
        private System.Windows.Forms.Label lSistemaPECDF;
        private System.Windows.Forms.Panel panelAsuntoOficio;
        private System.Windows.Forms.TextBox tbAsunto;
        private System.Windows.Forms.Label lAsunto;
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
        private System.Windows.Forms.Panel panelInferiorBotones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnActualizarInfo;
        private System.Windows.Forms.Button btnEtiqueta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lHora;
        private System.Windows.Forms.TextBox tbArchivo;
        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.Label lCantidadFianzas;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}