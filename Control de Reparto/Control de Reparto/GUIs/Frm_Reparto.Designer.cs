namespace Control_de_Reparto.GUIs
{
    partial class Frm_Reparto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Reparto));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbFolioReparto = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbChoferes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbResponsables = new System.Windows.Forms.ComboBox();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.gridFacturaEncontrada = new DevExpress.XtraGrid.GridControl();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvFacturaEncontrada = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFolio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridFacturas = new DevExpress.XtraGrid.GridControl();
            this.gvFacturas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFolio1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveCliente1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCliente1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporte1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.SegundoPlano = new System.ComponentModel.BackgroundWorker();
            this.pbCargando = new System.Windows.Forms.PictureBox();
            this.Pestañas = new System.Windows.Forms.TabControl();
            this.TabReparto = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.gridCobranza = new DevExpress.XtraGrid.GridControl();
            this.gvCobranza = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnQuitarCobranza = new System.Windows.Forms.Button();
            this.btnBuscarCobranza = new System.Windows.Forms.Button();
            this.btnImprimirCobranza = new System.Windows.Forms.Button();
            this.txbFolioFactura = new System.Windows.Forms.TextBox();
            this.btnAgregarCobranza = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gridListaCobranza = new DevExpress.XtraGrid.GridControl();
            this.gvListaCobranza = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.segundoPlanoCobranza = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturaEncontrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFacturaEncontrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCargando)).BeginInit();
            this.Pestañas.SuspendLayout();
            this.TabReparto.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaCobranza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaCobranza)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(63, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(658, 30);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Control de Reparto";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folio Factura o Ticket:";
            // 
            // txbFolioReparto
            // 
            this.txbFolioReparto.Location = new System.Drawing.Point(151, 7);
            this.txbFolioReparto.MaxLength = 9;
            this.txbFolioReparto.Name = "txbFolioReparto";
            this.txbFolioReparto.Size = new System.Drawing.Size(126, 23);
            this.txbFolioReparto.TabIndex = 3;
            this.txbFolioReparto.TextChanged += new System.EventHandler(this.txbFolioReparto_TextChanged);
            this.txbFolioReparto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFolio_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(283, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 25);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Image = global::Control_de_Reparto.Properties.Resources.engranaje_30;
            this.btnConfigurar.Location = new System.Drawing.Point(12, 3);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(45, 64);
            this.btnConfigurar.TabIndex = 30;
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPersonal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbChoferes);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbResponsables);
            this.panel1.Controls.Add(this.btnConfigurar);
            this.panel1.Controls.Add(this.lblSucursal);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 126);
            this.panel1.TabIndex = 6;
            // 
            // btnPersonal
            // 
            this.btnPersonal.Image = global::Control_de_Reparto.Properties.Resources.Add_Male_User_icon;
            this.btnPersonal.Location = new System.Drawing.Point(63, 3);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(45, 64);
            this.btnPersonal.TabIndex = 35;
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Chofer:";
            // 
            // cbChoferes
            // 
            this.cbChoferes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChoferes.FormattingEnabled = true;
            this.cbChoferes.Location = new System.Drawing.Point(262, 94);
            this.cbChoferes.Name = "cbChoferes";
            this.cbChoferes.Size = new System.Drawing.Size(352, 24);
            this.cbChoferes.TabIndex = 33;
            this.cbChoferes.SelectedIndexChanged += new System.EventHandler(this.cbChoferes_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Responsable:";
            // 
            // cbResponsables
            // 
            this.cbResponsables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResponsables.FormattingEnabled = true;
            this.cbResponsables.Location = new System.Drawing.Point(262, 64);
            this.cbResponsables.Name = "cbResponsables";
            this.cbResponsables.Size = new System.Drawing.Size(352, 24);
            this.cbResponsables.TabIndex = 31;
            this.cbResponsables.SelectedIndexChanged += new System.EventHandler(this.cbResponsables_SelectedIndexChanged);
            // 
            // lblSucursal
            // 
            this.lblSucursal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSucursal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.Location = new System.Drawing.Point(67, 39);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(654, 22);
            this.lblSucursal.TabIndex = 6;
            this.lblSucursal.Text = "Sucursal";
            this.lblSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridFacturaEncontrada
            // 
            this.gridFacturaEncontrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridFacturaEncontrada.DataSource = this.facturaBindingSource;
            this.gridFacturaEncontrada.Location = new System.Drawing.Point(7, 37);
            this.gridFacturaEncontrada.MainView = this.gvFacturaEncontrada;
            this.gridFacturaEncontrada.Name = "gridFacturaEncontrada";
            this.gridFacturaEncontrada.Size = new System.Drawing.Size(681, 48);
            this.gridFacturaEncontrada.TabIndex = 7;
            this.gridFacturaEncontrada.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFacturaEncontrada});
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataSource = typeof(Control_de_Reparto.Modelos.Factura);
            // 
            // gvFacturaEncontrada
            // 
            this.gvFacturaEncontrada.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFolio,
            this.colClaveCliente,
            this.colNombreCliente,
            this.colImporte,
            this.colSaldo});
            this.gvFacturaEncontrada.GridControl = this.gridFacturaEncontrada;
            this.gvFacturaEncontrada.Name = "gvFacturaEncontrada";
            this.gvFacturaEncontrada.OptionsBehavior.Editable = false;
            this.gvFacturaEncontrada.OptionsCustomization.AllowGroup = false;
            this.gvFacturaEncontrada.OptionsView.ShowGroupPanel = false;
            // 
            // colFolio
            // 
            this.colFolio.FieldName = "Folio";
            this.colFolio.Name = "colFolio";
            this.colFolio.Visible = true;
            this.colFolio.VisibleIndex = 0;
            // 
            // colClaveCliente
            // 
            this.colClaveCliente.FieldName = "ClaveCliente";
            this.colClaveCliente.Name = "colClaveCliente";
            this.colClaveCliente.Visible = true;
            this.colClaveCliente.VisibleIndex = 1;
            // 
            // colNombreCliente
            // 
            this.colNombreCliente.FieldName = "NombreCliente";
            this.colNombreCliente.Name = "colNombreCliente";
            this.colNombreCliente.Visible = true;
            this.colNombreCliente.VisibleIndex = 2;
            // 
            // colImporte
            // 
            this.colImporte.DisplayFormat.FormatString = "C";
            this.colImporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImporte.FieldName = "Importe";
            this.colImporte.Name = "colImporte";
            this.colImporte.Visible = true;
            this.colImporte.VisibleIndex = 3;
            // 
            // colSaldo
            // 
            this.colSaldo.DisplayFormat.FormatString = "C";
            this.colSaldo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSaldo.FieldName = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.Visible = true;
            this.colSaldo.VisibleIndex = 4;
            // 
            // gridFacturas
            // 
            this.gridFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridFacturas.DataSource = this.facturaBindingSource;
            this.gridFacturas.Location = new System.Drawing.Point(7, 110);
            this.gridFacturas.MainView = this.gvFacturas;
            this.gridFacturas.Name = "gridFacturas";
            this.gridFacturas.Size = new System.Drawing.Size(681, 250);
            this.gridFacturas.TabIndex = 8;
            this.gridFacturas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFacturas});
            // 
            // gvFacturas
            // 
            this.gvFacturas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFolio1,
            this.colClaveCliente1,
            this.colNombreCliente1,
            this.colImporte1,
            this.colSaldo1});
            this.gvFacturas.GridControl = this.gridFacturas;
            this.gvFacturas.Name = "gvFacturas";
            this.gvFacturas.OptionsBehavior.Editable = false;
            this.gvFacturas.OptionsCustomization.AllowGroup = false;
            this.gvFacturas.OptionsView.ShowGroupPanel = false;
            // 
            // colFolio1
            // 
            this.colFolio1.FieldName = "Folio";
            this.colFolio1.Name = "colFolio1";
            this.colFolio1.Visible = true;
            this.colFolio1.VisibleIndex = 0;
            // 
            // colClaveCliente1
            // 
            this.colClaveCliente1.FieldName = "ClaveCliente";
            this.colClaveCliente1.Name = "colClaveCliente1";
            this.colClaveCliente1.Visible = true;
            this.colClaveCliente1.VisibleIndex = 1;
            // 
            // colNombreCliente1
            // 
            this.colNombreCliente1.FieldName = "NombreCliente";
            this.colNombreCliente1.Name = "colNombreCliente1";
            this.colNombreCliente1.Visible = true;
            this.colNombreCliente1.VisibleIndex = 2;
            // 
            // colImporte1
            // 
            this.colImporte1.DisplayFormat.FormatString = "C";
            this.colImporte1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImporte1.FieldName = "Importe";
            this.colImporte1.Name = "colImporte1";
            this.colImporte1.Visible = true;
            this.colImporte1.VisibleIndex = 3;
            // 
            // colSaldo1
            // 
            this.colSaldo1.DisplayFormat.FormatString = "C";
            this.colSaldo1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSaldo1.FieldName = "Saldo";
            this.colSaldo1.Name = "colSaldo1";
            this.colSaldo1.Visible = true;
            this.colSaldo1.VisibleIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lista de Facturas:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimir.Location = new System.Drawing.Point(351, 366);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 30);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(694, 110);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 48);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitar.Enabled = false;
            this.btnQuitar.Location = new System.Drawing.Point(694, 164);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 48);
            this.btnQuitar.TabIndex = 12;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // SegundoPlano
            // 
            this.SegundoPlano.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SegundoPlano_DoWork);
            this.SegundoPlano.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SegundoPlano_RunWorkerCompleted);
            // 
            // pbCargando
            // 
            this.pbCargando.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbCargando.Image = global::Control_de_Reparto.Properties.Resources.cargando;
            this.pbCargando.Location = new System.Drawing.Point(308, 234);
            this.pbCargando.Name = "pbCargando";
            this.pbCargando.Size = new System.Drawing.Size(169, 94);
            this.pbCargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbCargando.TabIndex = 13;
            this.pbCargando.TabStop = false;
            this.pbCargando.Visible = false;
            // 
            // Pestañas
            // 
            this.Pestañas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pestañas.Controls.Add(this.TabReparto);
            this.Pestañas.Controls.Add(this.tabPage2);
            this.Pestañas.Location = new System.Drawing.Point(0, 132);
            this.Pestañas.Name = "Pestañas";
            this.Pestañas.SelectedIndex = 0;
            this.Pestañas.Size = new System.Drawing.Size(784, 430);
            this.Pestañas.TabIndex = 14;
            this.Pestañas.SelectedIndexChanged += new System.EventHandler(this.Pestañas_SelectedIndexChanged);
            // 
            // TabReparto
            // 
            this.TabReparto.Controls.Add(this.btnQuitar);
            this.TabReparto.Controls.Add(this.gridFacturas);
            this.TabReparto.Controls.Add(this.label2);
            this.TabReparto.Controls.Add(this.gridFacturaEncontrada);
            this.TabReparto.Controls.Add(this.btnBuscar);
            this.TabReparto.Controls.Add(this.btnImprimir);
            this.TabReparto.Controls.Add(this.txbFolioReparto);
            this.TabReparto.Controls.Add(this.btnAgregar);
            this.TabReparto.Controls.Add(this.label1);
            this.TabReparto.Location = new System.Drawing.Point(4, 25);
            this.TabReparto.Name = "TabReparto";
            this.TabReparto.Padding = new System.Windows.Forms.Padding(3);
            this.TabReparto.Size = new System.Drawing.Size(776, 401);
            this.TabReparto.TabIndex = 0;
            this.TabReparto.Text = "Control de Reparto";
            this.TabReparto.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.gridCobranza);
            this.tabPage2.Controls.Add(this.btnQuitarCobranza);
            this.tabPage2.Controls.Add(this.btnBuscarCobranza);
            this.tabPage2.Controls.Add(this.btnImprimirCobranza);
            this.tabPage2.Controls.Add(this.txbFolioFactura);
            this.tabPage2.Controls.Add(this.btnAgregarCobranza);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.gridListaCobranza);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Control de Cobranza";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Lista de Facturas:";
            // 
            // gridCobranza
            // 
            this.gridCobranza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridCobranza.DataSource = this.facturaBindingSource;
            this.gridCobranza.Location = new System.Drawing.Point(7, 37);
            this.gridCobranza.MainView = this.gvCobranza;
            this.gridCobranza.Name = "gridCobranza";
            this.gridCobranza.Size = new System.Drawing.Size(681, 48);
            this.gridCobranza.TabIndex = 16;
            this.gridCobranza.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCobranza});
            // 
            // gvCobranza
            // 
            this.gvCobranza.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10});
            this.gvCobranza.GridControl = this.gridCobranza;
            this.gvCobranza.Name = "gvCobranza";
            this.gvCobranza.OptionsBehavior.Editable = false;
            this.gvCobranza.OptionsCustomization.AllowGroup = false;
            this.gvCobranza.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "Folio";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "ClaveCliente";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "NombreCliente";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            // 
            // gridColumn9
            // 
            this.gridColumn9.DisplayFormat.FormatString = "C";
            this.gridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn9.FieldName = "Importe";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            // 
            // gridColumn10
            // 
            this.gridColumn10.DisplayFormat.FormatString = "C";
            this.gridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn10.FieldName = "Saldo";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 4;
            // 
            // btnQuitarCobranza
            // 
            this.btnQuitarCobranza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarCobranza.Enabled = false;
            this.btnQuitarCobranza.Location = new System.Drawing.Point(694, 164);
            this.btnQuitarCobranza.Name = "btnQuitarCobranza";
            this.btnQuitarCobranza.Size = new System.Drawing.Size(75, 48);
            this.btnQuitarCobranza.TabIndex = 20;
            this.btnQuitarCobranza.Text = "Quitar";
            this.btnQuitarCobranza.UseVisualStyleBackColor = true;
            this.btnQuitarCobranza.Click += new System.EventHandler(this.btnQuitarCobranza_Click);
            // 
            // btnBuscarCobranza
            // 
            this.btnBuscarCobranza.Location = new System.Drawing.Point(234, 6);
            this.btnBuscarCobranza.Name = "btnBuscarCobranza";
            this.btnBuscarCobranza.Size = new System.Drawing.Size(75, 25);
            this.btnBuscarCobranza.TabIndex = 15;
            this.btnBuscarCobranza.Text = "Buscar";
            this.btnBuscarCobranza.UseVisualStyleBackColor = true;
            this.btnBuscarCobranza.Click += new System.EventHandler(this.btnBuscarCobranza_Click);
            // 
            // btnImprimirCobranza
            // 
            this.btnImprimirCobranza.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimirCobranza.Location = new System.Drawing.Point(351, 366);
            this.btnImprimirCobranza.Name = "btnImprimirCobranza";
            this.btnImprimirCobranza.Size = new System.Drawing.Size(75, 30);
            this.btnImprimirCobranza.TabIndex = 18;
            this.btnImprimirCobranza.Text = "Imprimir";
            this.btnImprimirCobranza.UseVisualStyleBackColor = true;
            this.btnImprimirCobranza.Click += new System.EventHandler(this.btnImprimirCobranza_Click);
            // 
            // txbFolioFactura
            // 
            this.txbFolioFactura.Location = new System.Drawing.Point(102, 7);
            this.txbFolioFactura.MaxLength = 9;
            this.txbFolioFactura.Name = "txbFolioFactura";
            this.txbFolioFactura.Size = new System.Drawing.Size(126, 23);
            this.txbFolioFactura.TabIndex = 14;
            this.txbFolioFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFolioFactura_KeyPress);
            // 
            // btnAgregarCobranza
            // 
            this.btnAgregarCobranza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarCobranza.Enabled = false;
            this.btnAgregarCobranza.Location = new System.Drawing.Point(694, 110);
            this.btnAgregarCobranza.Name = "btnAgregarCobranza";
            this.btnAgregarCobranza.Size = new System.Drawing.Size(75, 48);
            this.btnAgregarCobranza.TabIndex = 19;
            this.btnAgregarCobranza.Text = "Agregar";
            this.btnAgregarCobranza.UseVisualStyleBackColor = true;
            this.btnAgregarCobranza.Click += new System.EventHandler(this.btnAgregarCobranza_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Folio Factura:";
            // 
            // gridListaCobranza
            // 
            this.gridListaCobranza.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridListaCobranza.DataSource = this.facturaBindingSource;
            this.gridListaCobranza.Location = new System.Drawing.Point(7, 110);
            this.gridListaCobranza.MainView = this.gvListaCobranza;
            this.gridListaCobranza.Name = "gridListaCobranza";
            this.gridListaCobranza.Size = new System.Drawing.Size(681, 250);
            this.gridListaCobranza.TabIndex = 17;
            this.gridListaCobranza.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvListaCobranza});
            // 
            // gvListaCobranza
            // 
            this.gvListaCobranza.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gvListaCobranza.GridControl = this.gridListaCobranza;
            this.gvListaCobranza.Name = "gvListaCobranza";
            this.gvListaCobranza.OptionsBehavior.Editable = false;
            this.gvListaCobranza.OptionsCustomization.AllowGroup = false;
            this.gvListaCobranza.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Folio";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "ClaveCliente";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "NombreCliente";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.DisplayFormat.FormatString = "C";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "Importe";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.DisplayFormat.FormatString = "C";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "Saldo";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // segundoPlanoCobranza
            // 
            this.segundoPlanoCobranza.DoWork += new System.ComponentModel.DoWorkEventHandler(this.segundoPlanoCobranza_DoWork);
            this.segundoPlanoCobranza.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.segundoPlanoCobranza_RunWorkerCompleted);
            // 
            // Frm_Reparto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pbCargando);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pestañas);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_Reparto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Control de reparto";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturaEncontrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFacturaEncontrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCargando)).EndInit();
            this.Pestañas.ResumeLayout(false);
            this.TabReparto.ResumeLayout(false);
            this.TabReparto.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaCobranza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvListaCobranza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbFolioReparto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSucursal;
        private DevExpress.XtraGrid.GridControl gridFacturaEncontrada;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFacturaEncontrada;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFolio;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colImporte;
        private DevExpress.XtraGrid.GridControl gridFacturas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFacturas;
        private DevExpress.XtraGrid.Columns.GridColumn colFolio1;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveCliente1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCliente1;
        private DevExpress.XtraGrid.Columns.GridColumn colImporte1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo1;
        private System.ComponentModel.BackgroundWorker SegundoPlano;
        private System.Windows.Forms.PictureBox pbCargando;
        private System.Windows.Forms.TabControl Pestañas;
        private System.Windows.Forms.TabPage TabReparto;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnQuitarCobranza;
        private DevExpress.XtraGrid.GridControl gridListaCobranza;
        private DevExpress.XtraGrid.Views.Grid.GridView gvListaCobranza;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.GridControl gridCobranza;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCobranza;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private System.Windows.Forms.Button btnBuscarCobranza;
        private System.Windows.Forms.Button btnImprimirCobranza;
        private System.Windows.Forms.TextBox txbFolioFactura;
        private System.Windows.Forms.Button btnAgregarCobranza;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker segundoPlanoCobranza;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbChoferes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbResponsables;
        private System.Windows.Forms.Label label6;
    }
}