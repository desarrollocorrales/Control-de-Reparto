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
            try
            {
                FirebirdDAL fbDAL = new FirebirdDAL();
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
            Factura factura = _lstFacturas.Find(o => o.Folio == _FacturaEncontrada.Folio);
            if (factura == null)
            {
                _lstFacturas.Add(_FacturaEncontrada);
                gridFacturas.DataSource = _lstFacturas;
                gvFacturas.RefreshData();
                gvFacturas.BestFitColumns();
                btnQuitar.Enabled = true;
            }
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Imprimir();
        }
        private void Imprimir()
        {
            try
            {
                SqliteDAL SQLite_DAL = new SqliteDAL();
                //Recuperar todas las facturas impresas en el dia.
                List<Factura> lstFacturasYaImpresas = SQLite_DAL.ObtenerFacturasImpresasDelDia();

                //Generar Lista de facturas a imprimir
                List<Factura> lstFacturasAImprimir = new List<Factura>();
                lstFacturasAImprimir.AddRange(_lstFacturas);

                //Borrar las facturas que ya se imprimieron de las facturas tecleadas.
                foreach (Factura fact in lstFacturasYaImpresas)
                {
                    lstFacturasAImprimir.RemoveAll(o => o.Folio == fact.Folio);
                }
                List<Factura> lstFacturasAInsertar = new List<Factura>();
                lstFacturasAInsertar.AddRange(lstFacturasAImprimir);

                lstFacturasAImprimir.AddRange(lstFacturasYaImpresas);
                lstFacturasAImprimir = lstFacturasAImprimir.OrderBy(o => o.Folio).ToList();

                //Insertar las facturas al Excel
                ExcelDAL Excel_DAL = new ExcelDAL();
                Excel_DAL.CargarDatos(lstFacturasAImprimir);

                //Insertar facturas a la base de datos
                SQLite_DAL.InsertarFacturasALaBD(lstFacturasAInsertar);

                //Mostrar el excel en pantalla
                MessageBox.Show("El documento se ha creado con exito", "OK", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\ControlReparto.xlsx");
            }
            catch (Exception ex)
            {
                StringBuilder sb = new StringBuilder();
                Exception e = ex;
                while (e != null)
                {
                    sb.AppendLine(e.Message);
                    e = e.InnerException;
                }

                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
