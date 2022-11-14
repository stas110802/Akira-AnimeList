namespace Akira_AnimeList.RestApi.Utilites.Extensions;

public static class StringExtensions
{
    /// <summary>
    /// Removes the last char element
    /// </summary>
    /// <param name="data">your string</param>
    public static void RemoveLastElement(this string data)
    {
        if(data.Length > 0)
        {
            //data = data.Substring(0, data.Length - 1);
            data = data.Remove(data.Length - 1, 1);
        }            
    }
    
}