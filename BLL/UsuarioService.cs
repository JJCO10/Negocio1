using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace BLL
{
    public class UsuarioService
    {
       UsuarioRepository repository = new UsuarioRepository();

        public List<Usuario> ConsultarPrestamista()
        {
            var msg = repository.ConsultarUsuario();
            return msg;
        }

        public List<Usuario> LoginUser(string usuarios, string contraseña)
        {
            return ConsultarPrestamista().Where(x => x.Usurios == usuarios && x.Contraseña == contraseña).ToList(); 
        }

    }
}
