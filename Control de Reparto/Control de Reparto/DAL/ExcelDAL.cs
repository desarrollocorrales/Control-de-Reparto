using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetOffice;
using Excel = NetOffice.ExcelApi;
using NetOffice.ExcelApi.Enums;
using Control_de_Reparto.Modelos;

namespace Control_de_Reparto.DAL
{
    public class ExcelDAL
    {
        public void CargarDatos(List<Factura> lstFacturas, string NombreArchivo, DatosComplementarios dc)
        {
            Excel.Application AplicacionExcel = new Excel.Application();
            AplicacionExcel.DisplayAlerts = false;
            AplicacionExcel.Visible = false;

            Excel.Workbook Libro = AplicacionExcel.Workbooks.Open(Environment.CurrentDirectory + "\\" + NombreArchivo);
            Excel.Worksheet Hoja = (Excel.Worksheet)Libro.Sheets[1];

            int renglon = 8;
            int contadorRenglones = 1;
            foreach (Factura factura in lstFacturas)
            {
                //Insertar la linea
                Excel.Range Line = (Excel.Range)Hoja.Rows[renglon];
                Line.Insert();

                //Insertar datos                
                Hoja.Range(string.Format("A{0}", renglon)).Value = contadorRenglones;
                AplicacionExcel.ActiveCell.EntireRow.Font.Bold = false;
                if (factura.Reimpresion == true)
                {
                    Hoja
                        .Range(string.Format("A{0}", renglon))
                        .EntireRow
                        .Interior
                        .Color = System.Drawing.Color.LightGray;
                }
                else
                {
                    Hoja
                        .Range(string.Format("A{0}", renglon))
                        .EntireRow
                        .Interior
                        .Color = System.Drawing.Color.Transparent;
                }

                Hoja.Range(string.Format("B{0}", renglon)).Value = factura.ClaveCliente;
                Hoja.Range(string.Format("C{0}", renglon)).Value = factura.NombreCliente;
                Hoja.Range(string.Format("C{0}:F{0}", renglon)).Merge();
                Hoja.Range(string.Format("C{0}:F{0}", renglon)).HorizontalAlignment = XlHAlign.xlHAlignLeft;
                Hoja.Range(string.Format("G{0}", renglon)).Value = factura.Folio;

                Hoja.Range(string.Format("H{0}", renglon)).Value = factura.Importe;
                Hoja.Range(string.Format("H{0}", renglon)).Style = Libro.Styles["Currency"];
                Hoja.Range(string.Format("H{0}", renglon)).HorizontalAlignment = XlHAlign.xlHAlignRight;
                Hoja.Range(string.Format("I{0}", renglon)).Value = factura.Saldo;
                Hoja.Range(string.Format("I{0}", renglon)).Style = Libro.Styles["Currency"];
                Hoja.Range(string.Format("I{0}", renglon)).HorizontalAlignment = XlHAlign.xlHAlignRight;
                
                renglon++;
                contadorRenglones++;
            }

            Hoja.UsedRange.Replace("{{PERSONAENTREGA}}", dc.Responsable);
            Hoja.UsedRange.Replace("{{SUCURSAL}}", dc.Sucursal);
            Hoja.UsedRange.Replace("{{CHOFER}}", dc.Chofer);
            Hoja.UsedRange.Replace("{{FOLIO}}", dc.FolioControl.ToString().PadLeft(6,'0'));

            Libro.SaveAs(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + NombreArchivo);

            Libro.PrintPreview();

            AplicacionExcel.Quit();
            AplicacionExcel.Dispose();
        }
    }
}
