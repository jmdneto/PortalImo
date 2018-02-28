using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortalImo.Domain;
using PortalImo.Domain.Entities;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortalImo.Infrastructure.Data.Configuration
{
    public class BairrosMap : EntityTypeConfiguration<Bairro>
    {
        public BairrosMap()
        {
            this.HasKey(t => t.codbairro);
            this.Property(t => t.nome)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.datahora).HasColumnType("datetime2");
            this.ToTable("Bairros", "cadastro");

            this.HasRequired(t => t.Cidade)
                .WithMany(t=>t.Bairro)
                .HasForeignKey(m => m.codcidade);
            //.Map(m => m.MapKey("codcidade"));


        }
    }

    public class CidadesMap : EntityTypeConfiguration<Cidade>
    {
        public CidadesMap()
        {
            this.HasKey(t => t.codcidade);
            this.Property(t => t.nome)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.datahora).HasColumnType("datetime2");
            this.ToTable("Cidades", "cadastro");

            this.HasRequired(t => t.Estado)
                .WithMany(t=>t.Cidade)
                .HasForeignKey(m => m.codestado);
            //.Map(m => m.MapKey("codestado"));


        }
    }


    public class EstadosMap : EntityTypeConfiguration<Estado>
    {
        public EstadosMap()
        {
            this.HasKey(t => t.codestado);
            this.Property(t => t.nome)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.datahora).HasColumnType("datetime2");
            this.ToTable("Estados", "cadastro");

        }
    }

    public class ImoveisMap : EntityTypeConfiguration<Imovel>
    {
        public ImoveisMap()
        {
            this.HasKey(t => t.codimovel);
            //this.Property(t => t.nome)
            //    .IsRequired()
            //    .HasMaxLength(200);

            //this.Property(t => t.datahora).HasColumnType("datetime2");
            this.ToTable("Imoveis", "cadastro");


            this.HasRequired(t => t.TipoTerreno)
                .WithMany(t => t.Imovel)
                .HasForeignKey(m => m.codtipoterreno);
                //.Map(m => m.MapKey("codtipoterreno"));

            this.HasRequired(t => t.TipoUso)
                .WithMany(t=>t.Imovel)
                .HasForeignKey(m => m.codtipouso);
                //.Map(m => m.MapKey("codtipouso"));

            this.HasMany(t => t.Proprietario)
                .WithMany(t => t.Imovel)
                .Map(m =>
                {
                    m.MapLeftKey("codimovel");
                    m.MapRightKey("codproprietario");
                    m.ToTable("ImovelProprietario");
                }
                );

            this.HasRequired(t => t.Bairro)
                .WithMany(t => t.Imovel)
                 .HasForeignKey (m => m.codbairro);
            //.Map(m => m.MapKey("codbairro"));


        }
    }

    public class UsuariosMap : EntityTypeConfiguration<Usuario>
    {
        public UsuariosMap()
        {
            this.HasKey(t => t.codusuario);
            this.Property(t => t.email)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                    new IndexAnnotation(
                        new IndexAttribute("IX_LoginNameUser", 1) { IsUnique = true }));
            this.Property(t => t.senha)
                .IsRequired()
                .HasMaxLength(2048);

            this.Property(t => t.datahora).HasColumnType("datetime2");
            this.Property(t => t.ultimoacesso).HasColumnType("datetime2");



            //this.Property(t => t.datahora).HasColumnType("datetime2");
            this.ToTable("Usuarios", "cadastro");




            //this.HasRequired(t => t.no)
            //    .WithMany()
            //    .Map(m => m.MapKey("codtipoterreno"));

            //this.HasRequired(t => t.TipoUso)
            //    .WithMany()
            //    .Map(m => m.MapKey("codtipouso"));

            //this.HasMany(t => t.Proprietario)
            //    .WithMany(t => t.Imovel)
            //    .Map(m =>
            //    {
            //        m.MapLeftKey("codimovel");
            //        m.MapRightKey("codproprietario");
            //        m.ToTable("ImovelProprietario");
            //    }
            //    );

            //this.HasRequired(t => t.Bairro)
            //    .WithMany()
            //    .Map(m => m.MapKey("codbairro"));


        }
    }
    public class ProprietariosMap : EntityTypeConfiguration<Proprietario>
    {
        public ProprietariosMap()
        {
            this.HasKey(t => t.codproprietario);
            //this.Property(t => t.nome)
            //    .IsRequired()
            //    .HasMaxLength(200)
            //    .HasColumnAnnotation(IndexAnnotation.AnnotationName,
            //        new IndexAnnotation(
            //            new IndexAttribute("IX_LoginNameUser", 1) { IsUnique = true }));
            //this.Property(t => t.senha)
            //    .IsRequired()
            //    .HasMaxLength(2048);

            //this.Property(t => t.datahora).HasColumnType("datetime2");
            //this.Property(t => t.ultimoacesso).HasColumnType("datetime2");



            //this.Property(t => t.datahora).HasColumnType("datetime2");
            this.ToTable("Proprietarios", "cadastro");

        }


    }

    public class TiposTerrenoMap : EntityTypeConfiguration<TipoTerreno>
    {
        public TiposTerrenoMap()
        {
            this.HasKey(t => t.codtipoterreno);
            //this.Property(t => t.nome)
            //    .IsRequired()
            //    .HasMaxLength(200)
            //    .HasColumnAnnotation(IndexAnnotation.AnnotationName,
            //        new IndexAnnotation(
            //            new IndexAttribute("IX_LoginNameUser", 1) { IsUnique = true }));
            //this.Property(t => t.senha)
            //    .IsRequired()
            //    .HasMaxLength(2048);

            //this.Property(t => t.datahora).HasColumnType("datetime2");
            //this.Property(t => t.ultimoacesso).HasColumnType("datetime2");



            //this.Property(t => t.datahora).HasColumnType("datetime2");
            this.ToTable("TiposTerreno", "cadastro");

        }


    }


    public class TiposUsoMap : EntityTypeConfiguration<TipoUso>
    {
        public TiposUsoMap()
        {
            this.HasKey(t => t.codtipouso);
            //this.Property(t => t.nome)
            //    .IsRequired()
            //    .HasMaxLength(200)
            //    .HasColumnAnnotation(IndexAnnotation.AnnotationName,
            //        new IndexAnnotation(
            //            new IndexAttribute("IX_LoginNameUser", 1) { IsUnique = true }));
            //this.Property(t => t.senha)
            //    .IsRequired()
            //    .HasMaxLength(2048);

            //this.Property(t => t.datahora).HasColumnType("datetime2");
            //this.Property(t => t.ultimoacesso).HasColumnType("datetime2");



            //this.Property(t => t.datahora).HasColumnType("datetime2");
            this.ToTable("TiposUso", "cadastro");

        }


    }

}
