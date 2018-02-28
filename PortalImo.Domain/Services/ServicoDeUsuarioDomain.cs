using PortalImo.Domain.Interfaces.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortalImo.Domain.Entities;
using PortalImo.Domain.Interfaces.Repositories;

namespace PortalImo.Domain.Services
{
    public class ServicoDeUsuarioDomain :ServicoDeDominioBase, IServicoDeUsuarioDomain
    {
        private readonly IRepositorioDeUsuarios _repositorioUsuario;

        public ServicoDeUsuarioDomain(IRepositorioDeUsuarios  repositorioUsuario)
        {
            _repositorioUsuario = repositorioUsuario;
        }
        public Usuario LogaUsuario(string email, string senha)
        {
            var usuarioRetorno = _repositorioUsuario.LogaUsuario(email, senha);
            return usuarioRetorno;
        }

        public Usuario RecuperaUsuarioPorEmail(string email)
        {
            var usuarioRetorno = _repositorioUsuario.RecuperarUsuarioPorEmail(email);
            return usuarioRetorno;
        }

        public void CadastrarUsuario(Usuario usuario)
        {
            try
            {
                IniciarTransacao();
                _repositorioUsuario.CadastraUsuario(usuario);
                PersistirTransacao();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
