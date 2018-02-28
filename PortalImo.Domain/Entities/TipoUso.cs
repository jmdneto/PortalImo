using System.Collections.Generic;

namespace PortalImo.Domain.Entities
{
    public partial class TipoUso
    {

        public TipoUso()
        {
            this.Imovel = new HashSet<Imovel>();
        }

        public int codtipouso { get; set; }
        public string descricao { get; set; }
        public System.DateTime datahora { get; set; }

        
        public virtual ICollection<Imovel> Imovel { get; set; }
    }
}