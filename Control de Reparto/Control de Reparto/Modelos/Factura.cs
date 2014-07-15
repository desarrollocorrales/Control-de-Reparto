using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control_de_Reparto.Modelos
{
    public class Factura
    {
        public int ID_Factura { set; get; }
        public string Folio { set; get; }
        public string ClaveCliente { set; get; }
        public string NombreCliente { set; get; }
        public decimal Importe { set; get; }
        public decimal Saldo { set; get; }
        public char TipoImporte { set; get; }
        public bool Reimpresion { set; get; }
    }
}
