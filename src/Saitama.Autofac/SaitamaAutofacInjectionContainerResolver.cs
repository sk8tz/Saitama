using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Saitama.Core.Framework;

namespace Saitama.Container.Autofac
{
    public class SaitamaAutofacInjectionContainerResolver : IInjectionContainerResolver
    {
        private readonly ContainerBuilder _containerBuilder;

        public SaitamaAutofacInjectionContainerResolver(ContainerBuilder containerBuilder)
        {
            // register all controller types from the entry assembly
            RegisterControllersFromEntryAssembly(containerBuilder);
        }

        private void RegisterControllersFromEntryAssembly(ContainerBuilder cb)
        {

        }
    }
}
