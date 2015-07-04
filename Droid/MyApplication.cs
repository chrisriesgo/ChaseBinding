using System;
using Android.App;
using Android.Runtime;
using TinyIoC;

namespace ChaseBinding.Droid
{
	[Application]
	public class MyApplication : Android.App.Application
	{
		public MyApplication(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) {}

		public override void OnCreate()
		{
			base.OnCreate();

			var container = TinyIoCContainer.Current;
			container.Register<IMyMDViewModel, MyMDViewModel>();
		}
	}
}

