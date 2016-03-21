using System.Collections.Generic;
using Android.Content;
using Android.Views;
using Android.Widget;
using PersonPicker.Android.Models;

namespace PersonPicker.Android
{
    public class PersonListArrayAdapter : ArrayAdapter<Person>
    {
        public PersonListArrayAdapter(Context context, IList<Person> objects)
            : base(context, 0, 0, objects)
        {
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            if (convertView == null)
                convertView = LayoutInflater.From(Context).Inflate(Resource.Layout.LineItem, null);

            var dataItem = GetItem(position);
            convertView.FindViewById<TextView>(Resource.Id.nameText).Text = dataItem.Name;

            return convertView;
        }
    }
}