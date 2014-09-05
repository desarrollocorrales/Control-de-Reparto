using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using Control_de_Reparto.Modelos;

namespace Control_de_Reparto.DAL
{
    public class FirebirdDAL
    {
        FbConnection Conexion;
        FbCommand Comando;
        FbDataAdapter Adapter;

        public FirebirdDAL()
        {
            Conexion = new FbConnection();
            Comando = new FbCommand();
            Adapter = new FbDataAdapter();

            Conexion.ConnectionString = getConnectionString();
        }

        private string getConnectionString()
        {
            Configuracion Conf = new Configuracion();
            Conf.Load();

            FbConnectionStringBuilder fbcsb = new FbConnectionStringBuilder();
            fbcsb.DataSource = Conf.Servidor;
            fbcsb.Database = Conf.BaseDeDatos;
            fbcsb.UserID = Conf.Usuario;
            fbcsb.Password = Conf.Contraseña;
            fbcsb.Port = Convert.ToInt32(Conf.Puerto);

            return fbcsb.ConnectionString;
        }

        public bool ProbarConexion()
        {
            bool exito = false;

            Conexion.Open();
            Conexion.Close();
            exito = true;

            return exito;
        }

        public Factura BuscarFactura(string Folio)
        {
            Configuracion oConfig = new Configuracion();
            oConfig.Load();
            int longitudFolio = 9 - oConfig.LongitudSerie;
            string FolioMicrosip = getSerie(Folio) + getFolio(Folio).PadLeft(longitudFolio, '0');
            string FolioTicket = getSerie(Folio) + getFolio(Folio).PadLeft(8, '0');
            string Consulta =
                string.Format(@"SELECT 
                                  DOCTOS_CC.DOCTO_CC_ID,
                                  DOCTOS_CC.FOLIO,
                                  IMPORTES_DOCTOS_CC.IMPORTE,
                                  IMPORTES_DOCTOS_CC.TIPO_IMPTE,
                                  IMPORTES_DOCTOS_CC.FECHA,
                                  COALESCE(CLAVES_CLIENTES.CLAVE_CLIENTE,'') AS CLAVE_CLIENTE,
                                  CLIENTES.NOMBRE AS NOMBRE_CLIENTE
                                FROM
                                  IMPORTES_DOCTOS_CC
                                  INNER JOIN DOCTOS_CC ON (IMPORTES_DOCTOS_CC.DOCTO_CC_ACR_ID = DOCTOS_CC.DOCTO_CC_ID)
                                  INNER JOIN CLIENTES ON (DOCTOS_CC.CLIENTE_ID = CLIENTES.CLIENTE_ID)
                                  LEFT OUTER JOIN CLAVES_CLIENTES ON (CLIENTES.CLIENTE_ID = CLAVES_CLIENTES.CLIENTE_ID)
                                WHERE
                                  DOCTOS_CC.FOLIO LIKE '{0}'

                                UNION ALL

                                SELECT 
                                  DOCTOS_PV.DOCTO_PV_ID AS ID,
                                  DOCTOS_PV.FOLIO,
                                  DOCTOS_PV.IMPORTE_NETO AS IMPORTE,
                                  'C' AS TIPO_IMPTE,
                                  DOCTOS_PV.FECHA,
                                  'TICKET' AS CLAVE_CLIENTE,
                                  '' AS NOMBRE_CLIENTE
                                FROM
                                  DOCTOS_PV
                                WHERE
                                  DOCTOS_PV.FOLIO LIKE '{1}'", FolioMicrosip, FolioTicket);

            /* Acceso a base de datos */
            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandText = Consulta;
            Adapter.SelectCommand = Comando;

            DataTable tablaResultado = new DataTable();
            Adapter.Fill(tablaResultado);

            Factura oFactura;
            List<Factura> lstFacturas = new List<Factura>();
            foreach (DataRow row in tablaResultado.Rows)
            {
                oFactura = new Factura();
                oFactura.ID_Factura = Convert.ToInt32(row["DOCTO_CC_ID"]);
                oFactura.Folio = Folio.Trim();
                oFactura.ClaveCliente = Convert.ToString(row["CLAVE_CLIENTE"]).Trim();
                oFactura.NombreCliente = Convert.ToString(row["NOMBRE_CLIENTE"]).Trim();                
                oFactura.TipoImporte = Convert.ToChar(row["TIPO_IMPTE"]);
                if (oFactura.TipoImporte == 'R')
                {
                    oFactura.Saldo = 0 - Convert.ToDecimal(row["IMPORTE"]);
                }
                else
                {
                    oFactura.Saldo = Convert.ToDecimal(row["IMPORTE"]);
                    oFactura.Importe = Convert.ToDecimal(row["IMPORTE"]);
                }

                oFactura.Reimpresion = false;
                lstFacturas.Add(oFactura);
            }

            Conexion.Close();
            /**************************/

            if (lstFacturas.Count != 0)
            {
                Factura FacturaFinal = new Factura();
                FacturaFinal.ID_Factura = lstFacturas[0].ID_Factura;
                FacturaFinal.Folio = lstFacturas[0].Folio;
                FacturaFinal.ClaveCliente = lstFacturas[0].ClaveCliente;
                FacturaFinal.NombreCliente = lstFacturas[0].NombreCliente;
                FacturaFinal.TipoImporte = 'C';
                FacturaFinal.Importe = lstFacturas.Sum(o => o.Importe);
                FacturaFinal.Saldo = lstFacturas.Sum(o => o.Saldo);
                return FacturaFinal;
            }
            else
            {
                return null;
            }
        }
        public Factura BuscarCobranza(string Folio)
        {
            Configuracion oConfig = new Configuracion();
            oConfig.Load();
            int longitudFolio = 9 - oConfig.LongitudSerie;
            string FolioMicrosip = getSerie(Folio) + getFolio(Folio).PadLeft(longitudFolio, '0');
            string Consulta =
                string.Format(@"SELECT 
                                  DOCTOS_CC.DOCTO_CC_ID,
                                  DOCTOS_CC.FOLIO,
                                  IMPORTES_DOCTOS_CC.IMPORTE,
                                  IMPORTES_DOCTOS_CC.TIPO_IMPTE,
                                  IMPORTES_DOCTOS_CC.FECHA,
                                  COALESCE(CLAVES_CLIENTES.CLAVE_CLIENTE,'') AS CLAVE_CLIENTE,
                                  CLIENTES.NOMBRE AS NOMBRE_CLIENTE
                                FROM
                                  IMPORTES_DOCTOS_CC
                                  INNER JOIN DOCTOS_CC ON (IMPORTES_DOCTOS_CC.DOCTO_CC_ACR_ID = DOCTOS_CC.DOCTO_CC_ID)
                                  INNER JOIN CLIENTES ON (DOCTOS_CC.CLIENTE_ID = CLIENTES.CLIENTE_ID)
                                  LEFT OUTER JOIN CLAVES_CLIENTES ON (CLIENTES.CLIENTE_ID = CLAVES_CLIENTES.CLIENTE_ID)
                                WHERE
                                  DOCTOS_CC.FOLIO LIKE '{0}'", FolioMicrosip);

            /* Acceso a base de datos */
            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandText = Consulta;
            Adapter.SelectCommand = Comando;

            DataTable tablaResultado = new DataTable();
            Adapter.Fill(tablaResultado);

            Factura oFactura;
            List<Factura> lstFacturas = new List<Factura>();
            foreach (DataRow row in tablaResultado.Rows)
            {
                oFactura = new Factura();
                oFactura.ID_Factura = Convert.ToInt32(row["DOCTO_CC_ID"]);
                oFactura.Folio = Folio.Trim();
                oFactura.ClaveCliente = Convert.ToString(row["CLAVE_CLIENTE"]).Trim();
                oFactura.NombreCliente = Convert.ToString(row["NOMBRE_CLIENTE"]).Trim();
                oFactura.TipoImporte = Convert.ToChar(row["TIPO_IMPTE"]);
                if (oFactura.TipoImporte == 'R')
                {
                    oFactura.Saldo = 0 - Convert.ToDecimal(row["IMPORTE"]);
                }
                else
                {
                    oFactura.Saldo = Convert.ToDecimal(row["IMPORTE"]);
                    oFactura.Importe = Convert.ToDecimal(row["IMPORTE"]);
                }

                oFactura.Reimpresion = false;
                lstFacturas.Add(oFactura);
            }

            Conexion.Close();
            /**************************/

            if (lstFacturas.Count != 0)
            {
                Factura FacturaFinal = new Factura();
                FacturaFinal.ID_Factura = lstFacturas[0].ID_Factura;
                FacturaFinal.Folio = lstFacturas[0].Folio;
                FacturaFinal.ClaveCliente = lstFacturas[0].ClaveCliente;
                FacturaFinal.NombreCliente = lstFacturas[0].NombreCliente;
                FacturaFinal.TipoImporte = 'C';
                FacturaFinal.Importe = lstFacturas.Sum(o => o.Importe);
                FacturaFinal.Saldo = lstFacturas.Sum(o => o.Saldo);
                return FacturaFinal;
            }
            else
            {
                return null;
            }
        }
        private string getSerie(string Folio)
        {
            StringBuilder serie = new StringBuilder();

            foreach (char letra in Folio)
            {
                if (char.IsLetter(letra) == true)
                {
                    serie.Append(letra);
                }
                else
                {
                    break;
                }
            }

            return serie.ToString();
        }
        private string getFolio(string Folio)
        {
            StringBuilder folio = new StringBuilder();

            foreach (char letra in Folio)
            {
                if (char.IsDigit(letra) == true)
                {
                    folio.Append(letra);
                }
            }

            return folio.ToString();
        }
    }
}
