using PortalImo.UI.Web.App_Start;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebActivator;
using System.Reflection;
using SimpleInjector;

[assembly:PostApplicationStartMethod(typeof (SimpleInjectorInitializer),"Initialize")]

namespace PortalImo.UI.Web.App_Start
{
    public static class SimpleInjectorInitializer
    {
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            InitializeContainer(container);
            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }

        private static void InitializeContainer(Container container)
        {
            Infrastructure.IoC.Bindings.Start(container);
        }
    }
}