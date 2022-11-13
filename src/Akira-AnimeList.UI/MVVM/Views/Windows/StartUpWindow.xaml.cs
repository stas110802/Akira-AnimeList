using System.Windows;
using Akira_AnimeList.UI.MVVM.ViewModels;
using Akira_AnimeList.UI.Utilities;

namespace Akira_AnimeList.UI.MVVM.Views.Windows;

public partial class StartUpWindow : Window
{
    public StartUpWindow()
    {
        InitializeComponent();
        DataContext = new StartUpWindowVM();
    }
}