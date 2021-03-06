﻿using System.Reflection;
using Autofac;
using Saitama.Core.Framework;
using Saitama.Core.Platform;

namespace Saitama.Autofac.Apple
{
    public class AutofacAndroidInjectionContainerResolver : ApplePlatformInjectionContainerResolver
    {
        private readonly ContainerBuilder _containerBuilder;

        public AutofacAndroidInjectionContainerResolver(ContainerBuilder containerBuilder, Assembly entryAssembly) : base(entryAssembly)
        {
            _containerBuilder = containerBuilder;
        }

        protected override void RegisterInjectableTypes(Assembly entryAssembly)
        {
            // scan the entry assembly for types matching the defined iOS pattern
            var injectableBaseTypes = ScanForInjectableTypes();
            foreach (var theType in injectableBaseTypes)
            {
                _containerBuilder.RegisterType(theType).PropertiesAutowired();
            }
        }

        public override IInjectionContainer GetInjectionContainer()
        {
            return new AutofacInjectionContainer(_containerBuilder);
        }
    }
}
