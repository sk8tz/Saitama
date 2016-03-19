using System;
using Foundation;
using Saitama.Apple.Framework;
using UIKit;

namespace Saitama.Apple.Controllers
{
    public class SaitamaCollectionViewController : UICollectionViewController
    {
        protected SaitamaCollectionViewController(IntPtr ptr) : base(ptr)
        {
            // Fulfill all known dependencies with "this" instance
            SaitamaContext.GetContainer().InjectForInstance(this);
        }

        protected SaitamaCollectionViewController(string nibName, NSBundle bundle)
        {
            // Fulfill all known dependencies with "this" instance
            SaitamaContext.GetContainer().InjectForInstance(this);
        }

        protected SaitamaCollectionViewController()
        {
            // Fulfill all known dependencies with "this" instance
            SaitamaContext.GetContainer().InjectForInstance(this);
        }
    }
}
