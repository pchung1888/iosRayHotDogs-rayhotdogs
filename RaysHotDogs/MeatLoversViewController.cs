using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using RaysHotDogs.Core;
using System.Collections.Generic;

namespace RaysHotDogs
{
	partial class MeatLoversViewController : UITableViewController
	{
		HotDogDataService dataService = new HotDogDataService();

		public MeatLoversViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var favorites = new List<HotDog>() { dataService.GetHotDogById(1) };
			TableView.Source = new HotDogDataSource (favorites, this);
			this.ParentViewController.NavigationItem.Title = "Ray's Favorites";
		}

		public async void HotDogSelected(HotDog selectedHotDog){
			HotDogDetailViewController detailController = 
				this.Storyboard.InstantiateViewController ("HotDogDetailViewController") as HotDogDetailViewController;

			if (detailController != null) {
				detailController.ModalTransitionStyle = UIModalTransitionStyle.PartialCurl;

				detailController.SelectedHotDog = selectedHotDog;

				await PresentViewControllerAsync (detailController, true);
			}
		}
	}
}
