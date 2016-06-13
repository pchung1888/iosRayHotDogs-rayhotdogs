using Foundation;
using System;
using UIKit;
using System.CodeDom.Compiler;
using Xamarin.Media;
using System.Threading.Tasks;

namespace RaysHotDogs
{
    public partial class TakePicViewController : UIViewController
    {
		readonly MediaPicker mediaPicker = new MediaPicker();
		readonly TaskScheduler uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();
		UIAlertView alertView;
		private MediaPickerController mediaPickerController;
        public TakePicViewController (IntPtr handle) : base (handle)
        {
        }
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			btnTakeAPicture.TouchUpInside += btnTakeAPicture_TouchUpInside;
		}

		protected void btnTakeAPicture_TouchUpInside(object sender, EventArgs e){
			if (!mediaPicker.IsCameraAvailable) {
				alertView = new UIAlertView ("Ray's Hot Dogs", "Camara is not available",
					new UIAlertViewDelegate (), "OK");
				alertView.Show ();

				return;
			}

			mediaPickerController = mediaPicker.GetTakePhotoUI (
				new StoreCameraMediaOptions () {
					Name = "hotdogselfie.jpg",
					Directory = "RaysHotDogSelfies"
				});

			PresentViewController (mediaPickerController, true, null);

			mediaPickerController.GetResultAsync ().ContinueWith (t => {
				ivPictureImage.Image = UIImage.FromFile(t.Result.Path);
				DismissViewController(true, null);
			}, uiScheduler);
		}
	}
}