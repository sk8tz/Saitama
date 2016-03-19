using Android.Support.V7.App;

namespace Saitama.Android.Activities.v7
{
    public abstract class SaitamaAppCompatActivity : AppCompatActivity
    {
        protected SaitamaAppCompatActivity()
        {
            SaitamaApplication.InjectionContainer.InjectForInstance(this);
        }
    }
}