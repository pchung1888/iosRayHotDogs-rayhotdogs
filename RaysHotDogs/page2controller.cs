using Foundation;
using System;
using UIKit;
using System.CodeDom.Compiler;
using Xamarin.Media;
using System.Threading.Tasks;

namespace RaysHotDogs
{
    public partial class page2controller : UIViewController
    {
		readonly MediaPicker mediaPicker = new MediaPicker();
		readonly TaskScheduler uiScheduler = TaskScheduler.FromCurrentSynchronizationContext();
		UIAlertView alertView;
		private MediaPickerController mediaPickerController;

        public page2controller (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			btnTake.TouchUpInside += btnTake_TouchUpInside;
		}

		protected void btnTake_TouchUpInside(object sender, EventArgs e)
		{
			if (!mediaPicker.IsCameraAvailable)
			{
				alertView = new UIAlertView("Ray's Hot Dogs", "Camara is not available",
					new UIAlertViewDelegate(), "OK");
				alertView.Show();

				return;
			}

			mediaPickerController = mediaPicker.GetTakePhotoUI(
				new StoreCameraMediaOptions()
				{
					Name = "hotdogselfie.jpg",
					Directory = "RaysHotDogSelfies"
				});

			PresentViewController(mediaPickerController, true, null);

			mediaPickerController.GetResultAsync().ContinueWith(t =>
			{
				ivImage.Image = UIImage.FromFile(t.Result.Path);
				DismissViewController(true, null);
			}, uiScheduler);
		}
    }
}