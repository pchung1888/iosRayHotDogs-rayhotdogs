using Foundation;
using System;
using UIKit;
using System.CodeDom.Compiler;
using Xamarin.Media;
using System.Threading.Tasks;
using MapKit;
using CoreLocation;

namespace RaysHotDogs
{
    public partial class page1controller : UIViewController
    {
		private CLLocationManager lm = new CLLocationManager();

		public page1controller (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			mapView1 = new MKMapView(View.Bounds);
			mapView1.AutoresizingMask = UIViewAutoresizing.FlexibleDimensions;
			mapView1.MapType = MKMapType.Standard;
			View.AddSubview(mapView1);
			double latitude = 40.7540577;
			double longitude = -73.9837790;
			var rayPlace = new CLLocationCoordinate2D(latitude, longitude);
			var zoomRegion = MKCoordinateRegion.FromDistance(rayPlace, 2000, 2000);
			mapView1.CenterCoordinate = rayPlace;
			mapView1.Region = zoomRegion;
			lm.RequestWhenInUseAuthorization();
			mapView1.ShowsUserLocation = true;
			var RayAnno = new MKPointAnnotation()
			{
				Title = "Ray Hot Dog",
				Coordinate = rayPlace
			};
			mapView1.AddAnnotation(RayAnno);


		}
    }
}