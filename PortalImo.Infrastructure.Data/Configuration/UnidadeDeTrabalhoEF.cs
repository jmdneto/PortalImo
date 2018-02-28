//using CommonServiceLocator;
//using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.ServiceLocation;
using PortalImo.Domain.Interfaces.Infraestrutura;
using PortalImo.Infrastructure.Data.Configuration;
using PortalImo.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDD.Infrastructure.Data.Confinguration
{
    public class UnidadeDeTrabalhoEF : IUnidadeDeTrabalho
    {
        private ContextoBanco _contexto;

        public void Iniciar()
        {
            var gerenciador = ServiceLocator.Current.GetInstance<IGerenciadorDeRepositorio>()
                              as GerenciadorDeRepositorio;

            _contexto = gerenciador.Contexto;
        }

        public void Persistir()
        {
            _contexto.SaveChanges();
        }

    }
}