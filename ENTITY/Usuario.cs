using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Usuario
    {
        public string Usurio { get; set; }
        public string Contraseña { get; set; }

        public Usuario()
        {

        }

        public Usuario(string usurio, string contraseña)
        {
            Usurio = usurio;
            Contraseña = contraseña;
        }
    }
}
