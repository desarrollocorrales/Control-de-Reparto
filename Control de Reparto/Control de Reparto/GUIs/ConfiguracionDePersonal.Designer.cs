namespace Control_de_Reparto.GUIs
{
    partial class ConfiguracionDePersonal
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridPersonal = new DevExpress.XtraGrid.GridControl();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvPersonal = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_Personal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipos = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Configuracion del Personal";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 56);
            this.panel1.TabIndex = 2;
            // 
            // gridPersonal
            // 
            this.gridPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPersonal.DataSource = this.personalBindingSource;
            this.gridPersonal.Location = new System.Drawing.Point(12, 78);
            this.gridPersonal.MainView = this.gvPersonal;
            this.gridPersonal.Name = "gridPersonal";
            this.gridPersonal.Size = new System.Drawing.Size(507, 322);
            this.gridPersonal.TabIndex = 3;
            this.gridPersonal.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPersonal});
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataSource = typeof(Control_de_Reparto.Modelos.Personal);
            // 
            // gvPersonal
            // 
            this.gvPersonal.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvPersonal.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvPersonal.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvPersonal.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black;
            this.gvPersonal.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPersonal.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvPersonal.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvPersonal.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvPersonal.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.White;
            this.gvPersonal.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(215)))));
            this.gvPersonal.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.White;
            this.gvPersonal.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black;
            this.gvPersonal.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPersonal.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvPersonal.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvPersonal.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvPersonal.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.gvPersonal.Appearance.Empty.Options.UseBackColor = true;
            this.gvPersonal.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvPersonal.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvPersonal.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvPersonal.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvPersonal.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvPersonal.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvPersonal.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvPersonal.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPersonal.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvPersonal.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvPersonal.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvPersonal.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvPersonal.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvPersonal.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvPersonal.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(148)))));
            this.gvPersonal.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvPersonal.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(180)))), ((int)(((byte)(191)))));
            this.gvPersonal.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gvPersonal.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvPersonal.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvPersonal.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvPersonal.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvPersonal.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvPersonal.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPersonal.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvPersonal.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvPersonal.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvPersonal.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvPersonal.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvPersonal.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvPersonal.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvPersonal.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvPersonal.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvPersonal.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvPersonal.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvPersonal.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvPersonal.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvPersonal.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvPersonal.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvPersonal.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvPersonal.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvPersonal.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvPersonal.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvPersonal.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvPersonal.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvPersonal.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black;
            this.gvPersonal.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvPersonal.Appearance.GroupRow.Options.UseBorderColor = true;
            this.gvPersonal.Appearance.GroupRow.Options.UseFont = true;
            this.gvPersonal.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvPersonal.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvPersonal.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(153)))), ((int)(((byte)(182)))));
            this.gvPersonal.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.gvPersonal.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvPersonal.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gvPersonal.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvPersonal.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvPersonal.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvPersonal.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(219)))), ((int)(((byte)(226)))));
            this.gvPersonal.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(131)))), ((int)(((byte)(161)))));
            this.gvPersonal.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvPersonal.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvPersonal.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gvPersonal.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvPersonal.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvPersonal.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvPersonal.Appearance.OddRow.Options.UseBackColor = true;
            this.gvPersonal.Appearance.OddRow.Options.UseForeColor = true;
            this.gvPersonal.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(253)))));
            this.gvPersonal.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(165)))), ((int)(((byte)(177)))));
            this.gvPersonal.Appearance.Preview.Options.UseBackColor = true;
            this.gvPersonal.Appearance.Preview.Options.UseForeColor = true;
            this.gvPersonal.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvPersonal.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvPersonal.Appearance.Row.Options.UseBackColor = true;
            this.gvPersonal.Appearance.Row.Options.UseForeColor = true;
            this.gvPersonal.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvPersonal.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvPersonal.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(197)))), ((int)(((byte)(205)))));
            this.gvPersonal.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black;
            this.gvPersonal.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvPersonal.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvPersonal.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.gvPersonal.Appearance.VertLine.Options.UseBackColor = true;
            this.gvPersonal.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Personal,
            this.colNombre,
            this.colTipo});
            this.gvPersonal.GridControl = this.gridPersonal;
            this.gvPersonal.Name = "gvPersonal";
            this.gvPersonal.OptionsBehavior.Editable = false;
            this.gvPersonal.OptionsView.EnableAppearanceEvenRow = true;
            this.gvPersonal.OptionsView.EnableAppearanceOddRow = true;
            this.gvPersonal.OptionsView.ShowGroupPanel = false;
            // 
            // colID_Personal
            // 
            this.colID_Personal.FieldName = "ID_Personal";
            this.colID_Personal.Name = "colID_Personal";
            this.colID_Personal.Visible = true;
            this.colID_Personal.VisibleIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // colTipo
            // 
            this.colTipo.FieldName = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.Visible = true;
            this.colTipo.VisibleIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personal Registrado:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(525, 78);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 30);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(606, 78);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 30);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(687, 78);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 30);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID:";
            // 
            // txbId
            // 
            this.txbId.Enabled = false;
            this.txbId.Location = new System.Drawing.Point(525, 136);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(97, 23);
            this.txbId.TabIndex = 9;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(525, 181);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(237, 23);
            this.txbNombre.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tipo:";
            // 
            // cbTipos
            // 
            this.cbTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipos.FormattingEnabled = true;
            this.cbTipos.Location = new System.Drawing.Point(525, 226);
            this.cbTipos.Name = "cbTipos";
            this.cbTipos.Size = new System.Drawing.Size(171, 24);
            this.cbTipos.TabIndex = 13;
            // 
            // ConfiguracionDePersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 412);
            this.Controls.Add(this.cbTipos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridPersonal);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(790, 450);
            this.Name = "ConfiguracionDePersonal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Configuracion del Personal";
            this.Load += new System.EventHandler(this.ConfiguracionDePersonal_Load);
            this.Shown += new System.EventHandler(this.ConfiguracionDePersonal_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridPersonal;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPersonal;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Personal;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTipos;
    }
}