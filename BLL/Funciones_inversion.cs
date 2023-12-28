using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace BLL
{
    public interface Funciones_inversion
    {

        string RegistrarInversion(Inversion inversion);
        string ModificarInversion(Inversion inversion);
        string EliminarInversion(Inversion inversion);
        List<Inversion> ConsultarInversion();

    }
}
