using System;
using Xamarin.Forms;

namespace ChaseBinding
{
	public class MyDetailPage : ContentPage
	{
		public MyDetailPage()
		{
			Content = new Label { Text = "This is a very interesting detail page.", XAlign = TextAlignment.Center, YAlign = TextAlignment.Center };
		}
	}
}

