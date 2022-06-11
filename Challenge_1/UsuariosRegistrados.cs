using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    class UsuariosRegistrados
    {
        public string usuario;
        public string contraseña;

        public UsuariosRegistrados(string newUsuario, string newContraseña)
        {
            usuario = newUsuario;
            contraseña = newContraseña;
        } 
    }
}
