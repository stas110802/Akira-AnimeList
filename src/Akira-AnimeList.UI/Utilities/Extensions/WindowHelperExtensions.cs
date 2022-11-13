using System.Windows;
using System.Windows.Controls;

namespace Akira_AnimeList.UI.Utilities.Extensions;

public static class WindowHelperExtensions
{
    public static void CloseBaseWindow(this UserControl control)
    {
        Window.GetWindow(control)?.Close();
    }
}