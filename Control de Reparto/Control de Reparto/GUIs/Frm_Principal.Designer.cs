namespace Control_de_Reparto.GUIs
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbFolio = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturaEncontrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFacturaEncontrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(280, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(225, 30);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Control de Reparto";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folio Factura:";
            // 
            // txbFolio
            // 
            this.txbFolio.Location = new System.Drawing.Point(105, 76);
            this.txbFolio.MaxLength = 9;
            this.txbFolio.Name = "txbFolio";
            this.txbFolio.Size = new System.Drawing.Size(126, 23);
            this.txbFolio.TabIndex = 3;
            this.txbFolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFolio_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(237, 75);
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
            this.btnConfigurar.Location = new System.Drawing.Point(3, 3);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(45, 64);
            this.btnConfigurar.TabIndex = 30;
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConfigurar);
            this.panel1.Controls.Add(this.lblSucursal);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 70);
            this.panel1.TabIndex = 6;
            // 
            // lblSucursal
            // 
            this.lblSucursal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSucursal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSucursal.Location = new System.Drawing.Point(54, 39);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(676, 22);
            this.lblSucursal.TabIndex = 6;
            this.lblSucursal.Text = "Sucursal";
            this.lblSucursal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridFacturaEncontrada
            // 
            this.gridFacturaEncontrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridFacturaEncontrada.DataSource = this.facturaBindingSource;
            this.gridFacturaEncontrada.Location = new System.Drawing.Point(12, 105);
            this.gridFacturaEncontrada.MainView = this.gvFacturaEncontrada;
            this.gridFacturaEncontrada.Name = "gridFacturaEncontrada";
            this.gridFacturaEncontrada.Size = new System.Drawing.Size(679, 48);
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
            this.gridFacturas.Location = new System.Drawing.Point(12, 175);
            this.gridFacturas.MainView = this.gvFacturas;
            this.gridFacturas.Name = "gridFacturas";
            this.gridFacturas.Size = new System.Drawing.Size(679, 344);
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
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Lista de Facturas:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimir.Location = new System.Drawing.Point(355, 525);
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
            this.btnAgregar.Location = new System.Drawing.Point(697, 105);
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
            this.btnQuitar.Location = new System.Drawing.Point(697, 175);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 48);
            this.btnQuitar.TabIndex = 12;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridFacturas);
            this.Controls.Add(this.gridFacturaEncontrada);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txbFolio);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Control de reparto";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturaEncontrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFacturaEncontrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbFolio;
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
    }
}