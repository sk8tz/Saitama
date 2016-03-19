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

        public override nint RowsInSection(UIKit.UITableView tableView, nint section)
        {
            return PersonService.GetPeople().Count;
        }

        public override UIKit.UITableViewCell GetCell(UIKit.UITableView tableView, NSIndexPath indexPath)
        {
            var cell = new UITableViewCell(UITableViewCellStyle.Default, "DefaultCell");
            var dataItem = PersonService.GetPeople().ElementAt(indexPath.Row);

            cell.TextLabel.Text = dataItem.FullName;
            return cell;
        }
    }
}

