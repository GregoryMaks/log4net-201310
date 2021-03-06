// This file has been autogenerated from a class added in the UI designer.

using System;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace XSample.log4net.XamariniOS.IKI
{
	public partial class ViewController1 : UIViewController
	{
		public ViewController1 (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			UITapGestureRecognizer gestureRecognizer = new UITapGestureRecognizer (HideKeyboard);
			this.View.AddGestureRecognizer (gestureRecognizer);

			LogSamples.InitFileLogs();

			//TODO: Mokee UI elements
			buttonLogMessage.TouchUpInside += new EventHandler(buttonLogMessage_TouchUpInside);
			//editTextLogMessage

			return;
		}

		void buttonLogMessage_TouchUpInside(object sender, EventArgs e)
		{
			LogSamples.Message = editTextLogMessage.Text;

			LogSamples.LogTestAll();
			LogSamples.LogToFiles();

			return;
		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue (segue, sender);

			if (segue.Identifier == "showLogMessage") {

				//TODO: Mokee tu mozes podesavati stvari na LogViewer controlleru
				//(ViewControllerLogViewer)segue.DestinationViewController

			}

		}

		public void HideKeyboard (NSObject sender)
		{
			this.View.EndEditing (true);
		}
	}
}
