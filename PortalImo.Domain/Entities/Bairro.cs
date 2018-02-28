using System.Collections.Generic;

namespace PortalImo.Domain.Entities
{
    public partial class Bairro
    {
        public Bairro()
        {
            this.Imovel = new HashSet<Imovel>();
            this.Cidade = new Cidade();
        }

        public int codbairro { get; set; }
        public string nome { get; set; }
        public System.DateTime datahora { get; set; }
        public int codcidade { get; set; }
        public virtual Cidade Cidade { get; set; }
        public virtual ICollection<Imovel> Imovel { get; set; }
        //public virtual ICollection<Cidade> Cidade { get; set; }
    }
}