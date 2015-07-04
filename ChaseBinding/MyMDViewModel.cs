using Xamarin.Forms;

namespace ChaseBinding
{
	public interface IMyMDViewModel 
	{
		ContentPage MenuPage { get; set; }
		ContentPage DetailPage { get; set; }
		MasterBehavior MasterBehavior { get; }
	}

	public class MyMDViewModel : ObservableBase, IMyMDViewModel
	{
		public MyMDViewModel()
		{
			MenuPage = new MyMenuPage();
			DetailPage = new MyDetailPage();
		}

		private ContentPage _menuPage;
		public ContentPage MenuPage 
		{
			get { return _menuPage; }
			set { SetField(ref _menuPage, value); }
		}

		private ContentPage _detailPage;
		public ContentPage DetailPage 
		{
			get { return _detailPage; }
			set { SetField(ref _detailPage, value); }
		}

		public MasterBehavior MasterBehavior
		{
			get
			{
				if(Device.Idiom == TargetIdiom.Tablet)
				{
					return MasterBehavior.Split;
				}

				return MasterBehavior.Default;
			}
		}
	}

}

