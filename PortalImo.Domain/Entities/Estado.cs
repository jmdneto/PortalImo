using System;
using System.Collections.Generic;
using System.Text;

namespace PortalImo.Domain.Entities
{
    public partial class Estado
    {
        public Estado()
        {
            this.Cidade = new HashSet<Cidade>();
        }

        public int codestado { get; set; }
        public string nome { get; set; }
        public System.DateTime datahora { get; set; }
        public virtual ICollection<Cidade> Cidade { get; set; }
    }
}
