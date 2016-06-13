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
    [Register ("page2controller")]
    partial class page2controller
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnTake { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ivImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblPage2 { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnTake != null) {
                btnTake.Dispose ();
                btnTake = null;
            }

            if (ivImage != null) {
                ivImage.Dispose ();
                ivImage = null;
            }

            if (lblPage2 != null) {
                lblPage2.Dispose ();
                lblPage2 = null;
            }
        }
    }
}