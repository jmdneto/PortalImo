using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalImo.Domain.Entities
{
    public partial class PerfilUsuario
    {

        public int codperfil { get; set; }
        public string nomeperfil { get; set; }
        public DateTime datacadastro { get; set; }
        public bool adminmaster { get; set; }
        public bool ativo { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
        public virtual ICollection<ModulosAcesso> ModulosAcesso { get; set; }

    }

}
