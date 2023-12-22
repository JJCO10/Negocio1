using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;

namespace BLL
{
    public class VentaService : Funciones_venta
    {
       VentaRepository repository = new VentaRepository();

        public string RegistrarVenta(Venta venta)
        {
            var msg = repository.RegistrarVenta(venta);
            return msg;
        }

        public string ModificarVenta(Venta Venta)
        {
            return repository.ModifcarVenta(Venta);
        }

        public List<Venta> ConsultarVenta()
        {
            var msg = repository.ConsultarVenta();
            return msg;
        }

        public List<Venta> BuscarFiltradoVenta(string x)
        {
            return ConsultarVenta().Where(
                item => item.idVenta == x || 
                item.saborBoli.Contains(x) || 
                item.fechaBoli.Contains(x)).ToList();
        }

    }
}
