using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalImo.Domain.Interfaces.Infraestrutura
{
    public interface IUnidadeDeTrabalho
    {
        void Iniciar();
        void Persistir();
    }
}
