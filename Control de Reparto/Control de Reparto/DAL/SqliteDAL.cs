using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

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
        }
    }
}
