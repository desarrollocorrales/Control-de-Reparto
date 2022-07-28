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
using ExportToExcel;

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
        string valorSel = string.Empty;
        DatosComplementarios datosComplementarios;
        private List<Cliente> lstClientes;
        frmConfig frmA; Frm_VistaPrevia frmVP;
        public Frm_Reparto()
        {
            InitializeComponent();
            _lstFacturas = new List<Factura>();
            _lstCobranza = new List<Factura>();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            frmA = new frmConfig();
            frmA.FormClosed += new FormClosedEventHandler(correctoBtn);
            frmA.ShowDialog();            
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            try
            {

                LlenarCombos();

                Configuracion oConfig = new Configuracion();
                oConfig.Load();

                if (oConfig.Servidor == "Server")
                {
                    frmA = new frmConfig();
                    frmA.FormClosed += new FormClosedEventHandler(correcto);
                    frmA.ShowDialog();
                }
                else
                {
                    SqliteDAL sqlite = new SqliteDAL("Sucursales.db3");
                    lblSucursal.Text = sqlite.descripcion() + " " + oConfig.Sucursal;

                    if (sqlite.descripcion() == "FRIOGOMEZ") btnActualizarClientes.Visible = false;
                    else btnActualizarClientes.Visible = true;

                    CargarClientes();
                    gridCobranza.DataSource = gridFacturaEncontrada.DataSource = gridFacturas.DataSource = gridListaCobranza.DataSource = null;
                }          

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarClientes()
        {
            FirebirdDAL DAL = new FirebirdDAL();
            lstClientes = DAL.getClientes();

            /* Normalizar Telefonos*/
            foreach (Cliente cliente in lstClientes)
            {
                var tel1 = cliente.sTelefono1;
                var tel2 = cliente.sTelefono2;

                if (tel1 != null)
                {
                    tel1 = tel1.Replace("-", string.Empty);
                    tel1 = tel1.Replace(".", string.Empty);
                    tel1 = tel1.Replace(" ", string.Empty);
                    tel1 = tel1.Trim();
                }
                else
                {
                    tel1 = string.Empty;
                }

                if (tel2 != null)
                {
                    tel2 = tel2.Replace("-", string.Empty);
                    tel2 = tel2.Replace(".", string.Empty);
                    tel2 = tel2.Replace(" ", string.Empty);
                    tel2 = tel2.Trim();
                }
                else
                {
                    tel2 = string.Empty;
                }

                cliente.sTelefono1 = tel1;
                cliente.sTelefono2 = tel2;
            }
        }

        private void LlenarCombos()
        {
            SqliteDAL sqlite = new SqliteDAL("ControlDeCobranza.db3");

            cbResponsables.DataSource = sqlite.ObtenerPersonalPorTipo('R');
            cbResponsables.DisplayMember = "Nombre";

            cbChoferes.DataSource = sqlite.ObtenerPersonalPorTipo('C');
            cbChoferes.DisplayMember = "Nombre";

        }

        private void correcto(object sender, EventArgs e)
        {
            try
            {
                if (frmA.DialogResult.ToString() == "OK")
                {
                    ConfiguracionMicrosip frmCon = new ConfiguracionMicrosip();
                    var resultado = frmCon.ShowDialog();

                    if (resultado == System.Windows.Forms.DialogResult.OK)
                        Frm_Principal_Load(null, null);
                }
                else
                {
                    frmA.Close();
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void correctoBtn(object sender, EventArgs e)
        {
            try
            {
                if (frmA.DialogResult.ToString() == "OK")
                {
                    new ConfiguracionMicrosip().ShowDialog();
                    Configuracion oConfig = new Configuracion();
                    oConfig.Load();

                    SqliteDAL sqlite = new SqliteDAL("Sucursales.db3");
                    lblSucursal.Text = "";
                    lblSucursal.Text = sqlite.descripcion() + " " + oConfig.Sucursal;

                    if (sqlite.descripcion() == "FRIOGOMEZ") btnActualizarClientes.Visible = false;
                    else btnActualizarClientes.Visible = true;
                }
                else
                {
                    frmA.Close();
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        private void correctoVP(object sender, EventArgs e)
        {
            try
            {
                if (frmVP.DialogResult.ToString() == "OK")
                {
                    Frm_Principal_Load(null, null);
                }
                else
                {
                    frmVP.Close();
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqliteDAL sqlite = new SqliteDAL("Sucursales.db3");
            string seleccion = sqlite.descripcion();

            if (seleccion == string.Empty)
            {
                MessageBox.Show("Se debe Seleccionar una Sucursal, en el apartado de configuracion de personal");
                return;
            }
            else
            {
                pbCargando.Visible = true;
                SegundoPlano.RunWorkerAsync();
            }
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
                pbCargando.Visible = true;
                SegundoPlano.RunWorkerAsync();
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
                //Para no Repetir Folios en la lista
                if (_FacturaEncontrada.CapturaDireccion == true)
                {
                    Frm_CapturarDireccion frmCaptura = new Frm_CapturarDireccion(_FacturaEncontrada, lstClientes);
                    frmCaptura.ShowDialog();
                    _FacturaEncontrada = frmCaptura.factura;
                }

                if (_FacturaEncontrada.sCalle != string.Empty)
                {
                    _lstFacturas.Add(_FacturaEncontrada);
                    gridFacturas.DataSource = _lstFacturas;
                    gvFacturas.RefreshData();
                    gvFacturas.BestFitColumns();
                    btnQuitar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Debe Capturar la dirección del cliente...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txbFolioReparto.Focus();
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
                frmVP = new Frm_VistaPrevia(_lstFacturas, Encargado, Chofer, "reparto");
                frmVP.FormClosed += new FormClosedEventHandler(correctoVP);
                frmVP.ShowDialog();
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
                datosComplementarios = new DatosComplementarios();
                datosComplementarios.FolioControl = Folio;
                datosComplementarios.Sucursal = Properties.Settings.Default.Sucursal;
                datosComplementarios.Responsable = Encargado.Nombre;
                datosComplementarios.Chofer = Chofer.Nombre;

                //Generar Lista de facturas a imprimir
                List<Factura> lstFacturasAInsertar = new List<Factura>();
                lstFacturasAInsertar.AddRange(_lstFacturas);
                lstFacturasAInsertar = lstFacturasAInsertar.OrderBy(o => o.NombreCliente).ToList();

                //Insertar las facturas al Excel

                //Metodo Anterior
                //ExcelDAL Excel_DAL = new ExcelDAL();

                SqliteDAL sqlite = new SqliteDAL("Sucursales.db3");
                valorSel = sqlite.descripcion();

                formatoReparto obj_exp_doc = new formatoReparto();

                string nombre_archivo;

                if(valorSel == "CARNICERIA")
                    nombre_archivo = @"\Control de reparto_15.xlsx";
                else
                    nombre_archivo = @"\Control de reparto_50.xlsx"; // + DateTime.Now.ToString("yyyyMMddhhmmssss") + ".xlsx";

                //string excelFilename = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + nombre_archivo; 
                // @"\Control de reparto" + DateTime.Now.ToString("yyyyMMddhhmmssss") + ".xlsx";
                string archivoF = obj_exp_doc.formatoExcel(Environment.CurrentDirectory, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), nombre_archivo, datosComplementarios, lstFacturasAInsertar, valorSel);
                
                //ExportToExcel.CreateExcelFile.CreateExcelDocument(ds, excelFilename);
                //Excel_DAL.CargarDatos(lstFacturasAInsertar, "Control de reparto.xlsx", datosComplementarios);

                //Insertar facturas a la base de datos
                SQLite_DAL.InsertarFacturasALaBD(lstFacturasAInsertar, Folio, Encargado.ID_Personal, Chofer.ID_Personal);

                //Mostrar el excel en pantalla
                MessageBox.Show("El documento se ha creado con exito", "OK", 
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                System.Diagnostics.Process.Start(archivoF);
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

        private void btnImprimirCobranza_Click(object sender, EventArgs e)
        {
            if (validarLista(gvListaCobranza))
            {
                frmVP = new Frm_VistaPrevia(_lstCobranza, Encargado, Chofer, "cobranza");
                frmVP.FormClosed += new FormClosedEventHandler(correctoVP);
                frmVP.ShowDialog();
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
                datosComplementarios = new DatosComplementarios();
                datosComplementarios.FolioControl = Folio;
                datosComplementarios.Sucursal = Properties.Settings.Default.Sucursal;
                datosComplementarios.Responsable = Encargado.Nombre;
                datosComplementarios.Chofer = Chofer.Nombre;

                //Generar Lista de facturas a imprimir
                List<Factura> lstFacturasAImprimir = new List<Factura>();
                lstFacturasAImprimir.AddRange(_lstCobranza);

                List<Factura> lstFacturasAInsertar = new List<Factura>();
                lstFacturasAInsertar.AddRange(lstFacturasAImprimir);

                lstFacturasAImprimir = lstFacturasAImprimir.OrderBy(o => o.NombreCliente).ToList();

                SqliteDAL sqlite = new SqliteDAL("Sucursales.db3");
                valorSel = sqlite.descripcion();
                formatoReparto obj_exp_doc = new formatoReparto();

                string nombre_archivo;

                if (valorSel == "CARNICERIA")
                    nombre_archivo = @"\Control de cobranza_15.xlsx";
                else
                    nombre_archivo = @"\Control de cobranza_50.xlsx"; // + DateTime.Now.ToString("yyyyMMddhhmmssss") + ".xlsx";

                string archivoF = obj_exp_doc.formatoExcel(Environment.CurrentDirectory, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), nombre_archivo, datosComplementarios, lstFacturasAInsertar, valorSel);

                //Insertar facturas a la base de datos
                SQLite_DAL.InsertarFacturasALaBD(lstFacturasAInsertar, Folio, Encargado.ID_Personal, Chofer.ID_Personal);



                ////Insertar las facturas al Excel
                //CreateExcelFile export = new CreateExcelFile();
                ////ExcelDAL Excel_DAL = new ExcelDAL();
                //DataSet ds = new DataSet();

                //DataTable dt = new DataTable();
                //dt = lstFacturasAImprimir.ToDataTable(); // ToDataTable(lstFacturasAImprimir);
                //ds.Tables.Add(dt);

                //string excelFilename = "C:\\Users\\Guillermo\\Desktop\\HOJA CALCULO\\ejemploCreacion.xlsx";
                //CreateExcelFile.CreateExcelDocument(ds, excelFilename);
                ////Excel_DAL.CargarDatos(lstFacturasAImprimir, "Control de cobranza.xlsx", datosComplementarios);
                

                //Mostrar el excel en pantalla
                MessageBox.Show("El documento se ha creado con exito", "OK",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);

                System.Diagnostics.Process.Start(archivoF);
                //System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Control de cobranza.xlsx");
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

                btnAgregar.Focus();
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
            SqliteDAL sqlite = new SqliteDAL("Sucursales.db3");
            string seleccion = sqlite.descripcion();

            if (seleccion == string.Empty) throw new Exception("Se debe Seleccionar una Sucursal, en el apartado de configuracion de personal");
            else
            {
                pbCargando.Visible = true;
                segundoPlanoCobranza.RunWorkerAsync();
            }            
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
                MessageBox.Show("No se encontro ninguna factura con el Folio: " + txbFolioFactura.Text,
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

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            new ConfiguracionDePersonal().ShowDialog();
            LlenarCombos();

            Configuracion oConfig = new Configuracion();
            oConfig.Load();
            SqliteDAL sqlite = new SqliteDAL("Sucursales.db3");
            lblSucursal.Text = "";
            lblSucursal.Text = sqlite.descripcion() + " " + oConfig.Sucursal;

            if (sqlite.descripcion() == "FRIOGOMEZ") btnActualizarClientes.Visible = false;
            else btnActualizarClientes.Visible = true;

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

        private void txbFolioReparto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizarClientes_Click(object sender, EventArgs e)
        {
            CargarClientes();
            MessageBox.Show("¡Los clientes se han actualizado con exito!", "Actualizar Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            var lstEncontrado = lstClientes.FindAll(o => o.sTelefono1.Contains(txbTelefono.Text) || o.sTelefono2.Contains(txbTelefono.Text));
            
            Frm_Clientes f = new Frm_Clientes();
            f.lstClientes = lstEncontrado.OrderBy(o=>o.sNombre).ToList();
            f.ShowDialog();
        }

        private void txbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

    }
}
