// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace PersonPicker.iOS
{
	partial class PersonDetailTableViewController
	{
		[Outlet]
		UIKit.UILabel ageLabel { get; set; }

		[Outlet]
		UIKit.UILabel genderLabel { get; set; }

		[Outlet]
		UIKit.UILabel realNameLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (realNameLabel != null) {
				realNameLabel.Dispose ();
				realNameLabel = null;
			}

			if (ageLabel != null) {
				ageLabel.Dispose ();
				ageLabel = null;
			}

			if (genderLabel != null) {
				genderLabel.Dispose ();
				genderLabel = null;
			}
		}
	}
}
