using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Control_de_Reparto.DAL;

namespace Control_de_Reparto.GUIs
{
    public partial class ConfiguracionMicrosip : Form
    {
        public ConfiguracionMicrosip()
        {
            InitializeComponent();
        }

        private void ConfiguracionMicrosip_Load(object sender, EventArgs e)
        {
            CargarConfiguraciones();
        }
        private void CargarConfiguraciones()
        {
            try
            {
                Configuracion oConfig = new Configuracion();
                oConfig.Load();

                txbSucursal.Text = oConfig.Sucursal;
                txbServer.Text = oConfig.Servidor;
                txbDatabase.Text = oConfig.BaseDeDatos;
                txbUser.Text = oConfig.Usuario;
                txbPass.Text = oConfig.Contraseña;
                txbPort.Text = oConfig.Puerto;
                txbSerie.Text = oConfig.LongitudSerie.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro al cargar la configuración" + Environment.NewLine + ex.Message, "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarConfiguraciones();
        }
        private void GuardarConfiguraciones()
        {
            try
            {
                Configuracion oConfig = new Configuracion();

                oConfig.Sucursal = txbSucursal.Text;
                oConfig.Servidor = txbServer.Text;
                oConfig.BaseDeDatos = txbDatabase.Text;
                oConfig.Usuario = txbUser.Text;
                oConfig.Contraseña = txbPass.Text;
                oConfig.Puerto = txbPort.Text;
                oConfig.LongitudSerie = Convert.ToInt32(txbSerie.Text);

                oConfig.Save();

                MessageBox.Show("¡¡¡La configuración se ha guardado con exito!!!", "OK", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro al guardar la configuración" + Environment.NewLine + ex.Message, "Error",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                SqliteDAL DALReparto = new SqliteDAL("ControlDeReparto.db3");
                SqliteDAL DALCobranza = new SqliteDAL("ControlDeCobranza.db3");
                DALCobranza.ActualizarBaseDeDatos();
                DALReparto.ActualizarBaseDeDatos();
                MessageBox.Show("Base de datos actualizada con exito!", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
