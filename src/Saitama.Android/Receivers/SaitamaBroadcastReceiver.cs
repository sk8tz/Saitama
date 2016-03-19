using Android.Content;
using Saitama.Android.Framework;

namespace Saitama.Android.Receivers
{
    public abstract class SaitamaBroadcastReceiver : BroadcastReceiver
    {
        protected SaitamaBroadcastReceiver()
        {
            SaitamaContext.GetContainer().InjectForInstance(this);
        }
    }
}