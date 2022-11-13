using System;
using Akira_AnimeList.UI.MVVM.Models;
using Akira_AnimeList.UI.Utilities;

namespace Akira_AnimeList.UI.MVVM.ViewModels;

public class ProfileUserControlVM : ObservableObject
{
    private ImageParams _backgroundImageParams;
    private ImageParams _profileImageParams;

    public ProfileUserControlVM()
    {
        _backgroundImageParams = new ImageParams
        {
            FilePath = "C:\\Icons\\HRTgriwt8AkYNIOshe-tOZq_EA-iowppszwKQ2fPhnTWjC596WSnvisg2ir4fUcaCigZm4X16dbxj4M9q0LorKwY.jpg",
            Width = 900,
            Height = 500
        };
        _profileImageParams = new ImageParams { FilePath = "C:\\Icons\\ava.jpg" };
    }

    public ImageParams BackgroundImageParams
    {
        get => _backgroundImageParams;
        set => Set(ref _backgroundImageParams, value, nameof(BackgroundImageParams));
    }

    public ImageParams ProfileImageParams
    {
        get => _profileImageParams;
        set => Set(ref _profileImageParams, value, nameof(ProfileImageParams));
    }
}