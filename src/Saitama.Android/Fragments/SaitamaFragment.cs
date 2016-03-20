using Android.App;
using Saitama.Android.Framework;

namespace Saitama.Android.Fragments
{
    public abstract class SaitamaFragment : Fragment
    {
        protected SaitamaFragment()
        {
            SaitamaContext.GetContainer().InjectForInstance(this);
        }
    }
}