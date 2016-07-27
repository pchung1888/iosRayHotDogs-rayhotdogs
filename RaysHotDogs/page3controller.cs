using Foundation;
using System;
using UIKit;
using Social;
namespace RaysHotDogs
{
    public partial class page3controller : UIViewController
    {
        public page3controller (IntPtr handle) : base (handle)
        {
        }


		#region Private Variables
		private SLComposeViewController _facebookComposer = SLComposeViewController.FromService(SLServiceType.Facebook);
		#endregion

		#region Computed Properties
		public bool isFacebookAvailable
		{
			get { return SLComposeViewController.IsAvailable(SLServiceKind.Facebook); }
		}

		public SLComposeViewController FacebookComposer
		{
			get { return _facebookComposer; }
		}
		#endregion

		#region Constructors

		#endregion

		#region Override Methods

		//public override void ViewDidLoad()
		//{
		//	base.ViewDidLoad();
		//	PostToFacebook.TouchUpInside += PostToFacebook_TouchUpInside;
		//}
		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);

			// Update UI based on state
			PostToFacebook.Enabled = isFacebookAvailable;
			PostToFacebook.TouchUpInside += PostToFacebook_TouchUpInside;
		}
		#endregion

		#region Actions
		void PostToFacebook_TouchUpInside(object sender, EventArgs e)
		{
			if (isFacebookAvailable)
			{
				// Set initial message
				FacebookComposer.SetInitialText("Hello Facebook!");
				//FacebookComposer.AddImage(UIImage.FromFile("Icon.png"));
				FacebookComposer.CompletionHandler += (result) =>
				{
					InvokeOnMainThread(() =>
					{
						DismissViewController(true, null);
						Console.WriteLine("Results: {0}", result);
					});
				};

				// Display controller
				PresentViewController(FacebookComposer, true, null);
			}


		}
		#endregion
	}
    
}