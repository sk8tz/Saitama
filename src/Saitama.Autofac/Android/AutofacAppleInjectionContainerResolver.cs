using System.Reflection;
using Autofac;
using Saitama.Core.Framework;
using Saitama.Core.Platform;

namespace Saitama.Autofac.Android
{
    public class AutofacAppleInjectionContainerResolver : AndroidPlatformInjectionContainerResolver
    {
        private readonly ContainerBuilder _builder;

        public AutofacAppleInjectionContainerResolver(ContainerBuilder builder, Assembly entryAssembly) : base(entryAssembly)
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
