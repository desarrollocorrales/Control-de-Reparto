using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using NetOffice;
using Excel = NetOffice.ExcelApi;
using NetOffice.ExcelApi.Enums;

using Control_de_Reparto.DAL;
using Control_de_Reparto.Modelos;

namespace Control_de_Reparto.GUIs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               /* var x = new Excel.Application();
                x.DisplayAlerts = false; 
                x.Visible = false;

                Excel.Workbook wb = x.Workbooks.Open(Environment.CurrentDirectory + "\\Control de reparto.xlsx");
                Excel.Worksheet ws = (Excel.Worksheet)wb.Sheets[1];

                ws.Range("A8").Value = "Tremesco";
                Excel.Range Line = (Excel.Range)ws.Rows[9];
                Line.Insert();

                wb.SaveAs(Environment.CurrentDirectory + "\\Tremesco.xlsx");

                x.Quit();
                x.Dispose();*/

                ExcelDAL x = new ExcelDAL();
                SqliteDAL s = new SqliteDAL();
                List<Factura> lst = s.ObtenerFacturasImpresasDelDia();
                
                x.CargarDatos(lst);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
