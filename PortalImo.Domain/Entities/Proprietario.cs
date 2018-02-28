using System;
using System.Collections.Generic;

namespace PortalImo.Domain.Entities
{
    public partial class Proprietario
    {
        public Proprietario()
        {
            this.Imovel = new HashSet<Imovel>();
        }

        public int codproprietario { get; set; }
        public string nome { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public Nullable<System.DateTime> nascimento { get; set; }
        public string estadocivil { get; set; }
        public string profissao { get; set; }
        public string tel1 { get; set; }
        public string tel2 { get; set; }
        public string tel3 { get; set; }
        public string email1 { get; set; }
        public string email2 { get; set; }
        public string tipo { get; set; }
        public Nullable<System.DateTime> datahora { get; set; }
        public Nullable<int> codusuario { get; set; }

        public virtual Usuario Usuario { get; set; }
        
        public virtual ICollection<Imovel> Imovel { get; set; }
    }
}