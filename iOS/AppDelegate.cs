using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using TinyIoC;

namespace ChaseBinding.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			var container = TinyIoCContainer.Current;
			container.Register<IMyMDViewModel, MyMDViewModel>();

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}

