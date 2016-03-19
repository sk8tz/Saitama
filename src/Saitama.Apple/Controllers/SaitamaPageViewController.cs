using System;
using Foundation;
using Saitama.Apple.Framework;
using UIKit;

namespace Saitama.Apple.Controllers
{
    public abstract class SaitamaPageViewController : UIPageViewController
    {
        protected SaitamaPageViewController(IntPtr ptr) : base(ptr)
        {
            // Fulfill all known dependencies with "this" instance
            SaitamaContext.GetContainer().InjectForInstance(this);
        }

        protected SaitamaPageViewController(string nibName, NSBundle bundle)
        {
            // Fulfill all known dependencies with "this" instance
            SaitamaContext.GetContainer().InjectForInstance(this);
        }

        protected SaitamaPageViewController()
        {
            // Fulfill all known dependencies with "this" instance
            SaitamaContext.GetContainer().InjectForInstance(this);
        }
    }
}
