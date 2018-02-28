namespace PortalImo.Infrastructure.Data.Migrations
{
    using PortalImo.Infrastructure.Data.Initializer;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PortalImo.Infrastructure.Data.Context.ContextoBanco>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PortalImo.Infrastructure.Data.Context.ContextoBanco context)
        {
            if (context.Usuarios.Where(x=>x.codusuario==1).Count()==0)
            UserDataBaseInitializer.GetUsuario().ForEach(c => context.Usuarios.Add(c));
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
