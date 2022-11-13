using System;
using System.Collections.Generic;

namespace Akira_AnimeList.UI.MVVM.Models;

public sealed class User
{
    public string NickName { get; set; }
    public string Name { get; set; }
    public string Surname  { get; set; }
    public DateTime RegistrationDate { get; set; }
    public DateTime DateBirth { get; set; }
    public UserPathList PathList { get; set; }
    public List<Anime> WatchedAnime { get; set; }
}