using System;
using System.Windows.Controls;
using Akira_AnimeList.UI.MVVM.Models;
using Akira_AnimeList.UI.MVVM.Views.UC;
using Akira_AnimeList.UI.Utilities;

namespace Akira_AnimeList.UI.MVVM.ViewModels;

public class MainWindowVM : ObservableObject
{
    private Frame _screenFrame;
    private User _user;

    public MainWindowVM()
    {
        _user = new User
        {
            Name = "Stanislav",
            Surname = "Forester"
        }; 
        _screenFrame = new Frame();
        var control = new ProfileUserControl(_user);
        _screenFrame.Navigate(control);
    }

    public Frame ScreenFrame
    {
        get => _screenFrame;
        set => Set(ref _screenFrame, value, nameof(ScreenFrame));
    }

    public User User
    {
        get => _user;
        set => Set(ref _user, value, nameof(User));
    }
}