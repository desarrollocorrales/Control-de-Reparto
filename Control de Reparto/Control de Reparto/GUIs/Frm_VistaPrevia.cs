using Control_de_Reparto.DAL;
using Control_de_Reparto.Modelos;
using DevExpress.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Reparto.GUIs
{
    public partial class Frm_VistaPrevia : Form
    {
        #region Variables
        List<Factura> _lstFacturas;
        DatosComplementarios dc;
        private Personal Encargado; private Personal Chofer;
        string valorSel = string.Empty; string path = string.Empty; string archivoNuevo = string.Empty; string path_D = string.Empty; string Tipo = string.Empty;
        DateTimeFormatInfo dtinfo = new CultureInfo("es-ES", false).DateTimeFormat;
        #endregion

        #region Constructor
        public Frm_VistaPrevia()
        {
            InitializeComponent();
        }
        public Frm_VistaPrevia(List<Factura> lst, Personal E, Personal C, string tipo)
        {
            InitializeComponent();
            _lstFacturas = lst;
            Encargado = E;
            Chofer = C;
            Tipo = tipo;
        }
        private void Frm_VistaPrevia_Load(object sender, EventArgs e)
        {
            if (Tipo == "cobranza")
                ImprimirC();
            else
                Imprimir();
        }

        #endregion

        #region eventos
        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                //sscHoja1.SaveDocument(path_D + archivoNuevo);
                System.Diagnostics.Process.Start(path_D + archivoNuevo);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion

        #region Metodos

        private void Imprimir()
        {
            try
            {
                SqliteDAL SQLite_DAL = new SqliteDAL("ControlDeReparto.db3");
                //Obtener folio.
                int Folio = SQLite_DAL.ObtenerFolio();

                //Llenar datos complementarios
                dc = new DatosComplementarios();
                dc.FolioControl = Folio;
                dc.Sucursal = Properties.Settings.Default.Sucursal;
                dc.Responsable = Encargado.Nombre;
                dc.Chofer = Chofer.Nombre;

                //Generar Lista de facturas a imprimir
                List<Factura> lstFacturasAInsertar = new List<Factura>();
                lstFacturasAInsertar.AddRange(_lstFacturas);
                lstFacturasAInsertar = lstFacturasAInsertar.OrderBy(o => o.NombreCliente).ToList();

                //Insertar las facturas al Excel

                SqliteDAL sqlite = new SqliteDAL("Sucursales.db3");
                valorSel = sqlite.descripcion();

                FormaExcel(_lstFacturas, Encargado, Chofer, dc, Tipo);

                //Insertar facturas a la base de datos
                SQLite_DAL.InsertarFacturasALaBD(lstFacturasAInsertar, Folio, Encargado.ID_Personal, Chofer.ID_Personal);

                //Mostrar el excel en pantalla
                //MessageBox.Show("El documento se ha creado con exito", "OK",
                //                 MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ImprimirC()
        {
            try
            {
                SqliteDAL SQLite_DAL = new SqliteDAL("ControlDeCobranza.db3");
                //Obtener folio.
                int Folio = SQLite_DAL.ObtenerFolio();

                //Llenar datos complementarios
                dc = new DatosComplementarios();
                dc.FolioControl = Folio;
                dc.Sucursal = Properties.Settings.Default.Sucursal;
                dc.Responsable = Encargado.Nombre;
                dc.Chofer = Chofer.Nombre;

                //Generar Lista de facturas a imprimir
                List<Factura> lstFacturasAImprimir = new List<Factura>();
                lstFacturasAImprimir.AddRange(_lstFacturas);

                List<Factura> lstFacturasAInsertar = new List<Factura>();
                lstFacturasAInsertar.AddRange(lstFacturasAImprimir);
                lstFacturasAImprimir = lstFacturasAImprimir.OrderBy(o => o.NombreCliente).ToList();

                //Insertar las facturas al Excel
                SqliteDAL sqlite = new SqliteDAL("Sucursales.db3");
                valorSel = sqlite.descripcion();

                FormaExcel(_lstFacturas, Encargado, Chofer, dc, Tipo);

                //Insertar facturas a la base de datos
                SQLite_DAL.InsertarFacturasALaBD(lstFacturasAInsertar, Folio, Encargado.ID_Personal, Chofer.ID_Personal);

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

        private void FormaExcel(List<Factura> lstFacturas, Personal encargado, Personal chofer, DatosComplementarios dc, string tipo)
        {
            try
            {
                //Crea el nuevo documento .xlsx para llenarlo con los datos y no afectar el documento Original
                path = Environment.CurrentDirectory;
                if(tipo == "reparto")
                    archivoNuevo = @"\Control de reparto" + DateTime.Now.ToString("yyyyMMddhhmmssss") + ".xlsx";
                else
                    archivoNuevo = @"\Control de cobranza" + DateTime.Now.ToString("yyyyMMddhhmmssss") + ".xlsx";

                path_D = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (tipo == "reparto")
                    CopyFile(path + "\\Control de reparto.xlsx", path_D + archivoNuevo);
                else
                    CopyFile(path + "\\Control de cobranza.xlsx", path_D + archivoNuevo);


                //CARGA EL ARCHIVO .xlsx en el formulario
                sscHoja1.LoadDocument(path_D + archivoNuevo);

                
                InsertaEncabezado(sscHoja1.Document);
                InsertaLinea(sscHoja1.Document, lstFacturas, encargado, chofer, dc);

                // Cierra y Guarda el document.
                sscHoja1.SaveDocument(path_D + archivoNuevo);
                
            }
            catch (Exception x)
            {
                throw x;
            }
        }

        private void InsertaEncabezado(IWorkbook workbook)
        {
            workbook.BeginUpdate();
            try
            {
                Worksheet worksheet = workbook.Worksheets["Control"];


                worksheet.Cells["A1"].Value = "Empresa/Sucursal: " + dc.Sucursal;
                worksheet.Cells["H1"].Value = "Conductor: " + dc.Chofer;
                worksheet.Cells["H2"].Value = "Fecha: " + DateTime.Now.Date.ToString("dd/MM/yyyy");
                worksheet.Cells["L1"].Value = "Folio: " + dc.FolioControl.ToString();


                //UpdateValue(wsName, "A36", "Entregué \n" + dc.Responsable, 0, true);
                //UpdateValue(wsName, "E36", "Recibí \n" + dc.Chofer, 0, true);

                //worksheet.Cells["E1"].Value = "MES DE:  " + cmbMes.SelectedItem.ToString() + " AÑO: " + cmbAnio.SelectedItem.ToString();
                //worksheet.Cells["E1"].Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
                //worksheet.Cells["E1"].Font.FontStyle = SpreadsheetFontStyle.Bold;
                //worksheet.Cells["E1"].Font.Size = 16;
                //worksheet.Cells["E1"].FillColor = Color.Yellow;
                //sscHoja1.Document.Worksheets[0].FreezeRows(0);
            }
            catch (Exception x)
            { throw x; }
            finally
            {
                workbook.EndUpdate();
            }
        }

        private void InsertaLinea(IWorkbook Libro, List<Factura> lst, Personal E, Personal C, DatosComplementarios datosComp)
        {
            try
            {
                Libro.BeginUpdate();
                try
                {

                    Worksheet Hoja = Libro.Worksheets[0];
                    int renglon = 8;
                    int contadorRenglones = 1;
                    foreach (Factura factura in lst)
                    {
                        
                        if (contadorRenglones <= lst.Count)
                        {
                            if (contadorRenglones == 1)
                            {
                                Hoja.Rows[renglon + 2].Insert();
                                Range FilaCopy = Libro.Worksheets[0]["A" + (renglon + 1).ToString() + ":L" + (renglon + 1).ToString()];
                                Libro.Worksheets[0].Range["A" + (renglon + 2).ToString() + ":L" + (renglon + 2).ToString()].CopyFrom(FilaCopy);
                            }

                            Hoja.Rows[renglon + 1].Insert();
                            Range FilasCopy = Libro.Worksheets[0]["A" + renglon.ToString() + ":L" + renglon.ToString()];
                            Libro.Worksheets[0].Range["A" + (renglon + 1).ToString() + ":L" + (renglon + 1).ToString()].CopyFrom(FilasCopy);
                        }


                        Hoja.Cells["A" + renglon.ToString()].Value = contadorRenglones.ToString();
                        Cell celdaA = Hoja.Cells["A" + renglon.ToString()];
                        celdaA.Font.FontStyle = SpreadsheetFontStyle.Regular;

                        Hoja.Cells["B" + renglon.ToString()].Value = factura.ClaveCliente.ToString();
                        Hoja.Cells["B" + renglon.ToString()].ColumnWidth = 250;
                        Cell celdaB = Hoja.Cells["B" + renglon.ToString()];
                        celdaB.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                        celdaB.Font.FontStyle = SpreadsheetFontStyle.Regular;

                        Hoja.MergeCells(Hoja.Range["C" + renglon.ToString() + ":F" + renglon.ToString()]);

                        Hoja.Cells["C" + renglon.ToString()].Value = factura.NombreCliente.ToString();
                        Hoja.Cells["C" + renglon.ToString()].ColumnWidth = 425;
                        Cell celdaC = Hoja.Cells["C" + renglon.ToString()];
                        celdaC.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Left;
                        celdaC.Font.FontStyle = SpreadsheetFontStyle.Regular;

                        Hoja.Cells["G" + renglon.ToString()].Value = factura.Folio.ToString();
                        Cell celdaG = Hoja.Cells["G" + renglon.ToString()];
                        celdaG.Font.FontStyle = SpreadsheetFontStyle.Regular;
                        Hoja.Cells["H" + renglon.ToString()].Value = factura.Importe.ToString();
                        Cell celdaH = Hoja.Cells["H" + renglon.ToString()];
                        celdaH.Font.FontStyle = SpreadsheetFontStyle.Regular;
                        Hoja.Cells["I" + renglon.ToString()].Value = factura.Saldo.ToString();
                        Cell celdaI = Hoja.Cells["I" + renglon.ToString()];
                        celdaI.Font.FontStyle = SpreadsheetFontStyle.Regular;


                        renglon++;
                        contadorRenglones++;
                    }

                    //UpdateValue(wsName, "A36", "Entregué \n" + dc.Responsable, 0, true);
                    //UpdateValue(wsName, "E36", "Recibí \n" + dc.Chofer, 0, true);

                    String rango = (renglon + 15).ToString();

                    Hoja.Cells["A" + rango].Value = "Entregué \n" + dc.Responsable;
                    Hoja.Cells["E" + rango].Value = "Recibí \n" + dc.Chofer;
                }
                finally
                {
                    Libro.EndUpdate();
                }
            }
            catch (Exception x)
            { throw x; }
        }

        public string CopyFile(string source, string dest)
        {
            string result = "Copied file";
            try
            {
                // Overwrites existing files
                File.Copy(source, dest, true);
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }

        public string DeleteFile(string source)
        {
            string result = "Copied file";
            try
            {
                // Overwrites existing files
                File.Delete(source);
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
        #endregion


    }
}
