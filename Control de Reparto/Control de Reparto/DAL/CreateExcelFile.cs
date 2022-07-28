//#define INCLUDE_WEB_FUNCTIONS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Data;
using System.Reflection;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using System.ComponentModel;
using System.IO;
using Control_de_Reparto.Modelos;
using System.Text.RegularExpressions;

namespace ExportToExcel
{
    //
    //  November 2013
    //  http://www.mikesknowledgebase.com
    //
    //  Note: if you plan to use this in an ASP.Net application, remember to add a reference to "System.Web", and to uncomment
    //  the "INCLUDE_WEB_FUNCTIONS" definition at the top of this file.
    //
    //  Release history
    //   - Nov 2013: 
    //        Changed "CreateExcelDocument(DataTable dt, string xlsxFilePath)" to remove the DataTable from the DataSet after creating the Excel file.
    //        You can now create an Excel file via a Stream (making it more ASP.Net friendly)
    //   - Jan 2013: Fix: Couldn't open .xlsx files using OLEDB  (was missing "WorkbookStylesPart" part)
    //   - Nov 2012: 
    //        List<>s with Nullable columns weren't be handled properly.
    //        If a value in a numeric column doesn't have any data, don't write anything to the Excel file (previously, it'd write a '0')
    //   - Jul 2012: Fix: Some worksheets weren't exporting their numeric data properly, causing "Excel found unreadable content in '___.xslx'" errors.
    //   - Mar 2012: Fixed issue, where Microsoft.ACE.OLEDB.12.0 wasn't able to connect to the Excel files created using this class.
    //

    public class CreateExcelFile
    {
        public static bool CreateExcelDocument<T>(List<T> list, string xlsxFilePath)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(ListToDataTable(list));

            return CreateExcelDocument(ds, xlsxFilePath);
        }

        #region HELPER_FUNCTIONS
        //  This function is adapated from: http://www.codeguru.com/forum/showthread.php?t=450171
        //  My thanks to Carl Quirion, for making it "nullable-friendly".
        public static DataTable ListToDataTable<T>(List<T> list)
        {
            DataTable dt = new DataTable();

            foreach (PropertyInfo info in typeof(T).GetProperties())
            {
                dt.Columns.Add(new DataColumn(info.Name, GetNullableType(info.PropertyType)));
            }
            foreach (T t in list)
            {
                DataRow row = dt.NewRow();
                foreach (PropertyInfo info in typeof(T).GetProperties())
                {
                    if (!IsNullableType(info.PropertyType))
                        row[info.Name] = info.GetValue(t, null);
                    else
                        row[info.Name] = (info.GetValue(t, null) ?? DBNull.Value);
                }
                dt.Rows.Add(row);
            }
            return dt;
        }
        private static Type GetNullableType(Type t)
        {
            Type returnType = t;
            if (t.IsGenericType && t.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                returnType = Nullable.GetUnderlyingType(t);
            }
            return returnType;
        }
        private static bool IsNullableType(Type type)
        {
            return (type == typeof(string) ||
                    type.IsArray ||
                    (type.IsGenericType &&
                     type.GetGenericTypeDefinition().Equals(typeof(Nullable<>))));
        }

        public static bool CreateExcelDocument(DataTable dt, string xlsxFilePath)
        {
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            bool result = CreateExcelDocument(ds, xlsxFilePath);
            ds.Tables.Remove(dt);
            return result;
        }
#endregion

