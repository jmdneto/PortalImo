using System;
using System.Collections.Generic;

namespace PortalImo.Domain.Entities
{
    public partial class Usuario
    {
        public Usuario()
        {
           // this.Proprietario = new HashSet<Proprietario>();
        }

        public string email { get; set; }
        public string senha { get; set; }
        public string senhaKey { get; set; }
        public int? codperfil { get; set; }
        public bool master { get; set; }
        public bool ativo { get; set; }
        public int codusuario { get; set; }
        public System.DateTime datahora { get; set; }
        public Nullable<System.DateTime> ultimoacesso { get; set; }

        
       // public virtual ICollection<Proprietario> Proprietario { get; set; }
        // public virtual Usuario_admin Usuario_admin { get; set; }
    }
}