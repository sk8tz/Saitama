using System;
using System.Linq;
using Foundation;
using Saitama.Apple.Controllers;
using PersonPicker.iOS.Services;
using UIKit;

namespace PersonPicker.iOS
{
    [Register("PeopleTableViewController")]
    public class PersonTableViewController : SaitamaTableViewController
    {
        public IPersonService PersonService { get; set; }

        public PersonTableViewController(IntPtr ptr) : base(ptr)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = "Characters";
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            var controller = (PersonDetailTableViewController)segue.DestinationViewController;
            controller.SelectedPerson = PersonService.GetPeople().ElementAt(TableView.IndexPathForSelectedRow.Row);

            base.PrepareForSegue(segue, sender);
        }

        public override nint RowsInSection(UIKit.UITableView tableView, nint section)
        {
            return PersonService.GetPeople().Count;
        }

        public override UIKit.UITableViewCell GetCell(UIKit.UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("NameCell") as NameTableViewCell;
            if (cell != null)
            {
                var dataItem = PersonService.GetPeople().ElementAt(indexPath.Row);
                cell.NameDisplay = dataItem.Handle;
            }

            return cell;
        }
    }
}

