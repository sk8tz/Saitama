using Android.App;
using Saitama.Android.Framework;

namespace Saitama.Android.Activities
{
    public abstract class SaitamaExpandableListActivity : ExpandableListActivity
    {
        protected SaitamaExpandableListActivity()
        {
            SaitamaContext.GetContainer().InjectForInstance(this);
        }
    }
}