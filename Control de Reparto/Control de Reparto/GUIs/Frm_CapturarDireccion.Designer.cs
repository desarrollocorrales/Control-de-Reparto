namespace Control_de_Reparto.GUIs
{
    partial class Frm_CapturarDireccion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCalle = new System.Windows.Forms.TextBox();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblFolio = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCodigoPostal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbColonia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbInterior = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capturar Información del Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de calle:";
            // 
            // txbCalle
            // 
            this.txbCalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCalle.Location = new System.Drawing.Point(148, 26);
            this.txbCalle.Name = "txbCalle";
            this.txbCalle.Size = new System.Drawing.Size(700, 27);
            this.txbCalle.TabIndex = 2;
            // 
            // txbCliente
            // 
            this.txbCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCliente.Location = new System.Drawing.Point(166, 79);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(698, 27);
            this.txbCliente.TabIndex = 1;
            this.txbCliente.TextChanged += new System.EventHandler(this.txbCliente_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre del cliente:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(402, 280);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 30);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Location = new System.Drawing.Point(12, 45);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(140, 19);
            this.lblFolio.TabIndex = 6;
            this.lblFolio.Text = "Folio:  XXX999999";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbCodigoPostal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txbColonia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbInterior);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txbNumero);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbCalle);
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 165);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dirección de envio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Codigo Postal:";
            // 
            // txbCodigoPostal
            // 
            this.txbCodigoPostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCodigoPostal.Location = new System.Drawing.Point(148, 125);
            this.txbCodigoPostal.Name = "txbCodigoPostal";
            this.txbCodigoPostal.Size = new System.Drawing.Size(210, 27);
            this.txbCodigoPostal.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Colonia:";
            // 
            // txbColonia
            // 
            this.txbColonia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbColonia.Location = new System.Drawing.Point(148, 92);
            this.txbColonia.Name = "txbColonia";
            this.txbColonia.Size = new System.Drawing.Size(557, 27);
            this.txbColonia.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Interior:";
            // 
            // txbInterior
            // 
            this.txbInterior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbInterior.Location = new System.Drawing.Point(400, 59);
            this.txbInterior.Name = "txbInterior";
            this.txbInterior.Size = new System.Drawing.Size(149, 27);
            this.txbInterior.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número:";
            // 
            // txbNumero
            // 
            this.txbNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNumero.Location = new System.Drawing.Point(148, 59);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(172, 27);
            this.txbNumero.TabIndex = 3;
            // 
            // Frm_CapturarDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(884, 322);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txbCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(900, 360);
            this.MinimumSize = new System.Drawing.Size(900, 360);
            this.Name = "Frm_CapturarDireccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Capturar Direccion de Cliente Ticket";
            this.Load += new System.EventHandler(this.Frm_CapturarDireccion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCalle;
        private System.Windows.Forms.TextBox txbCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbCodigoPostal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbColonia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbInterior;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNumero;
    }
}