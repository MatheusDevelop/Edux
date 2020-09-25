using Edux_API.Contexts;
using Edux_API.Domains;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edux_API.Utils
{
    public class Cadastro
    {
        eduxContext contexto = new eduxContext();

        /// <summary>
        /// Verfica se o usuário existe no banco
        /// </summary>
        /// <param name="user">Objeto usuário</param>
        /// <returns>Se o usuario existe ou não</returns>
        public bool VerificarBanco(Usuario user)
        {
            var usuario = contexto.Usuario.FirstOrDefault(c => c.Nome == user.Nome && c.Email == user.Email);
            if(usuario == null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Cadastra um usuário
        /// </summary>
        /// <param name="user">Objeto usuário</param>
        /// <returns>Usuário cadastrado</returns>
        public bool CadastrarUsuario(Usuario user )
        {
            user.Senha = Crypto.GerarHash(user.Senha, user.Email);

            if (VerificarBanco(user))
            {
                return false;
            }

            contexto.Usuario.Add(user);

            return true;
        }
    }
}
