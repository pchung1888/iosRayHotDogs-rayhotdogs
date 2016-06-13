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
    public partial class MapViewController : UIViewController

    {
		//private MKMapView rayMap;
		private CLLocationManager lm = new CLLocationManager();
        public MapViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			rayMap = new MKMapView(View.Bounds);
			rayMap.AutoresizingMask = UIViewAutoresizing.FlexibleDimensions;
			rayMap.MapType = MKMapType.Standard;
			View.AddSubview(rayMap);
			double latitude  = 40.7540577;
			double longitude = -73.9837790;
			var rayPlace = new CLLocationCoordinate2D ( latitude, longitude);
			var zoomRegion = MKCoordinateRegion.FromDistance(rayPlace, 2000,2000);   
			rayMap.CenterCoordinate = rayPlace;
			rayMap.Region = zoomRegion;
			lm.RequestWhenInUseAuthorization();
			rayMap.ShowsUserLocation= true;
			var RayAnno = new MKPointAnnotation()
			{
				Title = "Ray Hot Dog",
				Coordinate = rayPlace
			};
			rayMap.AddAnnotation(RayAnno);
			 

		}
    }
}