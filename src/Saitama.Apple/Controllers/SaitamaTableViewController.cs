using System;
using Foundation;
using Saitama.Apple.Framework;
using UIKit;

namespace Saitama.Apple.Controllers
{
    public abstract class SaitamaTableViewController : UITableViewController
    {
        protected SaitamaTableViewController(IntPtr ptr) : base(ptr)
        {
            // Fulfill all known dependencies with "this" instance
            SaitamaContext.GetContainer().InjectForInstance(this);
        }

        protected SaitamaTableViewController(string nibName, NSBundle bundle)
        {
            // Fulfill all known dependencies with "this" instance
            SaitamaContext.GetContainer().InjectForInstance(this);
        }

        protected SaitamaTableViewController()
        {
            // Fulfill all known dependencies with "this" instance
            SaitamaContext.GetContainer().InjectForInstance(this);
        }
    }
}
