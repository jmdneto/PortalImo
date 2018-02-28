using PortalImo.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using PortalImo.Domain.Entities;
using PortalImo.Infrastructure.Data.Configuration;

namespace PortalImo.Infrastructure.Data.Context
{
    public class ContextoBanco : DbContext
    {
        public ContextoBanco() : base("PortalImoContexto")
        {

        }

        public DbSet<Bairro> Bairros { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Imovel> Imoveis { get; set; }
        public DbSet<Proprietario> Proprietarios { get; set; }
        public DbSet<TipoTerreno> TiposTerreno { get; set; }
        public DbSet<TipoUso> TiposUso { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "cod").Configure(p => p.IsKey());
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));


            modelBuilder.Configurations.Add(new BairrosMap());
            modelBuilder.Configurations.Add(new CidadesMap());
            modelBuilder.Configurations.Add(new EstadosMap());
            modelBuilder.Configurations.Add(new ImoveisMap());
            modelBuilder.Configurations.Add(new ProprietariosMap());
            modelBuilder.Configurations.Add(new TiposTerrenoMap());
            modelBuilder.Configurations.Add(new TiposUsoMap());
            modelBuilder.Configurations.Add(new UsuariosMap());
            


            base.OnModelCreating(modelBuilder);

        }
    }
}
