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
    [Register ("MainMenuViewController")]
    partial class MainMenuViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnGoToPage1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnPage2 { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnGoToPage1 != null) {
                btnGoToPage1.Dispose ();
                btnGoToPage1 = null;
            }

            if (btnPage2 != null) {
                btnPage2.Dispose ();
                btnPage2 = null;
            }
        }
    }
}