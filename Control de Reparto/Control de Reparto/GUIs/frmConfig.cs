using Control_de_Reparto.Utilerias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control_de_Reparto.GUIs
{
    public partial class frmConfig : Form
    {
        private frmConfig login;

        public frmConfig()
        {
            InitializeComponent();
        }

        public frmConfig(frmConfig f)
        {
            InitializeComponent();
            login = f;
        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
            this.Size = new Size(305, 248);
            this.ActiveControl = this.tbAccess;
        }

        private void BtnGuardarMy_Click(object sender, EventArgs e)
        {
            try
            {
                // validacion
                if (string.IsNullOrEmpty(this.tbAccess.Text))
                    throw new Exception("Ingrese la clave de acceso");

                string claveAcceso = new Seguridad().Transform(this.tbAccess.Text);

                string acceso = Control_de_Reparto.Properties.Settings.Default.accesoConfig;

                if (new Seguridad().Transform(acceso).Equals(new Seguridad().Transform(claveAcceso)))
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Hide();
                }
                else
                {
                    this.ActiveControl = this.tbAccess;
                    this.tbAccess.SelectAll();
                    throw new Exception("Clave incorrecta");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TsCancelarMy_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void TbAccess_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (tbAccess.Text.Trim() != "")
                {
                    if (e.Handled = new Generales().teclaEnter(e) == true)
                        BtnGuardarMy_Click(null, null);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
