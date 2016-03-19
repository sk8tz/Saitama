using System;
using Android.App;
using Android.Runtime;
using Saitama.Android.Framework;
using Saitama.Core.Framework;

namespace Saitama.Android
{
    public abstract class SaitamaApplication : Application
    {
        protected SaitamaApplication(IntPtr ptr, JniHandleOwnership transfer) : base(ptr, transfer)
        {
            
        }

        public override void OnCreate()
        {
            base.OnCreate();

            // get our container resolver which will allow us to
            // utilize whatever IoC framwork the user chooses
            var containerResolver = GetInjectionContainerResolver();
            containerResolver.RegisterInjectableTypes();

            SaitamaContext.SetInjectionContainer(containerResolver.GetInjectionContainer());
            SaitamaContext.GetContainer().InjectForInstance(this);
        }

        /// <summary>
        /// Returns the Injection Container Resolver reference that wraps that IoC
        /// implementation in use by the application
        /// </summary>
        /// <returns></returns>
        protected abstract InjectionContainerResolverBase GetInjectionContainerResolver();
    }
}