using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using PersonPicker.Android.Services;
using Saitama.Android.Framework;

namespace PersonPicker.Android
{
    public class RandomNumberFragment : Fragment
    {
        public INumberService NumberService { get; set; }

        public RandomNumberFragment()
        {
            NumberService = SaitamaContext.GetContainer().Get<INumberService>();
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var fragment = inflater.Inflate(Resource.Layout.RandomNumber, null);
            fragment.FindViewById<TextView>(Resource.Id.randomNumberView).Text = NumberService.GetNumber().ToString();

            return fragment;
        }
    }
}