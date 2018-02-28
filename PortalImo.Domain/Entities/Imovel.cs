using System;
using System.Collections.Generic;

namespace PortalImo.Domain.Entities
{
    public partial class Imovel
    {
        public Imovel()
        {
            this.Proprietario = new HashSet<Proprietario>();
        }

        public int codimovel { get; set; }
        public string contribuinte { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public System.DateTime cadastramento { get; set; }
        public string cep { get; set; }
        public string codlog { get; set; }
        public string referencia { get; set; }
        public int qtdesquinafrentes { get; set; }
        public decimal fracaoideal { get; set; }
        public int areaterreno { get; set; }
        public int areaconstruida { get; set; }
        public int areaocupada { get; set; }
        public int valorm2terreno { get; set; }
        public int valorm2construcao { get; set; }
        public int anodaconstrucao { get; set; }
        public int qtdpavimentos { get; set; }
        public int testada { get; set; }
        public Nullable<decimal> fatorobsolescencia { get; set; }
        public int anoiniciovidacontrib { get; set; }
        public int mesiniciovidacontrib { get; set; }
        public int fasecontribuinte { get; set; }
        public System.DateTime datahora { get; set; }
        public int codtipouso { get; set; }
        public int codtipoterreno { get; set; }
        public int codbairro { get; set; }

        public virtual Bairro Bairro { get; set; }
        public virtual TipoTerreno TipoTerreno { get; set; }
        public virtual TipoUso TipoUso { get; set; }
        public virtual ICollection<Proprietario> Proprietario { get; set; }
    }
}