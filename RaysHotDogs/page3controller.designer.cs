// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using Social;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace RaysHotDogs
{
    [Register ("page3controller")]
    partial class page3controller
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton PostToFacebook { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (PostToFacebook != null) {
                PostToFacebook.Dispose ();
                PostToFacebook = null;
            }
        }
    }
}