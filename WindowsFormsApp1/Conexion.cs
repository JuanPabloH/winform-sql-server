using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class Conexion
    {
        private SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=prueba;Trusted_Connection=True;");

        public SqlConnection abrirConexion()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            return conn;
        }

        public SqlConnection cerrarConexion()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();

            return conn;
        }

    }
}
