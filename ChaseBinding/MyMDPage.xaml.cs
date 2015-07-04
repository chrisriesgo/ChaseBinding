using System;
using System.Collections.Generic;

using Xamarin.Forms;
using TinyIoC;

namespace ChaseBinding
{
	public partial class MyMDPage : MasterDetailPage
	{
		public MyMDPage() : this(TinyIoCContainer.Current.Resolve<IMyMDViewModel>()) { }
		public MyMDPage(IMyMDViewModel viewModel)
		{
			InitializeComponent();

			BindingContext = viewModel;

			this.SetBinding<IMyMDViewModel>(MasterDetailPage.MasterBehaviorProperty, vm => vm.MasterBehavior);

			Master = viewModel.MenuPage;
			Detail = viewModel.DetailPage.AsNavigationPage();
		}
	}
}

