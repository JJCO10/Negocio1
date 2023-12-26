using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class BaseDatos
    {
        protected SqlConnection conexion;
        //protected string cadenaConexion = "Server=.\\JJCO10;Database=BD_BOLIS;Trusted_Connection=True;";
        protected string cadenaConexion = "Data Source=JJCO10;Initial Catalog=BD_BOLIS; Integrated Security=True";
        public BaseDatos()
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        public string AbrirConexion()
        {
            conexion.Open();
            return conexion.State.ToString();
        }

        public string CerrarConexion()
        {
            conexion.Close();
            return conexion.State.ToString();
        }
    }
}
