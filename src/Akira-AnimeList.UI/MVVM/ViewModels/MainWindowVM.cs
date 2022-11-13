using System.Windows.Controls;
using Akira_AnimeList.UI.MVVM.Views.UC;
using Akira_AnimeList.UI.Utilities;

namespace Akira_AnimeList.UI.MVVM.ViewModels;

public class MainWindowVM : ObservableObject
{
    private Frame _screenFrame;

    public MainWindowVM()
    {
        _screenFrame = new Frame();
        var control = new ProfileUserControl();
        _screenFrame.Navigate(control);
    }
    
    public Frame ScreenFrame
    {
        get => _screenFrame;
        set => Set(ref _screenFrame, value, nameof(ScreenFrame));
    }
}