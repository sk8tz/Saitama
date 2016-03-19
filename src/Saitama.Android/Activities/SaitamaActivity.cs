using Android.App;
using Saitama.Android.Framework;

namespace Saitama.Android.Activities
{
    public abstract class SaitamaActivity : Activity
    {
        protected SaitamaActivity()
        {
            SaitamaContext.GetContainer().InjectForInstance(this);
        }
    }
}