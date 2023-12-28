using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace DAL
{
    public class VentaRepository : BaseDatos
    {
        public VentaRepository() : base() 
        {
            
        }

        public string RegistrarVenta(Venta venta)
        {
            if (venta == null)
            {
                return "datos incorrectos de la venta";
            }

            SqlCommand cmd = new SqlCommand("SP_INSERTAR_VENTA", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_venta",venta.idVenta);
            cmd.Parameters.AddWithValue("@sabor", venta.saborBoli);
            cmd.Parameters.AddWithValue("@precio", venta.precio);
            cmd.Parameters.AddWithValue("@cantidad", venta.cantidadBoli);
            cmd.Parameters.AddWithValue("@fecha", venta.fechaBoli);
            AbrirConexion();
            var i = cmd.ExecuteNonQuery();
            CerrarConexion();

            if (i >= 0)
            {
                return $"se registro la venta exitosamente";
            }

            return "datos invalidos de la venta";

        }

        public string ModifcarVenta(Venta venta)
        {
            
            SqlCommand cmd = new SqlCommand("SP_MODIFICAR_VENTA", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_venta", venta.idVenta);
            cmd.Parameters.AddWithValue("@sabor", venta.saborBoli);
            cmd.Parameters.AddWithValue("@precio", venta.precio);
            cmd.Parameters.AddWithValue("@cantidad", venta.cantidadBoli);
            cmd.Parameters.AddWithValue("@fecha", venta.fechaBoli);
            AbrirConexion();
            var i = cmd.ExecuteNonQuery();
            CerrarConexion();

            if (i >= 0)
            {
                return $"se actualizo la venta exitosamente";
            }

            return "datos invalidos de la venta";

        }
        public string EliminarVenta(Venta venta)
        {

            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_VENTA", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_venta", venta.idVenta);
            cmd.Parameters.AddWithValue("@sabor", venta.saborBoli);
            cmd.Parameters.AddWithValue("@precio", venta.precio);
            cmd.Parameters.AddWithValue("@cantidad", venta.cantidadBoli);
            cmd.Parameters.AddWithValue("@fecha", venta.fechaBoli);
            AbrirConexion();
            var i = cmd.ExecuteNonQuery();
            CerrarConexion();

            if (i >= 0)
            {
                return $"se actualizo la venta exitosamente";
            }

            return "datos invalidos de la venta";

        }

        public List<Venta> ConsultarVenta()
        {
            List<Venta> list = new List<Venta>();
            string ssql = "select * from ventas";

            SqlCommand cmd = new SqlCommand(ssql, conexion);
            AbrirConexion();
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                list.Add(Mapeo(rdr));
            }
            rdr.Close();
            CerrarConexion();

            return list;
        }

        private Venta Mapeo(SqlDataReader reader)
        {
            Venta venta = new Venta
            {
                idVenta = Convert.ToString(reader["id_venta"]),
                saborBoli = Convert.ToString(reader["sabor"]),
                precio = Convert.ToDouble(reader["precio"]),
                cantidadBoli = Convert.ToInt32(reader["cantidad"]),
                fechaBoli = Convert.ToString(reader["fecha"]),
            };
            return venta;
        }
    }
}
