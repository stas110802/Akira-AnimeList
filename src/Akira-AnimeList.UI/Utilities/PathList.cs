using System;
using System.IO;

namespace Akira_AnimeList.UI.Utilities;

public static class PathList
{
    public static string SourcePath => GetPath(@"..\..\..\..");
    public static string SolutionPath => GetPath(@"..\..\..\..\..");

    public static string AssetsPath => $"{SolutionPath}\\assets";
    public static string ImagesPath => $"{AssetsPath}\\images";
    
    private static string GetPath(string mask)
    {
        return Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, mask));
    }
}