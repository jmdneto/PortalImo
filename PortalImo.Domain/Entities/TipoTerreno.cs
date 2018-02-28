using System.Collections.Generic;

namespace PortalImo.Domain.Entities
{
    public partial class TipoTerreno
    {
        public TipoTerreno()
        {
            this.Imovel = new HashSet<Imovel>();
        }

        public int codtipoterreno { get; set; }
        public string descricao { get; set; }
        public System.DateTime datahora { get; set; }

       
        public virtual ICollection<Imovel> Imovel { get; set; }
    }
}