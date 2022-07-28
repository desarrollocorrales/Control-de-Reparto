using System;
using System.Windows.Forms;
using Control_de_Reparto.Modelos;
using System.Collections.Generic;
using System.Linq;

namespace Control_de_Reparto.GUIs
{
    public partial class Frm_CapturarDireccion : Form
    {
        public Factura factura;
        public List<Cliente> lstClientes;

        public Frm_CapturarDireccion(Factura pFactura, List<Cliente> plstClientes)
        {
            InitializeComponent();

            this.factura = pFactura;
            this.lstClientes = plstClientes;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            factura.NombreCliente = txbCliente.Text.ToUpper();

            factura.sCalle = txbCalle.Text.ToUpper();
            factura.sNumero = txbNumero.Text.ToUpper();
            factura.sInterior = txbInterior.Text.ToUpper();
            factura.sColonia = txbColonia.Text.ToUpper();
            factura.sCodigoPostal = txbCodigoPostal.Text.ToUpper();

            this.Close();
        }

        private void Frm_CapturarDireccion_Load(object sender, EventArgs e)
        {
            lblFolio.Text = "Folio: " + factura.Folio;
            factura.sCalle = string.Empty;
            CargarSugerenciasClientes();
        }
        private void CargarSugerenciasClientes()
        {
            txbCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txbCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
            foreach (Cliente cliente in lstClientes)
            {
                acsc.Add(cliente.sNombre);
            }

            txbCliente.AutoCompleteCustomSource = acsc;
        }

        private void txbCliente_TextChanged(object sender, EventArgs e)
        {
            string sNombreCliente = txbCliente.Text.ToUpper();

            var oCliente = lstClientes.FirstOrDefault(o => o.sNombre == sNombreCliente);
            if (oCliente != null)
            {
                txbCalle.Text = oCliente.sCalle;
                txbNumero.Text = oCliente.sNumero;
                txbInterior.Text = oCliente.sInterior;
                txbColonia.Text = oCliente.sColonia;
                txbCodigoPostal.Text = oCliente.sCodigoPostal;
            }
        }
    }
}
