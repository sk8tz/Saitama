using Android.App;
using Android.OS;
using Android.Widget;
using PersonPicker.Android.Services;
using Saitama.Android.Activities;

namespace PersonPicker.Android
{
    [Activity(Label = "One Punch Man", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : SaitamaListActivity
    {
        public IPersonService PersonService { get; set; }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            ListView.Adapter = new PersonListArrayAdapter(this, PersonService.GetPeople());
        }
    }
}

