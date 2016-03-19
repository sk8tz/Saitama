using System;
using Foundation;
using Saitama.Apple.Framework;
using UIKit;

namespace Saitama.Apple.Controllers
{
    public abstract class SaitamaNavigationController : UINavigationController
    {
        protected SaitamaNavigationController(IntPtr ptr) : base(ptr)
        {
            // Fulfill all known dependencies with "this" instance
            SaitamaContext.GetContainer().InjectForInstance(this);
        }

        protected SaitamaNavigationController(string nibName, NSBundle bundle)
        {
            // Fulfill all known dependencies with "this" instance
            SaitamaContext.GetContainer().InjectForInstance(this);
        }

        protected SaitamaNavigationController()
        {
            // Fulfill all known dependencies with "this" instance
            SaitamaContext.GetContainer().InjectForInstance(this);
        }
    }
}