        #if INCLUDE_WEB_FUNCTIONS
        /// <summary>
        /// Create an Excel file, and write it out to a MemoryStream (rather than directly to a file)
        /// </summary>
        /// <param name="dt">DataTable containing the data to be written to the Excel.</param>
        /// <param name="filename">The filename (without a path) to call the new Excel file.</param>
        /// <param name="Response">HttpResponse of the current page.</param>
        /// <returns>True if it was created succesfully, otherwise false.</returns>
        public static bool CreateExcelDocument(DataTable dt, string filename, System.Web.HttpResponse Response)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                CreateExcelDocumentAsStream(ds, filename, Response);
                ds.Tables.Remove(dt);
                return true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Failed, exception thrown: " + ex.Message);
                return false;
            }
        }

        public static bool CreateExcelDocument<T>(List<T> list, string filename, System.Web.HttpResponse Response)
        {
            try
            {
                DataSet ds = new DataSet();
                ds.Tables.Add(ListToDataTable(list));
                CreateExcelDocumentAsStream(ds, filename, Response);
                return true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Failed, exception thrown: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Create an Excel file, and write it out to a MemoryStream (rather than directly to a file)
        /// </summary>
        /// <param name="ds">DataSet containing the data to be written to the Excel.</param>
        /// <param name="filename">The filename (without a path) to call the new Excel file.</param>
        /// <param name="Response">HttpResponse of the current page.</param>
        /// <returns>Either a MemoryStream, or NULL if something goes wrong.</returns>
        public static bool CreateExcelDocumentAsStream(DataSet ds, string filename, System.Web.HttpResponse Response)
        {
            try
            {
                System.IO.MemoryStream stream = new System.IO.MemoryStream();
                using (SpreadsheetDocument document = SpreadsheetDocument.Create(stream, SpreadsheetDocumentType.Workbook, true))
                {
                    WriteExcelFile(ds, document);
                }
                stream.Flush();
                stream.Position = 0;

                Response.ClearContent();
                Response.Clear();
                Response.Buffer = true;
                Response.Charset = "";

                //  NOTE: If you get an "HttpCacheability does not exist" error on the following line, make sure you have
                //  manually added System.Web to this project's References.

                Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
                Response.AddHeader("content-disposition", "attachment; filename=" + filename);
                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                byte[] data1 = new byte[stream.Length];
                stream.Read(data1, 0, data1.Length);
                stream.Close();
                Response.BinaryWrite(data1);
                Response.Flush();
                Response.End();

                return true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Failed, exception thrown: " + ex.Message);
                return false;
            }
        }
        #endif      //  End of "INCLUDE_WEB_FUNCTIONS" section

        /// <summary>
        /// Create an Excel file, and write it to a file.
        /// </summary>
        /// <param name="ds">DataSet containing the data to be written to the Excel.</param>
        /// <param name="excelFilename">Name of file to be written.</param>
        /// <returns>True if successful, false if something went wrong.</returns>
        public static bool CreateExcelDocument(DataSet ds, string excelFilename)
        {
            try
            {
                using (SpreadsheetDocument document = SpreadsheetDocument.Create(excelFilename, SpreadsheetDocumentType.Workbook))
                {
                    WriteExcelFile(ds, document);
                }
                Trace.WriteLine("Successfully created: " + excelFilename);
                return true;
            }
            catch (Exception ex)
            {
                Trace.WriteLine("Failed, exception thrown: " + ex.Message);
                return false;
            }
        }

        private static void WriteExcelFile(DataSet ds, SpreadsheetDocument spreadsheet)
        {
            //  Cree el contenido del archivo de Excel. Esta función se utiliza al crear un archivo Excel escribiendo en un archivo o escribiendo en un MemoryStream.
            spreadsheet.AddWorkbookPart();
            spreadsheet.WorkbookPart.Workbook = new DocumentFormat.OpenXml.Spreadsheet.Workbook();

            //  Mi agradecimiento a James Miera por la siguiente línea de código (que impide los accidentes en Excel 2010)
            spreadsheet.WorkbookPart.Workbook.Append(new BookViews(new WorkbookView()));

            //  Si no añadimos un "WorkbookStylesPart", OLEDB se negará a conectarse a este archivo XLSX.
            WorkbookStylesPart workbookStylesPart = spreadsheet.WorkbookPart.AddNewPart<WorkbookStylesPart>("rIdStyles");
            Stylesheet stylesheet = new Stylesheet();
            workbookStylesPart.Stylesheet = stylesheet;

            //  Recorre cada una de las tablas de datos de nuestro DataSet y crea una nueva hoja de cálculo de Excel para cada una de ellas.
            uint worksheetNumber = 1;
            foreach (DataTable dt in ds.Tables)
            {
                //  Para cada hoja de trabajo que desee crear
                string workSheetID = "rId" + worksheetNumber.ToString();
                string worksheetName = dt.TableName;

                WorksheetPart newWorksheetPart = spreadsheet.WorkbookPart.AddNewPart<WorksheetPart>();
                newWorksheetPart.Worksheet = new DocumentFormat.OpenXml.Spreadsheet.Worksheet();

                // crear datos de hoja
                newWorksheetPart.Worksheet.AppendChild(new DocumentFormat.OpenXml.Spreadsheet.SheetData());

                // guardar hoja de cálculo
                WriteDataTableToExcelWorksheet(dt, newWorksheetPart);
                newWorksheetPart.Worksheet.Save();

                // crear la hoja de cálculo en relación con el libro
                if (worksheetNumber == 1)
                    spreadsheet.WorkbookPart.Workbook.AppendChild(new DocumentFormat.OpenXml.Spreadsheet.Sheets());

                spreadsheet.WorkbookPart.Workbook.GetFirstChild<DocumentFormat.OpenXml.Spreadsheet.Sheets>().AppendChild(new DocumentFormat.OpenXml.Spreadsheet.Sheet()
                {
                    Id = spreadsheet.WorkbookPart.GetIdOfPart(newWorksheetPart),
                    SheetId = (uint)worksheetNumber,
                    Name = dt.TableName
                });

                worksheetNumber++;
            }

            spreadsheet.WorkbookPart.Workbook.Save();
        }

        private static void WriteDataTableToExcelWorksheet(DataTable dt, WorksheetPart worksheetPart)
        {
            var worksheet = worksheetPart.Worksheet;
            var sheetData = worksheet.GetFirstChild<SheetData>();

            string cellValue = "";

            //  Cree una fila de encabezado en nuestro archivo de Excel, que contenga un encabezado para cada columna de datos de nuestra DataTable. 
            //  También crearemos un array, mostrando el tipo de cada columna de datos es (texto o numérico), así que cuando venimos a escribir las células reales de los datos, 
            // sabremos si escribir valores de texto o valores de celdas numéricas.
            int numberOfColumns = dt.Columns.Count;
            bool[] IsNumericColumn = new bool[numberOfColumns];

            string[] excelColumnNames = new string[numberOfColumns];
            for (int n = 0; n < numberOfColumns; n++)
                excelColumnNames[n] = GetExcelColumnName(n);

            //
            //  Crear la fila de encabezado en nuestra hoja de cálculo de Excel
            //
            uint rowIndex = 1;

            var headerRow = new Row { RowIndex = rowIndex };  // agregar una fila en la parte superior de la hoja de cálculo
            sheetData.Append(headerRow);

            for (int colInx = 0; colInx < numberOfColumns; colInx++)
            {
                DataColumn col = dt.Columns[colInx];
                AppendTextCell(excelColumnNames[colInx] + "1", col.ColumnName, headerRow);
                IsNumericColumn[colInx] = (col.DataType.FullName == "System.Decimal") || (col.DataType.FullName == "System.Int32");
            }

            //
            //  Ahora, paso a través de cada fila de datos en nuestra DataTable ...
            //
            double cellNumericValue = 0;
            foreach (DataRow dr in dt.Rows)
            {
                // ... cree una nueva fila y añada un conjunto de datos de esta fila.
                ++rowIndex;
                var newExcelRow = new Row { RowIndex = rowIndex };  // agregar una fila en la parte superior de la hoja de cálculo
                sheetData.Append(newExcelRow);

                for (int colInx = 0; colInx < numberOfColumns; colInx++)
                {
                    cellValue = dr.ItemArray[colInx].ToString();

                    // Crear celda con datos
                    if (IsNumericColumn[colInx])
                    {
                        //  Para las celdas numéricas, asegúrese de que nuestros datos de entrada son un número y, a continuación, escríbalos al archivo de Excel. 
                        //  si este valor numérico es null, no escriba nada en el archivo de Excel.
                        cellNumericValue = 0;
                        if (double.TryParse(cellValue, out cellNumericValue))
                        {
                            cellValue = cellNumericValue.ToString();
                            AppendNumericCell(excelColumnNames[colInx] + rowIndex.ToString(), cellValue, newExcelRow);
                        }
                    }
                    else
                    {
                        //  Para las celdas de texto, simplemente escriba los datos de entrada directamente en el archivo de Excel.
                        AppendTextCell(excelColumnNames[colInx] + rowIndex.ToString(), cellValue, newExcelRow);
                    }
                }
            }
        }

        private static void AppendTextCell(string cellReference, string cellStringValue, Row excelRow)
        {
            //  Add a new Excel Cell to our Row 
            Cell cell = new Cell() { CellReference = cellReference, DataType = CellValues.String };
            CellValue cellValue = new CellValue();
            cellValue.Text = cellStringValue;
            cell.Append(cellValue);
            excelRow.Append(cell);
        }

        private static void AppendNumericCell(string cellReference, string cellStringValue, Row excelRow)
        {
            //  Add a new Excel Cell to our Row 
            Cell cell = new Cell() { CellReference = cellReference };
            CellValue cellValue = new CellValue();
            cellValue.Text = cellStringValue;
            cell.Append(cellValue);
            excelRow.Append(cell);
        }

        private static string GetExcelColumnName(int columnIndex)
        {
            //  Convert a zero-based column index into an Excel column reference  (A, B, C.. Y, Y, AA, AB, AC... AY, AZ, B1, B2..)
            //
            //  eg  GetExcelColumnName(0) should return "A"
            //      GetExcelColumnName(1) should return "B"
            //      GetExcelColumnName(25) should return "Z"
            //      GetExcelColumnName(26) should return "AA"
            //      GetExcelColumnName(27) should return "AB"
            //      ..etc..
            //
            if (columnIndex < 26)
                return ((char)('A' + columnIndex)).ToString();

            char firstChar = (char)('A' + (columnIndex / 26) - 1);
            char secondChar = (char)('A' + (columnIndex % 26));

            return string.Format("{0}{1}", firstChar, secondChar);
        }
    }

    public static class Generales
    {
        public static DataTable ToDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i]; table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
    }

    public class formatoReparto
    {
        //string path = "c:\\example\\";
        //string templateName = "PortfolioReport.xlsx";
        WorkbookPart wbPart = null;
        SpreadsheetDocument document = null;
        DatosComplementarios datosComplementarios = null;
        List<Factura> lstFacturas = new List<Factura>();
        WorksheetPart linea;
        string path; string newFileName; string seleccion;

        public formatoReparto()
        {
        }

        public string formatoExcel(string path_, string path_destino, string nombre_archivo, DatosComplementarios dc, List<Factura> lstFacturas_, string seleccionado)
        {
            try
            {
                path = path_; seleccion = seleccionado;
                newFileName = @"\Control de reparto" + DateTime.Now.ToString("yyyyMMddhhmmssss") + ".xlsx";
                CopyFile(path + nombre_archivo, path_destino + newFileName);
                document = SpreadsheetDocument.Open(path_destino + newFileName, true);
                wbPart = document.WorkbookPart;
                datosComplementarios = dc;
                lstFacturas = lstFacturas_;
                string Archivo = CreateReport();
                
                return Archivo;
                
            }
            catch (Exception x)
            { throw x; }
        }

        //Se copia el archivo de excel
        private string CopyFile(string source, string dest)
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

        // Crea el reporte de reparto
        public string CreateReport()
        {
            string wsName = "Control";
            MergeCells mergeCells = new MergeCells();
            int renglon = 8;
            int contadorRenglones = 1;
            foreach (Factura factura in lstFacturas)
            {

                UpdateValue(wsName, "A" + renglon.ToString(), contadorRenglones.ToString(), 0, false);
                UpdateValue(wsName, "B" + renglon.ToString(), factura.ClaveCliente.ToString(), 0, false);
                MergeCell mergeCell = new MergeCell()
                {
                    Reference =
                        new StringValue("C" + renglon.ToString() + ":" + "F" + renglon.ToString())
                };

                mergeCells.Append(mergeCell);
                UpdateValue(wsName, "C" + renglon.ToString(), factura.NombreCliente.ToString(), 0, true);
                UpdateValue(wsName, "G" + renglon.ToString(), factura.Folio.ToString(), 0, true);
                UpdateValue(wsName, "H" + renglon.ToString(), factura.Importe.ToString(), 0, false);
                UpdateValue(wsName, "I" + renglon.ToString(), factura.Saldo.ToString(), 0, false);

                renglon++;
                contadorRenglones++;
            }

            if (seleccion == "CARNICERIA")
            {
                UpdateValue(wsName, "A1", "Empresa/Sucursal: " + datosComplementarios.Sucursal, 0, true);
                UpdateValue(wsName, "H1", "Conductor: " + datosComplementarios.Chofer, 0, true);
                UpdateValue(wsName, "H2", "Fecha: " + DateTime.Now.Date.ToString("dd/MM/yyyy"), 0, true);
                UpdateValue(wsName, "L1", "Folio: " + datosComplementarios.FolioControl.ToString(), 0, true);
                UpdateValue(wsName, "A36", "Entregué \n" + datosComplementarios.Responsable, 0, true);
                UpdateValue(wsName, "E36", "Recibí \n" + datosComplementarios.Chofer, 0, true);
            }
            else
            {
                UpdateValue(wsName, "A1", "Empresa/Sucursal: " + datosComplementarios.Sucursal, 0, true);
                UpdateValue(wsName, "H1", "Conductor: " + datosComplementarios.Chofer, 0, true);
                UpdateValue(wsName, "L1", "Folio: " + datosComplementarios.FolioControl.ToString(), 0, true);
                UpdateValue(wsName, "A71", "Entregué \n" + datosComplementarios.Responsable, 0, true);
                UpdateValue(wsName, "E71", "Recibí \n" + datosComplementarios.Chofer, 0, true);
            }


            // Cierra y Guarda el document.
            document.WorkbookPart.Workbook.Save();
            document.Close();
            //GuardaArchivo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + newFileName);

            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + newFileName;
        }

        public void GuardaArchivo(String filename)
        {
            String dir = filename.Replace(System.IO.Path.GetFileName(filename), String.Empty);
            if (!System.IO.Directory.Exists(dir))
                System.IO.Directory.CreateDirectory(dir);

            SpreadsheetDocument newDoc = SpreadsheetDocument.Create(filename, document.DocumentType);

            //Asegúrese de que está limpio
            newDoc.DeleteParts<OpenXmlPart>(newDoc.GetPartsOfType<OpenXmlPart>());

            //Copiar todas las partes en el nuevo libro
            foreach (OpenXmlPart part in document.GetPartsOfType<OpenXmlPart>())
            {
                OpenXmlPart newPart = newDoc.AddPart<OpenXmlPart>(part);
            }

            //Realizar ' guardar como '
            newDoc.WorkbookPart.Workbook.Save();
            newDoc.Close();
            document.Close();

            //Open new doc
            //this.document = SpreadsheetDocument.Open(filename, true);

        }

        public static void InsertRow(SpreadsheetDocument doc, UInt32 renglon, string idReglon)
        {
            WorkbookPart workbookPart = doc.WorkbookPart;
            WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
            SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().First();

            //find the first row in the sheet data
            Row row1 = sheetData.GetFirstChild<Row>();

            //create a new cell
            Cell cell = new Cell() { CellReference = idReglon + renglon.ToString() };


            //CellFormula cellformula = new CellFormula();
            //cellformula.Text = "IF(H2 = H2,1,0)";
            //cell.Append(cellformula);

            //append the cell to the row
            row1.Append(cell);
        }

        public bool UpdateValue(string sheetName, string addressName, string value, UInt32Value styleIndex, bool isString)
        {
            // Asuma el fracaso.
            bool updated = false;

            Sheet sheet = wbPart.Workbook.Descendants<Sheet>().Where((s) => s.Name == sheetName).FirstOrDefault();

            if (sheet != null)
            {
                Worksheet ws = ((WorksheetPart)(wbPart.GetPartById(sheet.Id))).Worksheet;
                UInt32 rowNumber = GetRowIndex(addressName);
                Cell cell = InsertCellInWorksheet(addressName, rowNumber, ws);
                //Cell cell = InsertCellInWorksheet(ws, addressName);

                if (isString)
                {
                    // Puede recuperar el índice de una cadena existente, o insertar la cadena en la tabla de cadenas compartida y obtener el índice del nuevo elemento.
                    int stringIndex = InsertSharedStringItem(wbPart, value);

                    cell.CellValue = new CellValue(stringIndex.ToString());
                    cell.DataType = new EnumValue<CellValues>(CellValues.SharedString);
                }
                else
                {
                    cell.CellValue = new CellValue(value);
                    cell.DataType = new EnumValue<CellValues>(CellValues.Number);
                }

                if (styleIndex > 0)
                    cell.StyleIndex = styleIndex;

                ws.Save();
                updated = true;
            }

            return updated;
        }

        private Cell InsertCellInWorksheet(string columnName, uint rowIndex, Worksheet worksheet)
        {
            //Worksheet worksheet = worksheetPart.Worksheet;
            SheetData sheetData = worksheet.GetFirstChild<SheetData>();
            string cellReference = columnName;// + rowIndex;

            // Si la hoja de cálculo no contiene una fila con el índice de filas especificado, inserte una.
            Row row;
            if (sheetData.Elements<Row>().Where(r => r.RowIndex == rowIndex).Count() != 0)
            {
                row = sheetData.Elements<Row>().Where(r => r.RowIndex == rowIndex).First();
            }
            else
            {
                row = new Row() { RowIndex = rowIndex };
                sheetData.Append(row);
            }

            // If there is not a cell with the specified column name, insert one.
            if (row.Elements<Cell>().Where(c => c.CellReference.Value == columnName).Count() > 0) //+ rowIndex
            {
                return row.Elements<Cell>().Where(c => c.CellReference.Value == cellReference).First();
            }
            else
            {
                // Cells must be in sequential order according to CellReference. Determine where to insert the new cell.
                Cell refCell = null;
                foreach (Cell cell in row.Elements<Cell>())
                {
                    if (string.Compare(cell.CellReference.Value, cellReference, true) > 0)
                    {
                        refCell = cell;
                        break;
                    }
                }

                Cell newCell = new Cell() { CellReference = cellReference };
                row.InsertAfter(newCell, refCell);

                worksheet.Save();
                return newCell;
            }
        }

        private void InsertAfterRow(UInt32 FilaActual)
        {
            try{
                Sheet sheet = wbPart.Workbook.Descendants<Sheet>().Where((s) => s.Name == "Control").FirstOrDefault();
                var worksheet = ((WorksheetPart)(wbPart.GetPartById(sheet.Id))).Worksheet;
                var worksheetPart = worksheet.WorksheetPart;
                var sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

                Row currentRow; Row cloneRow;
                Cell currentCell; Cell cloneCell;

                currentRow = sheetData.Elements<Row>().FirstOrDefault(r => r.RowIndex == FilaActual);
                cloneRow = (Row)currentRow.CloneNode(true);
                cloneRow.RowIndex = FilaActual + 1; // (uint)Items;

                foreach (var child in cloneRow.ChildElements)
                {
                    if (child is Cell)
                    {
                        currentCell = (Cell)child;
                        cloneCell = (Cell)currentCell.CloneNode(true);
                        // IMPORTANT! this is a very simplistic way of replace something like
                        // A11 to A16 (assuming you have 5 rows to insert)
                        // A more robust way of replacing is beyond this solution's scope.
                        cloneCell.CellReference = cloneCell.CellReference.Value.Replace(FilaActual.ToString(), cloneRow.RowIndex);
                        cloneRow.ReplaceChild<Cell>(cloneCell, currentCell);
                    }
                }
                sheetData.ReplaceChild<Row>(cloneRow, currentRow);

                var newRowIndex = FilaActual;
                newRowIndex++;
                var newRow = new Row()
                {
                    RowIndex = (uint)newRowIndex + 1
                };
                //var lastRow = sheetData.Elements<Row>().Where(l => l.RowIndex == newRowIndex - 1);

                sheetData.InsertAt(newRow, (int)newRowIndex);

                worksheet.Save();
            }
            catch(Exception ex)
            { throw ex; }
        }

        // Dada una hoja de cálculo y una dirección (como "AZ254"), devuelva una referencia de celda o crear la referencia de celda y devolverla.
        private Cell InsertCellInWorksheet(Worksheet ws, string addressName)
        {
            SheetData sheetData = ws.GetFirstChild<SheetData>();
            Cell cell = null;

            UInt32 rowNumber = GetRowIndex(addressName);
            Row row = GetRow(sheetData, rowNumber);

            // If the cell you need already exists, return it.
            // If there is not a cell with the specified column name, insert one.  
            Cell refCell = row.Elements<Cell>().
                Where(c => c.CellReference.Value == addressName).FirstOrDefault();
            if (refCell != null)
            {
                cell = refCell;
            }
            else
            {
                cell = CreateCell(row, addressName);
            }
            return cell;
        }
        

        private Cell CreateCell(Row row, String address)
        {
            Cell cellResult;
            Cell refCell = null;

            // Cells must be in sequential order according to CellReference. Determine where to insert the new cell.
            foreach (Cell cell in row.Elements<Cell>())
            {
                if (string.Compare(cell.CellReference.Value, address, true) > 0)
                {
                    refCell = cell;
                    break;
                }
            }

            cellResult = new Cell();
            cellResult.CellReference = address;

            row.InsertBefore(cellResult, refCell);
            return cellResult;
        }

        private UInt32 GetRowIndex(string address)
        {
            string rowPart;
            UInt32 l;
            UInt32 result = 0;

            for (int i = 0; i < address.Length; i++)
            {
                if (UInt32.TryParse(address.Substring(i, 1), out l))
                {
                    rowPart = address.Substring(i, address.Length - i);
                    if (UInt32.TryParse(rowPart, out l))
                    {
                        result = l;
                        break;
                    }
                }
            }
            return result;
        }

        private Row GetRow(SheetData wsData, UInt32 rowIndex)
        {
            var row = wsData.Elements<Row>().
            Where(r => r.RowIndex.Value == rowIndex).FirstOrDefault();
            if (row == null)
            {
                row = new Row();
                row.RowIndex = rowIndex;
                wsData.Append(row);
            }
            return row;
        }

        // Dada la parte principal del libro y un valor de texto, inserte el texto en la tabla de cadena compartida. Cree la tabla si es necesario. Si el valor ya existe, devuelva su índice. Si no existe, insértela y devuelva su nuevo índice.
        private int InsertSharedStringItem(WorkbookPart wbPart, string value)
        {
            int index = 0;
            bool found = false;
            var stringTablePart = wbPart.GetPartsOfType<SharedStringTablePart>().FirstOrDefault();

            // Si falta la tabla de cadenas compartida, algo está mal. acaba de devolver el índice que encontró en la celda de lo contrario, busque el texto correcto en la tabla.
            if (stringTablePart == null)
            {
                stringTablePart = wbPart.AddNewPart<SharedStringTablePart>();
            }

            var stringTable = stringTablePart.SharedStringTable;
            if (stringTable == null)
            {
                stringTable = new SharedStringTable();
            }

            // Iterar a través de todos los elementos en el SharedStringTable. Si el texto ya existe, devuelva su índice.
            foreach (SharedStringItem item in stringTable.Elements<SharedStringItem>())
            {
                if (item.InnerText == value)
                {
                    found = true;
                    break;
                }
                index += 1;
            }

            if (!found)
            {
                stringTable.AppendChild(new SharedStringItem(new Text(value)));
                stringTable.Save();
            }

            return index;
        }

    }
}
