using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using Control_de_Reparto.Modelos;

namespace Control_de_Reparto.DAL
{
    public class SqliteDAL
    {
        private SQLiteConnection Conexion;
        private SQLiteCommand Comando;
        private SQLiteDataAdapter Adapter;

        public SqliteDAL()
        {
            Conexion = new SQLiteConnection();
            Comando = new SQLiteCommand();
            Adapter = new SQLiteDataAdapter();

            Conexion.ConnectionString = "Data Source=.\\BD\\ControlDeReparto.sqlite;Version=3;";
        }

        public List<Factura> ObtenerFacturasImpresasDelDia()
        {
            List<Factura> lstFacturasYaImpresas = new List<Factura>();

            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandText =
            string.Format(@"SELECT 
                                folio_factura, clave_cliente, 
                                nombre_cliente, importe_factura, saldo_factura
                            FROM 
                                manejo_impresiones 
                            WHERE 
                                DATE(fecha_impresion) = '{0}'", DateTime.Today.ToString("yyyy-MM-dd"));

            DataTable dt = new DataTable();
            Adapter.SelectCommand = Comando;
            Adapter.Fill(dt);

            Factura factura;
            foreach (DataRow row in dt.Rows)
            {
                factura = new Factura();
                factura.Folio = Convert.ToString(row["folio_factura"]);
                factura.ClaveCliente = Convert.ToString(row["clave_cliente"]);
                factura.NombreCliente = Convert.ToString(row["nombre_cliente"]);
                factura.Importe = Convert.ToDecimal(row["importe_factura"]);
                factura.Saldo = Convert.ToDecimal(row["saldo_factura"]);
                factura.TipoImporte = 'I';
                factura.Reimpresion = true;
                lstFacturasYaImpresas.Add(factura);
            }

            Conexion.Close();

            return lstFacturasYaImpresas;
        }
    }
}
