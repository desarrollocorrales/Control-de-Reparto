using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Control_de_Reparto.Modelos;

namespace Control_de_Reparto.GUIs
{
    public partial class Frm_Clientes : Form
    {
        public List<Cliente> lstClientes = new List<Cliente>();

        public Frm_Clientes()
        {
            InitializeComponent();
        }

        private void Frm_Clientes_Load(object sender, EventArgs e)
        {
            gridClientes.DataSource = lstClientes;
            gvClientes.BestFitColumns();

            label1.Text = "Clientes encontrados: " + lstClientes.Count;
        }

        private void gvClientes_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (lstClientes.Count>0)
            {
                var index = gvClientes.GetSelectedRows();
                {
                    var lstAux = new List<Cliente>();

                    var cliente = (Cliente)gvClientes.GetRow(index[0]);
                    gridDetallesCliente.DataSource = null;

                    lstAux.Add(cliente);

                    gridDetallesCliente.DataSource = lstAux;
                    gvDetallesCliente.BestFitColumns();
                }
            }
        }

        private void gridClientes_Click(object sender, EventArgs e)
        {
            if (lstClientes.Count > 0)
            {
                var index = gvClientes.GetSelectedRows();
                {
                    var lstAux = new List<Cliente>();

                    var cliente = (Cliente)gvClientes.GetRow(index[0]);
                    gridDetallesCliente.DataSource = null;

                    lstAux.Add(cliente);

                    gridDetallesCliente.DataSource = lstAux;
                    gvDetallesCliente.BestFitColumns();
                }
            }
        }
    }
}
