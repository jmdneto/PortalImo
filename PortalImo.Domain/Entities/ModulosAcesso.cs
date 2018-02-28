using System;
using System.Collections.Generic;

namespace PortalImo.Domain.Entities
{
    public partial class ModulosAcesso

    {
        public int codmodulo { get; set; }
        public string nomemodulo { get; set; }
        public string nomemenuacesso { get; set; }
        public string urlmenu { get; set; }
        public bool ativo { get; set; }
        public DateTime datacadastro { get; set; }
        public int? codmodulopai { get; set; }
        public virtual ModulosAcesso ModulosAcessos {get;set; }
        public virtual ICollection<PerfilUsuario> PerfilUsuario { get; set; }

    }
}