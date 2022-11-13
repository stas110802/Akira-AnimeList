using System.Windows.Controls;
using Akira_AnimeList.UI.MVVM.Models;
using Akira_AnimeList.UI.MVVM.ViewModels;

namespace Akira_AnimeList.UI.MVVM.Views.UC;

public partial class ProfileUserControl : UserControl
{
    public ProfileUserControl(User user)
    {
        InitializeComponent();
        DataContext = new ProfileUserControlVM(user);
    }
}