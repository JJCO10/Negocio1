using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    public class InversionRepository : BaseDatos
    {

        public InversionRepository() 
        { 

        }

        public string RegistrarInversion(Inversion inversion)
        {
            if (inversion == null)
            {
                return "datos incorrectos de la inversion";
            }

            SqlCommand cmd = new SqlCommand("SP_INSERTAR_INVERSION", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_inversion", inversion.idInversion);
            cmd.Parameters.AddWithValue("@producto", inversion.producto);
            cmd.Parameters.AddWithValue("@total_precio", inversion.precioProducto);
            cmd.Parameters.AddWithValue("@fecha_inversion", inversion.fechaInversion);
            AbrirConexion();
            var i = cmd.ExecuteNonQuery();
            CerrarConexion();

            if (i >= 0)
            {
                return $"se registro la inversion exitosamente";
            }

            return "datos invalidos de la inversion";

        }

        public string ModificarInversion(Inversion inversion)
        {
            
            SqlCommand cmd = new SqlCommand("SP_MODIFICAR_INVERSION", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_inversion", inversion.idInversion);
            cmd.Parameters.AddWithValue("@producto", inversion.producto);
            cmd.Parameters.AddWithValue("@total_precio", inversion.precioProducto);
            cmd.Parameters.AddWithValue("@fecha_inversion", inversion.fechaInversion);
            AbrirConexion();
            var i = cmd.ExecuteNonQuery();
            CerrarConexion();

            if (i >= 0)
            {
                return $"se modifico la inversion exitosamente";
            }

            return "datos invalidos de la inversion";

        }

        public List<Inversion> ConsultarInversion()
        {
            List<Inversion> list = new List<Inversion>();
            string ssql = "select * from inversiones";

            SqlCommand cmd = new SqlCommand(ssql, conexion);
            AbrirConexion();
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                list.Add(MapeoInversion(rdr));
            }
            rdr.Close();
            CerrarConexion();

            return list;
        }

        private Inversion MapeoInversion(SqlDataReader reader)
        {
            Inversion inversion = new Inversion
            {
                idInversion = Convert.ToString(reader["idInversion"]),
                producto = Convert.ToString(reader["producto"]),
                precioProducto = Convert.ToDouble(reader["precioProducto"]),
                fechaInversion = Convert.ToString(reader["fechaInversion"]),
            };
            return inversion;
        }

    }
}
