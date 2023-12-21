using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace BLL
{
    public interface Funciones_venta
    {
        string RegistrarVenta(Venta venta);
        string ModificarVenta(Venta Venta);
        List<Venta> ConsultarVenta();
    }
}
