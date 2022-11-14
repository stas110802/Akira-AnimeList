using Akira_AnimeList.RestApi.Api;
using Akira_AnimeList.RestApiClient.Models;
using Akira_AnimeList.RestApiClient.Types;

namespace Akira_AnimeList.RestApiClient.Clients;

public sealed class JikanApiClient
{
    private BaseRestApi _server;
    
    public JikanApiClient()
    {
        _server = new BaseRestApi("https://api.jikan.moe/v4/");
    }
    
    public async void GetAnimeList()
    {
        try
        {
            var response = (await _server.GetResponseAsync(JikanEndpoint.Anime))?["data"];
            
            foreach (var item in response)
            {
                // ... mb in future
            }
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        }
    }

    public async Task<Result<List<AnimeInformation>>> GetAnimeByName(string name)
    {
        var result = new Result<List<AnimeInformation>>
        {
            Data = new List<AnimeInformation>()
        };
        
        var parameters = new Dictionary<string, string>()
        {
            {"q", name}
        };

        try
        {
            var response = (await _server.GetResponseAsync(JikanEndpoint.Anime, parameters))?["data"];

            foreach (var item in response)
            {
                var info = new AnimeInformation();
                var titleName = item?["title_english"];
                var image = item?["images"]?["jpg"]?["image_url"];
                //var url = item?["url"];                    
                //var episodesCount = item?["episodes"];
                result.Data.Add(info);
            }
        }
        catch (Exception error)
        {
            result.Error = error.Message;
        }

        return result;
    }
}