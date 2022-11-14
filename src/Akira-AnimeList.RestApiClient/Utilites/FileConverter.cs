using System.Text.Json;
using Akira_AnimeList.RestApiClient.Models;

namespace Akira_AnimeList.RestApiClient.Utilites;

public static class FileConverter
{
    private static readonly JsonSerializerOptions _jsonSerializerOptions = new() { WriteIndented = true};

    public static async Task ConvertJsonToList<TSource>(this IRoutItems<TSource> list, object jsonItems)
        where TSource : class
    {
        try
        {
            foreach (var item in ((IRoutItems<TSource>?)jsonItems)?.Items)
            {
                list.Items.Add(item);
            }
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        }
    }

    public static async Task<Result<bool>> TryWriteToJson<T>(T instance, string fileName)
        where T : class
    {
        var result = new Result<bool>();
        FileStream? fs = null;

        try
        {               
                      
            await System.Text.Json.JsonSerializer.SerializeAsync<T>(fs, instance, _jsonSerializerOptions);                
            result.Data = true;                
        }
        catch (Exception error)
        {
            result.Data = false;
            result.Error = error.Message;
        }
        

        return result;
    }
}
