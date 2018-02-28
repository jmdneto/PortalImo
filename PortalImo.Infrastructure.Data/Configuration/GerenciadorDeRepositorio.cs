using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortalImo.Domain.Interfaces.Infraestrutura;
using PortalImo.Infrastructure.Data.Context;
using System.Web;

namespace PortalImo.Infrastructure.Data.Configuration
{
    public class GerenciadorDeRepositorio:IGerenciadorDeRepositorio
    {
        public const string ContextoHttp = "ContextoHttp";

        public ContextoBanco Contexto
        {
            get
            {
                if (HttpContext.Current.Items[ContextoHttp] == null)
                    HttpContext.Current.Items[ContextoHttp] = new ContextoBanco();
                return HttpContext.Current.Items[ContextoHttp] as ContextoBanco;
            }
        }
        public void Finalizar()
        {
            if (HttpContext.Current.Items[ContextoHttp] != null)
                (HttpContext.Current.Items[ContextoHttp] as ContextoBanco).Dispose();
        }
    }
}
