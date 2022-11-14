using Akira_AnimeList.RestApi.Api;
using Akira_AnimeList.RestApiClient.Models;
using Akira_AnimeList.RestApiClient.Models.Roots;
using Akira_AnimeList.RestApiClient.Types;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
            var response = (await _server.GetResponseAsync<JToken>(JikanEndpoint.Anime))?["data"];
            
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
        var result = new Result<List<AnimeInformation>>();
        
        var parameters = new Dictionary<string, string>()
        {
            {"q", name}
        };

        try
        {
            var response = await _server.GetResponseAsync<AnimeInformationData>(JikanEndpoint.Anime, parameters);
            if (response == null) throw new Exception("Nullable response");
            result.Data = response.AnimeInformation;
        }
        catch (Exception error)
        {
            result.Error = error.Message;
        }

        return result;
    }
}