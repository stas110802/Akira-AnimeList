using System.Windows;
using System.Windows.Controls;
using Akira_AnimeList.UI.MVVM.ViewModels;
using Akira_AnimeList.UI.Utilities.Extensions;

namespace Akira_AnimeList.UI.MVVM.Views.UC;

public partial class AuthorizationUserControl : UserControl
{
    public AuthorizationUserControl()
    {
        InitializeComponent();
        var vm = new AuthorizationUserControlVM();
        vm.OnFrameStopped += (_, _) => { this.CloseBaseWindow(); };
        DataContext = vm;
    }
}