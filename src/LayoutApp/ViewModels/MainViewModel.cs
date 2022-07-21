using CommunityToolkit.Mvvm.ComponentModel;
using LayoutApp.Models;
using System.Collections.ObjectModel;

namespace LayoutApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            Items = new ObservableCollection<Item>();
            Items.Add(new Item() { Id = "AAPL", Text = "Apple" });
            Items.Add(new Item() { Id = "GOOGL", Text = "Google" });
            Items.Add(new Item() { Id = "META", Text = "Meta" });
            Items.Add(new Item() { Id = "MSFT", Text = "Microsoft" });
        }

        public ObservableCollection<Item> Items { get; private set; }
    }
}
