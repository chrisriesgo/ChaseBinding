using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace ChaseBinding
{
	public class MyMenuPage : ContentPage
	{
		public MyMenuPage()
		{
			Title = "Menu";

			var simpleList = new ListView();
			simpleList.ItemsSource = new List<string> { "Home", "About", "Help" };

			Content = new StackLayout {
				Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0),
				Orientation = StackOrientation.Vertical,
				Children = {
					new Label { Text = "Select from the menu below:", HeightRequest = 40, YAlign = TextAlignment.Center },
					new BoxView { HeightRequest = 1, Color = Color.Gray },
					simpleList
				}
			};
		}
	}
}

