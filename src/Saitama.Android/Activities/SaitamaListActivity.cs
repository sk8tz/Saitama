using Android.App;
using Saitama.Android.Framework;

namespace Saitama.Android.Activities
{
    public abstract class SaitamaListActivity : ListActivity
    {
        protected SaitamaListActivity()
        {
            SaitamaContext.GetContainer().InjectForInstance(this);
        }
    }
}