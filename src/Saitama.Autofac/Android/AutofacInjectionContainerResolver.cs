using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Saitama.Core.Framework;
using Saitama.Core.Platform;

namespace Saitama.Container.Autofac.Android
{
    public class AutofacInjectionContainerResolver : AndroidPlatformInjectionContainerResolver
    {
        private readonly ContainerBuilder _builder;

        public AutofacInjectionContainerResolver(ContainerBuilder builder, Assembly entryAssembly) : base(entryAssembly)
        {
            _builder = builder;
        }

        protected override void RegisterInjectableTypes(Assembly entryAssembly)
        {
            var types = ScanForInjectableTypes();
            foreach (var type in types)
            {
                _builder.RegisterType(type).PropertiesAutowired();
            }
        }

        public override IInjectionContainer GetInjectionContainer()
        {
            return new AutofacInjectionContainer(_builder);
        }
    }
}
