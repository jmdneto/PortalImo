using PortalImo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalImo.Domain.Interfaces.Domain
{
    public interface IServicoDeUsuarioDomain
    {
        Usuario LogaUsuario(string email, string senha);
        Usuario RecuperaUsuarioPorEmail(string email);
        void CadastrarUsuario(Usuario usuario);
    }
}
