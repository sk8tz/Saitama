using Android.App;
using Saitama.Android.Framework;

namespace Saitama.Android.Services
{
    public abstract class SaitamaService : Service
    {
        protected SaitamaService()
        {
            SaitamaContext.GetContainer().InjectForInstance(this);
        }
    }
}