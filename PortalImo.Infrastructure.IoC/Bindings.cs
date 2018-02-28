using CommonServiceLocator.SimpleInjectorAdapter;
using Microsoft.Practices.ServiceLocation;
using PortalImo.Domain.Interfaces.Domain;
using PortalImo.Domain.Interfaces.Infraestrutura;
using PortalImo.Domain.Interfaces.Repositories;
using PortalImo.Domain.Services;
using PortalImo.Infrastructure.Data.Configuration;
using PortalImo.Infrastructure.Data.Repositories;
using ProjetoDDD.Infrastructure.Data.Confinguration;
using SimpleInjector;

namespace PortalImo.Infrastructure.IoC
{
    public class Bindings
    {
        public static void Start (Container container)
        {
            //infra
            container.Register<IGerenciadorDeRepositorio,GerenciadorDeRepositorio> ();
            container.Register<IUnidadeDeTrabalho, UnidadeDeTrabalhoEF>();
            container.Register(typeof(IRepositorioBase<>), typeof(RepositorioBase<>), Lifestyle.Scoped);
            container.Register(typeof(IRepositorioDeUsuarios), typeof(RepositorioDeUsuarios), Lifestyle.Scoped);
            // container.Register(typeof(IRepositorioBase<>), typeof(RepositorioBase<>), Lifestyle.Scoped);

            //dominio
            container.Register(typeof(IServicoDeUsuarioDomain), typeof(ServicoDeUsuarioDomain), Lifestyle.Scoped);

            //app

            //service locator
            ServiceLocator.SetLocatorProvider(() => new SimpleInjectorServiceLocatorAdapter(container));
        }
    }
}
