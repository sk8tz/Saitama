using System.Reflection;
using Ninject;
using Saitama.Core.Framework;
using Saitama.Core.Platform;

namespace Saitama.Container.Ninject.Apple
{
    public class NinjectAppleInjectionContainerResolver : ApplePlatformInjectionContainerResolver
    {
        private readonly IKernel _theKernel;

        public NinjectAppleInjectionContainerResolver(IKernel kernel, Assembly entryAssembly) : base(entryAssembly)
        {
            _theKernel = kernel;
        }

        #region implemented abstract members of InjectionContainerResolverBase

        protected override void RegisterInjectableTypes(Assembly entryAssembly)
        {
            // scan the entry assembly for types matching the defined iOS pattern
            var injectableBaseTypes = ScanForInjectableTypes();

            foreach (var theType in injectableBaseTypes)
            {
                _theKernel.Bind(theType).ToSelf();
            }
        }

        public override IInjectionContainer GetInjectionContainer()
        {
            return new NinjectInjectionContainer(_theKernel);
        }

        #endregion
    }
}
