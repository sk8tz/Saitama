using Foundation;
using Saitama.Apple.Controllers;
using Saitama.Apple.Framework;
using Saitama.Core.Framework;
using UIKit;

namespace Saitama.Apple
{
    public abstract class SaitamaApplicationDelegate : UIApplicationDelegate
    {
        /// <summary>
        /// Fires just before DidFinishLaunching which is the most common startup hook point. Here we will kick off
        /// dependency resolution and configurations
        /// </summary>
        /// <param name="application"></param>
        /// <param name="launchOptions"></param>
        /// <returns></returns>
        public override bool WillFinishLaunching(UIApplication application, NSDictionary launchOptions)
        {
            // get me the container resolver to use for the application
            var containerResolver = GetInjectionContainerResolver();
            containerResolver.RegisterInjectableTypes();
            
            // reference the current instance and hydrate all properties who type
            // match known dependencies
            SaitamaContext.SetInjectionContainer(containerResolver.GetInjectionContainer());
            SaitamaContext.GetContainer().InjectForInstance(this);

            // allow the WillFinishLaunching stage to complete
            return true;
        }

        /// <summary>
        /// Returns and instance class which implements IInjectionContainer. This enables any conforming IoC framework to be used
        /// with Saitama
        /// </summary>
        /// <returns></returns>
        protected abstract InjectionContainerResolverBase GetInjectionContainerResolver();
    }
}
