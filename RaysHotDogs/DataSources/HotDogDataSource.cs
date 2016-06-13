using System;
using UIKit;
using System.Collections.Generic;
using RaysHotDogs.Core;
using Foundation;

namespace RaysHotDogs
{
	public class HotDogDataSource: UITableViewSource
	{
		private List<HotDog> hotDogs;
		NSString cellIdentifier = new NSString("HotDogCell");

		UITableViewController callingController;

		public HotDogDataSource (List<HotDog> hotDogs, UITableViewController callingController)
		{
			this.hotDogs = hotDogs;
			this.callingController = callingController;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return hotDogs.Count;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			HotDogListCell cell = tableView.DequeueReusableCell (cellIdentifier) as HotDogListCell;

			if (cell == null) {
				cell = new HotDogListCell (cellIdentifier);
			}

			var hotDog = hotDogs [indexPath.Row];

			cell.UpdateCell (
				hotDog.Name, 
				hotDog.Price.ToString (), 
				UIImage.FromFile ("Images/hotdog" + hotDog.Id.ToString () + ".jpg"));
			
			return cell;
		}

		public HotDog GetItem(int rowId){
			return hotDogs [rowId];
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			//callingController.PerformSegue ("HotDogDetailSegue", callingController);
			var selectedHotDog = this.hotDogs[indexPath.Row];

			var favoritesController = callingController as FavoritesViewController;

			if(favoritesController != null){
				favoritesController.HotDogSelected (selectedHotDog);
				tableView.DeselectRow(indexPath,true);
				return;
			}

			var meatLoversController = callingController as MeatLoversViewController;

			if(meatLoversController != null){
				meatLoversController.HotDogSelected (selectedHotDog);
				tableView.DeselectRow(indexPath,true);
				return;
			}

			var veggieLoversController = callingController as VeggieLoversViewController;

			if(veggieLoversController != null){
				veggieLoversController.HotDogSelected (selectedHotDog);
				tableView.DeselectRow(indexPath,true);
				return;
			}
		}
	}
}