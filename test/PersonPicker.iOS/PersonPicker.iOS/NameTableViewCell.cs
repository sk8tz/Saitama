using System;
using UIKit;
using Foundation;

namespace PersonPicker.iOS
{
    [Register("NameTableViewCell")]
    public partial class NameTableViewCell : UITableViewCell
    {
        public string NameDisplay
        {
            get { return nameLabel.Text; }
            set { nameLabel.Text = value; }
        }

        public NameTableViewCell(IntPtr ptr) : base(ptr)
        {
        }
    }
}

