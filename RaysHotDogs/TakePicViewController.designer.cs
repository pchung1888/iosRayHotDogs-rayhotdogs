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
    [Register ("TakePicViewController")]
    partial class TakePicViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnTakeAPicture { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ivPictureImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView TakePicViewController { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnTakeAPicture != null) {
                btnTakeAPicture.Dispose ();
                btnTakeAPicture = null;
            }

            if (ivPictureImage != null) {
                ivPictureImage.Dispose ();
                ivPictureImage = null;
            }

            if (TakePicViewController != null) {
                TakePicViewController.Dispose ();
                TakePicViewController = null;
            }
        }
    }
}