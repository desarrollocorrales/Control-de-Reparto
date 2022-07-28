using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Control_de_Reparto;

namespace Control_de_Reparto.DAL
{
    public class Configuracion
    {
        public string Sucursal { set; get; }
        public string Servidor { set; get; }
        public string BaseDeDatos { set; get; }
        public string Usuario { set; get; }
        public string Contraseña { set; get; }
        public string Puerto { set; get; }
        public int LongitudSerie { set; get; }

        public void Save()
        {
            Properties.Settings.Default.Sucursal = Sucursal;
            Properties.Settings.Default.Servidor = Servidor;
            Properties.Settings.Default.BaseDeDatos = BaseDeDatos;
            Properties.Settings.Default.Usuario = Usuario;
            Properties.Settings.Default.Contraseña = Contraseña;
            Properties.Settings.Default.Puerto = Puerto;
            Properties.Settings.Default.Serie = LongitudSerie;

            Properties.Settings.Default.Save();
        }

        public void Load()
        {
            Sucursal = Properties.Settings.Default.Sucursal;
            Servidor = Properties.Settings.Default.Servidor;
            BaseDeDatos = Properties.Settings.Default.BaseDeDatos;
            Usuario = Properties.Settings.Default.Usuario;
            Contraseña = Properties.Settings.Default.Contraseña;
            Puerto = Properties.Settings.Default.Puerto;
            LongitudSerie = Properties.Settings.Default.Serie;
             
        }
    }
}
