namespace Control_de_Reparto.GUIs
{
    partial class frmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.tbAccess = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnbotones = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ts2 = new System.Windows.Forms.ToolStrip();
            this.tsCancelarMy = new System.Windows.Forms.ToolStripButton();
            this.ts1 = new System.Windows.Forms.ToolStrip();
            this.btnGuardarMy = new System.Windows.Forms.ToolStripButton();
            this.pnbotones.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.ts2.SuspendLayout();
            this.ts1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAccess
            // 
            this.tbAccess.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccess.Location = new System.Drawing.Point(6, 27);
            this.tbAccess.Name = "tbAccess";
            this.tbAccess.PasswordChar = '*';
            this.tbAccess.Size = new System.Drawing.Size(277, 26);
            this.tbAccess.TabIndex = 22;
            this.tbAccess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbAccess_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Introducir Clave Acceso";
            // 
            // pnbotones
            // 
            this.pnbotones.Controls.Add(this.toolStrip1);
            this.pnbotones.Controls.Add(this.ts2);
            this.pnbotones.Controls.Add(this.ts1);
            this.pnbotones.Location = new System.Drawing.Point(6, 59);
            this.pnbotones.Name = "pnbotones";
            this.pnbotones.Size = new System.Drawing.Size(277, 145);
            this.pnbotones.TabIndex = 23;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(101, 85);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(74, 50);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Visible = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(72, 47);
            this.toolStripButton1.Text = "Cambiar Clave";
            // 
            // ts2
            // 
            this.ts2.Dock = System.Windows.Forms.DockStyle.None;
            this.ts2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCancelarMy});
            this.ts2.Location = new System.Drawing.Point(163, 53);
            this.ts2.Name = "ts2";
            this.ts2.Padding = new System.Windows.Forms.Padding(0);
            this.ts2.Size = new System.Drawing.Size(74, 50);
            this.ts2.TabIndex = 18;
            // 
            // tsCancelarMy
            // 
            this.tsCancelarMy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsCancelarMy.Image = ((System.Drawing.Image)(resources.GetObject("tsCancelarMy.Image")));
            this.tsCancelarMy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsCancelarMy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCancelarMy.Name = "tsCancelarMy";
            this.tsCancelarMy.Size = new System.Drawing.Size(72, 47);
            this.tsCancelarMy.Text = "Salir";
            this.tsCancelarMy.Click += new System.EventHandler(this.TsCancelarMy_Click);
            // 
            // ts1
            // 
            this.ts1.Dock = System.Windows.Forms.DockStyle.None;
            this.ts1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardarMy});
            this.ts1.Location = new System.Drawing.Point(42, 53);
            this.ts1.Name = "ts1";
            this.ts1.Padding = new System.Windows.Forms.Padding(0);
            this.ts1.Size = new System.Drawing.Size(74, 50);
            this.ts1.TabIndex = 17;
            // 
            // btnGuardarMy
            // 
            this.btnGuardarMy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardarMy.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarMy.Image")));
            this.btnGuardarMy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGuardarMy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardarMy.Name = "btnGuardarMy";
            this.btnGuardarMy.Size = new System.Drawing.Size(72, 47);
            this.btnGuardarMy.Text = "Ingresar";
            this.btnGuardarMy.Click += new System.EventHandler(this.BtnGuardarMy_Click);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 209);
            this.Controls.Add(this.pnbotones);
            this.Controls.Add(this.tbAccess);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.pnbotones.ResumeLayout(false);
            this.pnbotones.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ts2.ResumeLayout(false);
            this.ts2.PerformLayout();
            this.ts1.ResumeLayout(false);
            this.ts1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAccess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnbotones;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip ts2;
        private System.Windows.Forms.ToolStripButton tsCancelarMy;
        private System.Windows.Forms.ToolStrip ts1;
        private System.Windows.Forms.ToolStripButton btnGuardarMy;
    }
}