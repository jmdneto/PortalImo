using PortalImo.Domain.Entities;
using PortalImo.Domain.Interfaces.Repositories;
using ProjetoDDD.Infrastructure.Data.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalImo.Infrastructure.Data.Repositories
{
    public class RepositorioDeUsuarios : RepositorioBase<Usuario>,IRepositorioDeUsuarios
    {
        public Usuario CadastraUsuario(Usuario user)
        {
            user.senha = Crypto.EncryptStringAES(user.senha, user.senhaKey);
            return _contexto.Usuarios.Add(user);
        }

        public Usuario LogaUsuario(string email, string senha)
        {
            var usuario = _contexto.Usuarios.Where(e => e.email == email).FirstOrDefault();
                if (usuario == null)
                return null;

            string passDescrypt = Crypto.DecryptStringAES(usuario.senha, usuario.senhaKey);
                if (passDescrypt == senha)
            {
                return  usuario;
            }
            else
            {
                return null;
            }


               
        }

        public Usuario RecuperarUsuarioPorEmail(string email)
        {
            var usuario = _contexto.Usuarios.Where(e => e.email == email).FirstOrDefault();
            return usuario;
        }
    }
}
