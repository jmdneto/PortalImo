using System.Collections.Generic;

namespace PortalImo.Domain.Entities
{
    public partial class Cidade
    {
        public Cidade()
        {
            this.Bairro = new HashSet<Bairro>();
            this.Estado = new Estado();
        }

        public int codcidade { get; set; }
        public string nome { get; set; }
        public int codestado { get; set; }
        public System.DateTime datahora { get; set; }
        public virtual ICollection<Bairro> Bairro { get; set; }
        public virtual Estado Estado { get; set; }
    }
}