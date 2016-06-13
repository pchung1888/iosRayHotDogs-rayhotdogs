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
    [Register ("page1controller")]
    partial class page1controller
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        MapKit.MKMapView mapView1 { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (mapView1 != null) {
                mapView1.Dispose ();
                mapView1 = null;
            }
        }
    }
}