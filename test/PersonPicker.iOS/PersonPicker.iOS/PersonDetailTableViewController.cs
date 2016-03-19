using System;
using Foundation;
using UIKit;
using PersonPicker.iOS.Models;

namespace PersonPicker.iOS
{
    [Register("PersonDetailTableViewController")]
    public partial class PersonDetailTableViewController : UITableViewController
    {
        public Person SelectedPerson { get; set; }

        public PersonDetailTableViewController(IntPtr ptr) : base(ptr)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = SelectedPerson.Handle;
            realNameLabel.Text = SelectedPerson.FullName;
            ageLabel.Text = SelectedPerson.Age.ToString();
            genderLabel.Text = SelectedPerson.Gender.ToString();
        }
    }
}

