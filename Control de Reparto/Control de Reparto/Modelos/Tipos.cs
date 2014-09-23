using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Control_de_Reparto.Modelos
{
    public class Tipos
    {
        public char Id { set; get; }
        public string Nombre { set; get; }

        public Tipos(char Id, string Nombre)
        {
            this.Id = Id;
            this.Nombre = Nombre;
        }
    }
}
