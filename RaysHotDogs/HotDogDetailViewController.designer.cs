// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace RaysHotDogs
{
	[Register ("HotDogDetailViewController")]
	partial class HotDogDetailViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnAddToCart { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnCancel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView ivHotDog { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblName { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblPrice { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblShortDescription { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView tvLongDescription { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtQuantity { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btnAddToCart != null) {
				btnAddToCart.Dispose ();
				btnAddToCart = null;
			}
			if (btnCancel != null) {
				btnCancel.Dispose ();
				btnCancel = null;
			}
			if (ivHotDog != null) {
				ivHotDog.Dispose ();
				ivHotDog = null;
			}
			if (lblName != null) {
				lblName.Dispose ();
				lblName = null;
			}
			if (lblPrice != null) {
				lblPrice.Dispose ();
				lblPrice = null;
			}
			if (lblShortDescription != null) {
				lblShortDescription.Dispose ();
				lblShortDescription = null;
			}
			if (tvLongDescription != null) {
				tvLongDescription.Dispose ();
				tvLongDescription = null;
			}
			if (txtQuantity != null) {
				txtQuantity.Dispose ();
				txtQuantity = null;
			}
		}
	}
}
