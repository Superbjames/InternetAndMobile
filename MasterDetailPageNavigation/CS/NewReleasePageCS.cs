using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
	public class NewReleasePageCS : ContentPage
	{
		public NewReleasePageCS ()
		{
			Title = "New Release";
			Content = new StackLayout { 
				Children = {
					new Label {
						Text = "New Release",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					}
				}
			};
		}
	}
}
