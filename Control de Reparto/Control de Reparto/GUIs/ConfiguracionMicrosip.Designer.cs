namespace Control_de_Reparto.GUIs
{
    partial class ConfiguracionMicrosip
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
            this.txbDatabase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txbServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txbSucursal = new System.Windows.Forms.TextBox();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.txbSerie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbDatabase
            // 
            this.txbDatabase.Location = new System.Drawing.Point(196, 120);
            this.txbDatabase.Name = "txbDatabase";
            this.txbDatabase.Size = new System.Drawing.Size(366, 26);
            this.txbDatabase.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ruta de la base de datos:";
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(196, 152);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(157, 26);
            this.txbUser.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Usuario:";
            // 
            // txbPass
            // 
            this.txbPass.Location = new System.Drawing.Point(196, 187);
            this.txbPass.Name = "txbPass";
            this.txbPass.PasswordChar = '*';
            this.txbPass.Size = new System.Drawing.Size(157, 26);
            this.txbPass.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Contraseña:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(574, 46);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Configurar datos de conexión a Microsip";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbServer
            // 
            this.txbServer.Location = new System.Drawing.Point(196, 88);
            this.txbServer.Name = "txbServer";
            this.txbServer.Size = new System.Drawing.Size(240, 26);
            this.txbServer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Servidor:";
            // 
            // txbPort
            // 
            this.txbPort.Location = new System.Drawing.Point(196, 219);
            this.txbPort.Name = "txbPort";
            this.txbPort.Size = new System.Drawing.Size(87, 26);
            this.txbPort.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Puerto:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(250, 288);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 32);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txbSucursal
            // 
            this.txbSucursal.Location = new System.Drawing.Point(196, 56);
            this.txbSucursal.Name = "txbSucursal";
            this.txbSucursal.Size = new System.Drawing.Size(240, 26);
            this.txbSucursal.TabIndex = 2;
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(124, 59);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(66, 18);
            this.lblSucursal.TabIndex = 9;
            this.lblSucursal.Text = "Sucursal:";
            // 
            // txbSerie
            // 
            this.txbSerie.Location = new System.Drawing.Point(196, 251);
            this.txbSerie.Name = "txbSerie";
            this.txbSerie.Size = new System.Drawing.Size(45, 26);
            this.txbSerie.TabIndex = 8;
            this.txbSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSerie_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Longitud de la serie:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(437, 240);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(125, 32);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "Actualizar BD";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // ConfiguracionMicrosip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 332);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txbSerie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbSucursal);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txbPort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txbPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbDatabase);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(590, 370);
            this.MinimumSize = new System.Drawing.Size(590, 370);
            this.Name = "ConfiguracionMicrosip";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Configurar conexión a Microsip";
            this.Load += new System.EventHandler(this.ConfiguracionMicrosip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbDatabase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txbServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txbSucursal;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.TextBox txbSerie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnActualizar;
    }
}