using CommunityToolkit.Maui.Markup;
using LayoutApp.Models;
using LayoutApp.ViewModels;

namespace LayoutApp.Views
{
    public partial class MainPageCS : ContentPage
    {
        public MainPageCS()
        {
            BindingContext = new MainViewModel();
            Content = new Grid()
            {
                Children =
                {
                    new StackLayout()
                    {
                        Spacing = 25,
                    }.ItemsSource(nameof(MainViewModel.Items))
                     .ItemTemplate(new DataTemplate(() =>
                     {
                         return new Frame()
                         {
                             CornerRadius = 5,
                             Content = new StackLayout()
                             {
                                 Children =
                                 {
                                     new Label().Center().Bind(nameof(Item.Id)),
                                     new Label().Center().Bind(nameof(Item.Text)),
                                 },
                             },
                         };
                     })),
                }
            }.Padding(20);
        }
    }
}
