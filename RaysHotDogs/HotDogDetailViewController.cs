using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using RaysHotDogs.Core;

namespace RaysHotDogs
{
	partial class HotDogDetailViewController : UIViewController
	{
		public HotDog SelectedHotDog { get; set; }

		public HotDogDetailViewController (IntPtr handle) : base (handle)
		{
			HotDogDataService hotDogDataService = new HotDogDataService ();
			SelectedHotDog = hotDogDataService.GetHotDogById (1);
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			DatabindUI();

			btnAddToCart.TouchUpInside += (object sender, EventArgs e) => {
				UIAlertView message = new UIAlertView("Rays's Hot Dogs", "That hot dog is OK", null, "OK", null);

				message.Show();

				this.DismissModalViewController(true);
			};

			btnCancel.TouchUpInside += (object sender, EventArgs e) => {
				this.DismissModalViewController(true);
			};
		}

		private void DatabindUI(){
			UIImage img = UIImage.FromFile ("Images/" + SelectedHotDog.ImagePath + ".jpg");
			ivHotDog.Image = img;
			lblName.Text = SelectedHotDog.Name;
			lblShortDescription.Text = SelectedHotDog.ShortDescription;
			tvLongDescription.Text = SelectedHotDog.Description;
			lblPrice.Text = "$" + SelectedHotDog.Price.ToString ();
		}
	}
}
