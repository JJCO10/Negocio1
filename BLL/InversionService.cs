using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;

namespace BLL
{
    public class InversionService : Funciones_inversion
    {

        InversionRepository repository = new InversionRepository();

        public string RegistrarInversion(Inversion inversion)
        {
            var msg = repository.RegistrarInversion(inversion);
            return msg;
        }

        public string ModificarInversion(Inversion inversion)
        {
            return repository.ModificarInversion(inversion);
        }

        public List<Inversion> ConsultarInversion()
        {
            var msg = repository.ConsultarInversion();
            return msg;
        }

        public List<Inversion> BuscarFiltradoInversion(string x)
        {
            return ConsultarInversion().Where(
                item => item.idInversion == x ||
                item.producto.Contains(x) ||
                item.fechaInversion.Contains(x)).ToList();
        }

    }
}
