using System;
using AVKit;
using Foundation;
using Saitama.Apple.Framework;

namespace Saitama.Apple.Controllers
{
    public abstract class SaitamaAVKitPlayerViewController : AVPlayerViewController
    {
        protected SaitamaAVKitPlayerViewController(IntPtr ptr) : base(ptr)
        {
            // Fulfill all known dependencies with "this" instance
            SaitamaContext.GetContainer().InjectForInstance(this);
        }

        protected SaitamaAVKitPlayerViewController(string nibName, NSBundle bundle)
        {
            // Fulfill all known dependencies with "this" instance
            SaitamaContext.GetContainer().InjectForInstance(this);
        }

        protected SaitamaAVKitPlayerViewController()
        {
            // Fulfill all known dependencies with "this" instance
            SaitamaContext.GetContainer().InjectForInstance(this);
        }
    }
}