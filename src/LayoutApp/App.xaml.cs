using LayoutApp.Views;

namespace LayoutApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // XAML version
            //MainPage = new MainPage();

            // Error page
            MainPage = new MainPageCS();
        }
    }
}
