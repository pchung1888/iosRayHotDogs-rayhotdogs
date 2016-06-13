using Foundation;
using System;
using UIKit;
using RaysHotDogs.Core;
using System.CodeDom.Compiler;

namespace RaysHotDogs
{
	public partial class HotDogDetail2ViewController : UIViewController
	{
		public HotDog selected { get; set; }

		public HotDogDetail2ViewController(IntPtr handle) : base(handle)
		{
			HotDogDataService hddService = new HotDogDataService();
			selected = hddService.GetHotDogById(1);

		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			DatabindUI();

			AddToCartButton.TouchUpInside += (object sender, EventArgs e) =>
			{
				UIAlertView message = new UIAlertView("Rays's Hot Dogs", "That hot dog is OK", null, "OK", null);

				message.Show();

				this.DismissModalViewController(true);
			};

			CancelButton.TouchUpInside += (object sender, EventArgs e) =>
			{
				this.DismissModalViewController(true);
			};
		}

		private void DatabindUI()
		{
			UIImage img = UIImage.FromFile("Images/" + selected.ImagePath + ".jpg");
			imgView.Image = img;
			NameLabel.Text = selected.Name;
			ShortDescriptionLabel.Text = selected.ShortDescription;
			LongDescriptionText.Text = selected.Description;
			PriceLabel.Text = "$" + selected.Price.ToString();
		}
	}
}