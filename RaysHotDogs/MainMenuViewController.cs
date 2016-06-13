using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Xamarin.Media;
using System.Threading.Tasks;

namespace RaysHotDogs
{
	partial class MainMenuViewController : UIViewController
	{


		//MediaPicker mediaPicker = new MediaPicker();
		//TaskScheduler uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();

		//UIAlertView alertView;

		//MediaPickerController mediaPickerController;

		public MainMenuViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			//btnTakeAPicture.TouchUpInside += btnTakeAPicture_TouchUpInside;
		}

		//protected void btnTakeAPicture_TouchUpInside(object sender, EventArgs e){
		//	if (!mediaPicker.IsCameraAvailable) {
		//		alertView = new UIAlertView ("Ray's Hot Dogs", "Camara is not available",
		//			new UIAlertViewDelegate (), "OK");
		//		alertView.Show ();

		//		return;
		//	}

		//	mediaPickerController = mediaPicker.GetTakePhotoUI (
		//		new StoreCameraMediaOptions () {
		//			Name = "hotdogselfie.jpg",
		//			Directory = "RaysHotDogSelfies"
		//		});

		//	PresentViewController (mediaPickerController, true, null);

		//	mediaPickerController.GetResultAsync ().ContinueWith (t => {
		//		ivPictureImage.Image = UIImage.FromFile(t.Result.Path);
		//		DismissViewController(true, null);
		//	}, uiScheduler);
		//}
	}
}
