using Edux_API.Contexts;
using Edux_API.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edux_API.Utils
{
    public class Auth 
    {
        eduxContext contexto = new eduxContext();
        public Usuario AutenticarUsuario(Usuario usuario)
        {
            usuario.Senha = Crypto.GerarHash(usuario.Senha, usuario.Email);

            var user = contexto.Usuario.FirstOrDefault(e => e.Email == usuario.Email && e.Senha == usuario.Senha);

            return user;
        }



    }
}
