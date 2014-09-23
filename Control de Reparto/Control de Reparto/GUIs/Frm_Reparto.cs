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
    public partial class Frm_Reparto : Form
    {
        private Factura FacturaBuscada;
        private Factura _FacturaEncontrada;
        private Factura _CobranzaEncontrada;
        private List<Factura> _lstFacturas;
        private List<Factura> _lstCobranza;
        private Personal Encargado;
        private Personal Chofer;
        public Frm_Reparto()
        {
            InitializeComponent();
            _lstFacturas = new List<Factura>();
            _lstCobranza = new List<Factura>();
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
            LlenarCombos();

            Configuracion oConfig = new Configuracion();
            oConfig.Load();

            lblSucursal.Text = oConfig.Sucursal;
        }
        private void LlenarCombos()
        {
            SqliteDAL sqlite = new SqliteDAL("ControlDeCobranza.db3");

            cbResponsables.DataSource = sqlite.ObtenerPersonalPorTipo('R');
            cbResponsables.DisplayMember = "Nombre";

            cbChoferes.DataSource = sqlite.ObtenerPersonalPorTipo('C');
            cbChoferes.DisplayMember = "Nombre";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pbCargando.Visible = true;
            SegundoPlano.RunWorkerAsync();
        }
        private void BuscarFactura()
        {
            try
            {
                FirebirdDAL fbDAL = new FirebirdDAL();
                FacturaBuscada = fbDAL.BuscarFactura(txbFolioReparto.Text);               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void BuscarCobranza()
        {
            try
            {
                FirebirdDAL fbDAL = new FirebirdDAL();
                FacturaBuscada = fbDAL.BuscarCobranza(txbFolioFactura.Text);
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
            if (validarLista(gvFacturas))
            {
                Imprimir();
            }
            else
            {
                MessageBox.Show("No hay registros que imprimir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Imprimir()
        {
            btnImprimir.Enabled = false;
            try
            {
                SqliteDAL SQLite_DAL = new SqliteDAL("ControlDeReparto.db3");
                //Obtener folio.
                int Folio = SQLite_DAL.ObtenerFolio();

                //Llenar datos complementarios
                DatosComplementarios datosComplementarios = new DatosComplementarios();
                datosComplementarios.FolioControl = Folio;
                datosComplementarios.Sucursal = Properties.Settings.Default.Sucursal;
                datosComplementarios.Responsable = Encargado.Nombre;
                datosComplementarios.Chofer = Chofer.Nombre;

                //Generar Lista de facturas a imprimir
                List<Factura> lstFacturasAInsertar = new List<Factura>();

                lstFacturasAInsertar.AddRange(_lstFacturas);
                lstFacturasAInsertar = lstFacturasAInsertar.OrderBy(o => o.Folio).ToList();

                //Insertar las facturas al Excel
                ExcelDAL Excel_DAL = new ExcelDAL();
                Excel_DAL.CargarDatos(lstFacturasAInsertar, "Control de reparto.xlsx", datosComplementarios);

                //Insertar facturas a la base de datos
                SQLite_DAL.InsertarFacturasALaBD(lstFacturasAInsertar, Folio, Encargado.ID_Personal, Chofer.ID_Personal);

                //Mostrar el excel en pantalla
                MessageBox.Show("El documento se ha creado con exito", "OK", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Control de reparto.xlsx");
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

            btnImprimir.Enabled = true;
        }

        private void SegundoPlano_DoWork(object sender, DoWorkEventArgs e)
        {
            BuscarFactura();
        }

        private void SegundoPlano_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (FacturaBuscada != null)
            {
                if (FacturaBuscada.Saldo == 0)
                {
                    MessageBox.Show("La factura ya ha sido pagada...");
                    gridFacturaEncontrada.DataSource = null;
                    btnAgregar.Enabled = false;
                }
                else
                {
                    _FacturaEncontrada = FacturaBuscada;
                    List<Factura> lstFacturaEncontrada = new List<Factura>();
                    lstFacturaEncontrada.Add(FacturaBuscada);
                    gridFacturaEncontrada.DataSource = lstFacturaEncontrada;
                    gvFacturaEncontrada.BestFitColumns();
                    gvFacturaEncontrada.RefreshData();
                    btnAgregar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("No se encontro ninguna factura con el Folio: " + txbFolioReparto.Text,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            pbCargando.Visible = false;
        }

        private void Pestañas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Pestañas.SelectedIndex == 0)
                lblTitulo.Text = "Control de Reparto";
            else
                lblTitulo.Text = "Control de Cobranza";
        }

        private void btnBuscarCobranza_Click(object sender, EventArgs e)
        {
            pbCargando.Visible = true;
            segundoPlanoCobranza.RunWorkerAsync();
        }

        private void segundoPlanoCobranza_DoWork(object sender, DoWorkEventArgs e)
        {
            BuscarCobranza();
        }

        private void segundoPlanoCobranza_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (FacturaBuscada != null)
            {
                if (FacturaBuscada.Saldo == 0)
                {
                    MessageBox.Show("La factura ya ha sido pagada...");
                    gridFacturaEncontrada.DataSource = null;
                    btnAgregar.Enabled = false;
                }
                else
                {
                    _CobranzaEncontrada = FacturaBuscada;
                    List<Factura> lstCobranzaEncontrada = new List<Factura>();
                    lstCobranzaEncontrada.Add(FacturaBuscada);
                    gridCobranza.DataSource = lstCobranzaEncontrada;
                    gvCobranza.BestFitColumns();
                    gvCobranza.RefreshData();
                    btnAgregarCobranza.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("No se encontro ninguna factura con el Folio: " + txbFolioReparto.Text,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            pbCargando.Visible = false;
        }

        private void btnQuitarCobranza_Click(object sender, EventArgs e)
        {
            QuitarCobranza();
        }
        private void QuitarCobranza()
        {
            int indexFacturaSeleccionada = gvListaCobranza.GetSelectedRows()[0];
            Factura FacturaSeleccionada = (Factura)gvListaCobranza.GetRow(indexFacturaSeleccionada);
            _lstCobranza.Remove(FacturaSeleccionada);
            gridListaCobranza.DataSource = _lstCobranza.Distinct().ToList();
            gvListaCobranza.RefreshData();
            gvListaCobranza.BestFitColumns();

            if (_lstCobranza.Count == 0)
                btnQuitarCobranza.Enabled = false;
        }

        private void btnAgregarCobranza_Click(object sender, EventArgs e)
        {
            AgregarCobranza();
        }
        private void AgregarCobranza()
        {
            Factura factura = _lstCobranza.Find(o => o.Folio == _CobranzaEncontrada.Folio);
            if (factura == null)
            {
                _lstCobranza.Add(_CobranzaEncontrada);
                gridListaCobranza.DataSource = _lstCobranza;
                gvListaCobranza.RefreshData();
                gvListaCobranza.BestFitColumns();
                btnQuitarCobranza.Enabled = true;
            }
        }

        private void btnImprimirCobranza_Click(object sender, EventArgs e)
        {
            if (validarLista(gvListaCobranza))
            {
                ImprimirCobranza();
            }
            else
            {
                MessageBox.Show("No hay registros a imprimir...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ImprimirCobranza()
        {
            btnImprimirCobranza.Enabled = false;
            try
            {                
                SqliteDAL SQLite_DAL = new SqliteDAL("ControlDeCobranza.db3");
                //Obtener folio.
                int Folio = SQLite_DAL.ObtenerFolio();

                //Llenar datos complementarios
                DatosComplementarios datosComplementarios = new DatosComplementarios();
                datosComplementarios.FolioControl = Folio;
                datosComplementarios.Sucursal = Properties.Settings.Default.Sucursal;
                datosComplementarios.Responsable = Encargado.Nombre;
                datosComplementarios.Chofer = Chofer.Nombre;

                //Generar Lista de facturas a imprimir
                List<Factura> lstFacturasAImprimir = new List<Factura>();
                lstFacturasAImprimir.AddRange(_lstCobranza);

                List<Factura> lstFacturasAInsertar = new List<Factura>();
                lstFacturasAInsertar.AddRange(lstFacturasAImprimir);

                lstFacturasAImprimir = lstFacturasAImprimir.OrderBy(o => o.Folio).ToList();

                //Insertar las facturas al Excel
                ExcelDAL Excel_DAL = new ExcelDAL();
                Excel_DAL.CargarDatos(lstFacturasAImprimir, "Control de cobranza.xlsx", datosComplementarios);

                //Insertar facturas a la base de datos
                SQLite_DAL.InsertarFacturasALaBD(lstFacturasAInsertar, Folio, Encargado.ID_Personal, Chofer.ID_Personal);

                //Mostrar el excel en pantalla
                MessageBox.Show("El documento se ha creado con exito", "OK", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Control de cobranza.xlsx");
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

            btnImprimirCobranza.Enabled = true;
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            new ConfiguracionDePersonal().ShowDialog();
            LlenarCombos();
        }

        private void txbFolioFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pbCargando.Visible = true;
                segundoPlanoCobranza.RunWorkerAsync();
            }
        }

        private void cbResponsables_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Encargado = (Personal)cbResponsables.SelectedItem;
        }

        private void cbChoferes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Chofer = (Personal)cbChoferes.SelectedItem;
        }

        private bool validarLista(DevExpress.XtraGrid.Views.Grid.GridView gv)
        {
            if (gv.RowCount == 0)
                return false;
            else
                return true;
        }
    }
}
