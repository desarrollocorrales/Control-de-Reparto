using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using Control_de_Reparto.DAL;
using Control_de_Reparto.Modelos;

namespace Control_de_Reparto.GUIs
{
    public partial class Frm_Principal : Form
    {
        private Factura _FacturaEncontrada;
        private List<Factura> _lstFacturas;

        public Frm_Principal()
        {
            InitializeComponent();
            _lstFacturas = new List<Factura>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection dbconn = new SQLiteConnection();
                dbconn.ConnectionString = "Data Source=.\\BD\\ControlDeReparto.sqlite;Version=3;";
                dbconn.Open();                
                
                SQLiteCommand dbCommand = new SQLiteCommand();
                dbCommand.Connection = dbconn;
                dbCommand.CommandText = "Select * From manejo_impresiones";

                DataTable dt = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter();
                adapter.SelectCommand = dbCommand;
                adapter.Fill(dt);

                dbconn.Close();

                MessageBox.Show("Se conecto a la base de datos!!! " + dt.Rows[0]["folio_factura"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            new ConfiguracionMicrosip().ShowDialog();
            Configuracion oConfig = new Configuracion();
            oConfig.Load();

            lblSucursal.Text = oConfig.Sucursal;
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            Configuracion oConfig = new Configuracion();
            oConfig.Load();

            lblSucursal.Text = oConfig.Sucursal;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarFactura();
        }
        private void BuscarFactura()
        {
            FirebirdDAL fbDAL = new FirebirdDAL();

            try
            {
                Factura factura = fbDAL.BuscarFactura(txbFolio.Text);

                if (factura != null)
                {
                    if (factura.Importe == 0)
                    {
                        MessageBox.Show("La factura ya ha sido pagada...");
                        gridFacturaEncontrada.DataSource = null;
                        btnAgregar.Enabled = false;                        
                    }
                    else
                    {
                        _FacturaEncontrada = factura;
                        List<Factura> lstFacturaEncontrada = new List<Factura>();
                        lstFacturaEncontrada.Add(factura);
                        gridFacturaEncontrada.DataSource = lstFacturaEncontrada;
                        gvFacturaEncontrada.BestFitColumns();
                        gvFacturaEncontrada.RefreshData();
                        btnAgregar.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro ninguna factura con el Folio: " + txbFolio.Text,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txbFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BuscarFactura();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }
        private void Agregar()
        {
            _lstFacturas.Add(_FacturaEncontrada);
            gridFacturas.DataSource = _lstFacturas.Distinct().ToList();
            gvFacturas.RefreshData();
            gvFacturas.BestFitColumns();
            btnQuitar.Enabled = true;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Quitar();
        }
        private void Quitar()
        {
            int indexFacturaSeleccionada = gvFacturas.GetSelectedRows()[0];
            Factura FacturaSeleccionada = (Factura)gvFacturas.GetRow(indexFacturaSeleccionada);
            _lstFacturas.Remove(FacturaSeleccionada);
            gridFacturas.DataSource = _lstFacturas.Distinct().ToList();
            gvFacturas.RefreshData();
            gvFacturas.BestFitColumns();

            if (_lstFacturas.Count == 0)
                btnQuitar.Enabled = false;
        }
    }
}
