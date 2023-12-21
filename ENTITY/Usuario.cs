using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Usuario
    {
        public string Usurios { get; set; }
        public string Contraseña { get; set; }

        public Usuario()
        {

        }

        public Usuario(string usurios, string contraseña)
        {
            Usurios = usurios;
            Contraseña = contraseña;
        }
    }
}
