using Android.Support.V4.App;

namespace Saitama.Android.Activities.v4
{
    public abstract class SaitamaFragmentActivity : FragmentActivity
    {
        protected SaitamaFragmentActivity()
        {
            SaitamaApplication.InjectionContainer.InjectForInstance(this);
        }
    }
}