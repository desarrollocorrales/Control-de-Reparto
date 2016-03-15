﻿namespace Control_de_Reparto.GUIs
{
    partial class Frm_Clientes
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
            this.gridClientes = new DevExpress.XtraGrid.GridControl();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvClientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colsNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsTelefono1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsTelefono2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gridClientes
            // 
            this.gridClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridClientes.DataSource = this.clienteBindingSource;
            this.gridClientes.Location = new System.Drawing.Point(12, 33);
            this.gridClientes.MainView = this.gvClientes;
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.Size = new System.Drawing.Size(760, 417);
            this.gridClientes.TabIndex = 0;
            this.gridClientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvClientes});
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Control_de_Reparto.Modelos.Cliente);
            // 
            // gvClientes
            // 
            this.gvClientes.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvClientes.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvClientes.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvClientes.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvClientes.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvClientes.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvClientes.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvClientes.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvClientes.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(190)))), ((int)(((byte)(243)))));
            this.gvClientes.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.gvClientes.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvClientes.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvClientes.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvClientes.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvClientes.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvClientes.Appearance.Empty.Options.UseBackColor = true;
            this.gvClientes.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.gvClientes.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvClientes.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvClientes.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvClientes.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvClientes.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvClientes.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvClientes.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvClientes.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvClientes.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvClientes.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvClientes.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvClientes.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvClientes.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvClientes.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.gvClientes.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvClientes.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.gvClientes.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvClientes.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvClientes.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(106)))), ((int)(((byte)(197)))));
            this.gvClientes.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvClientes.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvClientes.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvClientes.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvClientes.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvClientes.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvClientes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvClientes.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvClientes.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvClientes.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvClientes.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvClientes.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvClientes.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvClientes.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvClientes.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvClientes.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvClientes.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvClientes.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvClientes.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvClientes.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvClientes.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(109)))), ((int)(((byte)(185)))));
            this.gvClientes.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvClientes.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvClientes.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvClientes.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvClientes.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(216)))), ((int)(((byte)(247)))));
            this.gvClientes.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvClientes.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvClientes.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvClientes.Appearance.GroupRow.Options.UseFont = true;
            this.gvClientes.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvClientes.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvClientes.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(171)))), ((int)(((byte)(228)))));
            this.gvClientes.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(236)))), ((int)(((byte)(254)))));
            this.gvClientes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvClientes.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvClientes.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvClientes.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvClientes.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(153)))), ((int)(((byte)(228)))));
            this.gvClientes.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(224)))), ((int)(((byte)(251)))));
            this.gvClientes.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvClientes.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvClientes.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvClientes.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvClientes.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvClientes.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.OddRow.Options.UseBackColor = true;
            this.gvClientes.Appearance.OddRow.Options.UseForeColor = true;
            this.gvClientes.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.gvClientes.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(129)))), ((int)(((byte)(185)))));
            this.gvClientes.Appearance.Preview.Options.UseBackColor = true;
            this.gvClientes.Appearance.Preview.Options.UseForeColor = true;
            this.gvClientes.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvClientes.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvClientes.Appearance.Row.Options.UseBackColor = true;
            this.gvClientes.Appearance.Row.Options.UseForeColor = true;
            this.gvClientes.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvClientes.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvClientes.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(126)))), ((int)(((byte)(217)))));
            this.gvClientes.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvClientes.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvClientes.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvClientes.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.gvClientes.Appearance.VertLine.Options.UseBackColor = true;
            this.gvClientes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colsNombre,
            this.colsTelefono1,
            this.colsTelefono2});
            this.gvClientes.GridControl = this.gridClientes;
            this.gvClientes.Name = "gvClientes";
            this.gvClientes.OptionsView.EnableAppearanceEvenRow = true;
            this.gvClientes.OptionsView.EnableAppearanceOddRow = true;
            this.gvClientes.OptionsView.ShowGroupPanel = false;
            // 
            // colsNombre
            // 
            this.colsNombre.Caption = "Nombre";
            this.colsNombre.FieldName = "sNombre";
            this.colsNombre.Name = "colsNombre";
            this.colsNombre.Visible = true;
            this.colsNombre.VisibleIndex = 0;
            // 
            // colsTelefono1
            // 
            this.colsTelefono1.Caption = "Teléfono1";
            this.colsTelefono1.FieldName = "sTelefono1";
            this.colsTelefono1.Name = "colsTelefono1";
            this.colsTelefono1.Visible = true;
            this.colsTelefono1.VisibleIndex = 1;
            // 
            // colsTelefono2
            // 
            this.colsTelefono2.Caption = "Teléfono2";
            this.colsTelefono2.FieldName = "sTelefono2";
            this.colsTelefono2.Name = "colsTelefono2";
            this.colsTelefono2.Visible = true;
            this.colsTelefono2.VisibleIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "lblTitulo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridClientes);
            this.Name = "Frm_Clientes";
            this.Text = "Clientes Encontrados";
            this.Load += new System.EventHandler(this.Frm_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridClientes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvClientes;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colsNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colsTelefono1;
        private DevExpress.XtraGrid.Columns.GridColumn colsTelefono2;
        private System.Windows.Forms.Label label1;
    }
}