using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private Conexion conexion = new Conexion();    
        SqlCommand comando = new SqlCommand();
        

       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string primero=pruebaCons()[0];
            label1.Text = primero;
        }
        //Consultar BD
        public List<String> pruebaCons()
        {
            List<string> resultado = new List<string>();
            SqlDataReader leer;
            comando.Connection = conexion.abrirConexion();
            comando.CommandText = "SELECT nombre FROM ejemplo";
            leer = comando.ExecuteReader();
            while (leer.Read())
            {
                resultado.Add(Convert.ToString(leer["nombre"]));
            }
            
            return resultado;
        }
    }
}
