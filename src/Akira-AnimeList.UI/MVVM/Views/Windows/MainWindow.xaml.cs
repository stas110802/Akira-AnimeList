using System.Windows;
using Akira_AnimeList.RestApiClient.Clients;
using Akira_AnimeList.UI.MVVM.ViewModels;

namespace Akira_AnimeList.UI.MVVM.Views.Windows;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowVM();
        var a = new JikanApiClient();
        var b = a.GetAnimeByName("Naruto");
    }
}