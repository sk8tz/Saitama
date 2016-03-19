using Android.Preferences;
using Saitama.Android.Framework;

namespace Saitama.Android.Activities
{
    public abstract class SaitamaPreferenceActivity : PreferenceActivity
    {
        protected SaitamaPreferenceActivity()
        {
            SaitamaContext.GetContainer().InjectForInstance(this);
        }
    }
}