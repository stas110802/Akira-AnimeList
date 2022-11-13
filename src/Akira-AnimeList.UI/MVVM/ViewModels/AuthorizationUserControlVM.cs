using System;
using System.Windows;
using Akira_AnimeList.UI.Commands;
using Akira_AnimeList.UI.MVVM.Models;
using Akira_AnimeList.UI.MVVM.Views.Windows;
using Akira_AnimeList.UI.Utilities;

namespace Akira_AnimeList.UI.MVVM.ViewModels;

public sealed class AuthorizationUserControlVM : ObservableObject, IHashPasswordStorage
{
    private ImageParams _authImage;
    private string _login;
    
    public AuthorizationUserControlVM()
    {
        var authImgPath = $"{PathList.ImagesPath}\\auth-anime-girl.png";
        _authImage = new ImageParams
        {
            FilePath = authImgPath,
            Width = 280,
            Height = 280
        };
        AuthorizeCommand = new BaseCommand(AuthorizeUser);
    }

    public BaseCommand AuthorizeCommand { get; set; }

    public ImageParams AuthImage
    {
        get => _authImage;
        set => Set(ref _authImage, value, nameof(AuthImage));
    }

    public string Login
    {
        get => _login;
        set => Set(ref _login, value, nameof(Login));
    }

    public string? HashPassword { get; set; }
    public event EventHandler OnFrameStopped;
    
    private void AuthorizeUser(object sender)
    {
        new MainWindow().Show();
        OnFrameStopped.Invoke(null, EventArgs.Empty);
    }
}