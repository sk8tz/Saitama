using System.Reflection;
using Ninject;
using Saitama.Core.Framework;
using Saitama.Core.Platform;

namespace Saitama.Container.Ninject.Android
{
    public class NinjectAndroidInjectionContainerResolver : AndroidPlatformInjectionContainerResolver
    {
        private readonly IKernel _theKernel;

        public NinjectAndroidInjectionContainerResolver(IKernel theKernel, Assembly entryAssembly) : base(entryAssembly)
        {
            _theKernel = theKernel;
        }

        protected override void RegisterInjectableTypes(Assembly entryAssembly)
        {
            // scan the executing assembly for types matching the defined iOS pattern
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
    }
}
