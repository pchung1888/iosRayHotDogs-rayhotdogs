using System;
using UIKit;
using Foundation;
using System.Drawing;

namespace RaysHotDogs
{
	public class HotDogListCell : UITableViewCell
	{
		UILabel nameLabel;
		UILabel priceLabel;
		UIImageView imageView;

		public HotDogListCell ()
		{
		}

		public HotDogListCell(NSString cellId) : base(UITableViewCellStyle.Default, cellId){
			SelectionStyle = UITableViewCellSelectionStyle.Gray;

			BackgroundColor = UIColor.FromRGB (254, 199, 69);

			imageView = new UIImageView ();

			nameLabel = new UILabel () {
				Font = UIFont.FromName("Cochin-BoldItalic", 18f),
				TextColor = UIColor.FromRGB(255,255,255),
				BackgroundColor = UIColor.Clear
			};

			priceLabel = new UILabel () {
				Font = UIFont.FromName("AmericanTypewriter", 12f),
				TextColor = UIColor.FromRGB(228,79,61),
				TextAlignment = UITextAlignment.Center,
				BackgroundColor = UIColor.Clear
			};

			ContentView.Add (nameLabel);
			ContentView.Add(priceLabel);
			ContentView.Add (imageView);
		}

		public override void LayoutSubviews ()
		{
			base.LayoutSubviews ();

			imageView.Frame = new RectangleF ((float)ContentView.Bounds.Width - 63, 5, 33, 33);
			nameLabel.Frame = new RectangleF (5, 4, (float)ContentView.Bounds.Width - 63, 25);
			priceLabel.Frame = new RectangleF (200, 10, 200, 20);
		}

		public void UpdateCell (string caption, string subTitle, UIImage image){
			imageView.Image = image;
			nameLabel.Text = caption;
			priceLabel.Text = subTitle;
		}
	}
}

