using System;
using Foundation;
using Saitama.Apple.Framework;
using UIKit;

namespace Saitama.Apple.Controllers
{
    public abstract class SaitamaTabBarController : UITabBarController
    {
        protected SaitamaTabBarController(IntPtr ptr) : base(ptr)
        {
            // Fulfill all known dependencies with "this" instance
            SaitamaContext.GetContainer().InjectForInstance(this);
        }

        protected SaitamaTabBarController(string nibName, NSBundle bundle)
        {
            // Fulfill all known dependencies with "this" instance
            SaitamaContext.GetContainer().InjectForInstance(this);
        }

        protected SaitamaTabBarController()
        {
            // Fulfill all known dependencies with "this" instance
            SaitamaContext.GetContainer().InjectForInstance(this);
        }
    }
}
