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

        public SqliteDAL(string BaseDeDatos)
        {
            Conexion = new SQLiteConnection();
            Comando = new SQLiteCommand();
            Adapter = new SQLiteDataAdapter();

            Conexion.ConnectionString = "Data Source=.\\BD\\"+BaseDeDatos+";Version=3;";
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
                factura.Folio = Convert.ToString(row["folio_factura"]).Trim();
                factura.ClaveCliente = Convert.ToString(row["clave_cliente"]).Trim();
                factura.NombreCliente = Convert.ToString(row["nombre_cliente"]).Trim();
                factura.Importe = Convert.ToDecimal(row["importe_factura"]);
                factura.Saldo = Convert.ToDecimal(row["saldo_factura"]);
                factura.TipoImporte = 'I';
                factura.Reimpresion = true;
                lstFacturasYaImpresas.Add(factura);
            }

            Conexion.Close();

            return lstFacturasYaImpresas;
        }

        public void InsertarFacturasALaBD(List<Factura> lstFacturas, int FolioControl, int ID_Encargado, int ID_Chofer)
        {
            Conexion.Open();
            IDbTransaction Transaccion = Conexion.BeginTransaction();
            Comando.Connection = Conexion;

            try
            {                                
                foreach (Factura factura in lstFacturas)
                {
                    Comando.CommandText =
                        string.Format(@"INSERT INTO 
                                          manejo_impresiones
                                            (folio_factura, importe_factura, fecha_impresion, 
                                             clave_cliente, nombre_cliente, saldo_factura, folio_control,
                                             id_encargado, id_chofer)
                                        VALUES
                                            ('{0}',  {1}, '{2}', 
                                             '{3}', '{4}', {5}, {6}, {7}, {8})",
                                              factura.Folio, factura.Importe, DateTime.Today.ToString("yyyy-MM-dd"),
                                              factura.ClaveCliente, factura.NombreCliente, factura.Saldo,
                                              FolioControl, ID_Encargado, ID_Chofer);
                    Comando.ExecuteNonQuery();

                    Comando.CommandText =
                        string.Format(@"INSERT INTO
                                          folio_direccion
                                            (folio_factura, calle, numero, interior, colonia, codigo_postal)
                                        VALUES
                                            ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",
                                             factura.Folio, factura.sCalle, factura.sNumero, factura.sInterior, factura.sColonia, factura.sCodigoPostal);
                    Comando.ExecuteNonQuery();
                }

                Transaccion.Commit();
                Conexion.Close();
            }
            catch (Exception ex)
            {
                Transaccion.Rollback();
                Conexion.Close();
                throw ex;
            }
        }

        public List<Personal> ObtenerPersonal()
        {
            List<Personal> lstPersonal = new List<Personal>();

            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandText =
            string.Format(@"SELECT id_personal, nombre, tipo FROM personal WHERE status = 1");

            DataTable dt = new DataTable();
            Adapter.SelectCommand = Comando;
            Adapter.Fill(dt);

            Personal persona;
            foreach (DataRow row in dt.Rows)
            {
                persona = new Personal();
                persona.ID_Personal = Convert.ToInt32(row["id_personal"]);
                persona.Nombre = Convert.ToString(row["nombre"]);
                string tipo = Convert.ToString(row["tipo"]);
                switch (tipo)
                {
                    case "C": persona.Tipo = "Chofer"; break;
                    case "R": persona.Tipo = "Responsable"; break;
                }

                lstPersonal.Add(persona);
            }

            Conexion.Close();

            return lstPersonal;
        }
        public List<Personal> ObtenerPersonalPorTipo(char Tipo)
        {
            List<Personal> lstPersonal = new List<Personal>();

            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandText =
            string.Format(@"SELECT id_personal, nombre, tipo FROM personal WHERE tipo LIKE '{0}' AND status = 1", Tipo);

            DataTable dt = new DataTable();
            Adapter.SelectCommand = Comando;
            Adapter.Fill(dt);

            Personal persona;
            foreach (DataRow row in dt.Rows)
            {
                persona = new Personal();
                persona.ID_Personal = Convert.ToInt32(row["id_personal"]);
                persona.Nombre = Convert.ToString(row["nombre"]);
                string tipo = Convert.ToString(row["tipo"]);
                switch (tipo)
                {
                    case "C": persona.Tipo = "Chofer"; break;
                    case "R": persona.Tipo = "Responsable"; break;
                }

                lstPersonal.Add(persona);
            }

            Conexion.Close();

            return lstPersonal;
        }
        public void AgregarPersona(string Nombre, char Tipo)
        {
            List<Personal> lstPersonal = new List<Personal>();

            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandText =
            string.Format(@"INSERT INTO personal (nombre, tipo) VALUES ('{0}', '{1}')", Nombre, Tipo);
            Comando.ExecuteNonQuery();        

            Conexion.Close();
        }

        public int ObtenerFolio()
        {
            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandText =
            string.Format(@"SELECT 
                                  IFNULL(MAX(folio_control), 0) 
                              FROM 
                                  manejo_impresiones");
            object obj = Comando.ExecuteScalar();
            int Folio = Convert.ToInt32(obj);
            Folio++;

            Conexion.Close();

            return Folio;
        }

        public void ModificarPersonal(Personal persona)
        {
            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandText =
            string.Format(@"UPDATE personal 
                               SET nombre = '{0}', Tipo = '{1}' 
                             WHERE id_personal= {2} ", 
                                   persona.Nombre, persona.Tipo, persona.ID_Personal);
            Comando.ExecuteNonQuery();

            Conexion.Close();
        }

        public void EliminarPersonal(Personal persona)
        {
            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandText =
            string.Format(@"UPDATE personal 
                               SET status = 0  
                             WHERE id_personal= {2} ",
                                   persona.Nombre, persona.Tipo, persona.ID_Personal);
            Comando.ExecuteNonQuery();

            Conexion.Close();
        }

        public void ActualizarBaseDeDatos()
        {
            try
            {
                Conexion.Open();

                Comando.Connection = Conexion;
                Comando.CommandText = @"CREATE TABLE folio_direccion 
                                            (folio_factura CHAR(9) NOT NULL , 
                                             calle VARCHAR, 
                                             numero VARCHAR, 
                                             interior VARCHAR, 
                                             colonia VARCHAR, 
                                             codigo_postal VARCHAR)";
                Comando.ExecuteNonQuery();

                Conexion.Close();
            }
            catch (Exception ex)
            {
                if (Conexion.State != System.Data.ConnectionState.Closed)
                    Conexion.Close();
                throw ex;
            }
        }
    }
}
