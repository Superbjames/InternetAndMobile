using System.Collections.Generic;
using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
    public class MasterPageCS : ContentPage
    {
        //listview setup the side bar
        public ListView ListView { get { return listView; } }

        ListView listView;

        public MasterPageCS()
        {
            //variable in the list for side menu bar
            var masterPageItems = new List<MasterPageItem>();
            //link to page 1
            masterPageItems.Add(new MasterPageItem
            {
                Title = "New Release",
                IconSource = "contacts.png",
                TargetType = typeof(NewReleasePageCS)
            });
            //link to page 2
            masterPageItems.Add(new MasterPageItem
            {
                Title = "The Hottest",
                IconSource = "todo.png",
                TargetType = typeof(TheHottestPageCs)
            });
            
            listView = new ListView
            {
                //design for side menu bar
                ItemsSource = masterPageItems,
                ItemTemplate = new DataTemplate(() =>
                {
                    //put grid in variable
                    var grid = new Grid { Padding = new Thickness(5, 10) };
                    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(30) });
                    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

                    //made var for image
                    var image = new Image();
                    image.SetBinding(Image.SourceProperty, "IconSource");
                    var label = new Label { VerticalOptions = LayoutOptions.FillAndExpand };
                    label.SetBinding(Label.TextProperty, "Title");

                    grid.Children.Add(image);
                    grid.Children.Add(label, 1, 0);
                    //return viewcell
                    return new ViewCell { View = grid };
                }),
                SeparatorVisibility = SeparatorVisibility.None
            };

            IconImageSource = "hamburger.png";
            Title = "Personal Organiser";
            Padding = new Thickness(0, 40, 0, 0);
            Content = new StackLayout
            {
                Children = { listView }
            };
        }
    }
}
