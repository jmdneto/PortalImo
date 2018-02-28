using Microsoft.Practices.ServiceLocation;
using PortalImo.Domain.Interfaces.Infraestrutura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalImo.Domain.Services
{
    public class ServicoDeDominioBase
    {
        private IUnidadeDeTrabalho _unidadeDeTrabalho;

        public virtual void IniciarTransacao()
        {
            _unidadeDeTrabalho = ServiceLocator.Current.GetInstance<IUnidadeDeTrabalho>();
            _unidadeDeTrabalho.Iniciar();
        }

        public virtual void PersistirTransacao()
        {
            _unidadeDeTrabalho.Persistir();
        }

    }

}
