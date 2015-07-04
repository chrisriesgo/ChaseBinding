using Xamarin.Forms;

namespace ChaseBinding
{

	public static class Extensions
	{
		public static NavigationPage AsNavigationPage(this ContentPage page)
		{
			return new NavigationPage(page);
		}
	}
}
