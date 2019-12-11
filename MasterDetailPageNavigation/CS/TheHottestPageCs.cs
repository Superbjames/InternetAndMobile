using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
	public class TheHottestPageCs : ContentPage
	{
        //constructor for the hottest page
		public TheHottestPageCs()
		{
			Title = "The Hottest Page";
            //content for the hottest page
			Content = new StackLayout { 
				Children = {
					new Label {
						Text = "The Hottest Page",
						HorizontalOptions = LayoutOptions.Center,
						VerticalOptions = LayoutOptions.CenterAndExpand
					}
				}
			};
		}
	}
}
