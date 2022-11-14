using Akira_AnimeList.AdditionalToolLibrary.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Akira_AnimeList.RestApi.Api;

public sealed class BaseRestApi
{
    private readonly string _uri;

    public BaseRestApi(string uri)
    {
        _uri = uri;
    }
    
    public async Task<T?> GetResponseAsync<T>(Enum endpoint, Dictionary<string, string>? parameters = null)
    {
        var endpointValue = endpoint.ToDescription();
        var body = GenerateParameters(parameters);
        var client = new RestClient(_uri + endpointValue + body);
        
        var request = new RestRequest();// base request is GET           
        var response = (await client.ExecuteAsync(request)).Content;
        var deserelizeResponse = JsonConvert.DeserializeObject<T>(response);

        return deserelizeResponse;
    }
    
    public async Task<string?> GetResponseStringAsync(Enum endpoint, Dictionary<string, string>? parameters = null)
    {
        var endpointValue = endpoint.ToDescription();
        var body = GenerateParameters(parameters);
        var client = new RestClient(_uri + endpointValue + body);
        
        var request = new RestRequest();// base request is GET           
        var response = (await client.ExecuteAsync(request)).Content;

        return response;
    }
    
    private static string? GenerateParameters(Dictionary<string, string>? postBody)
    {
        if (postBody == null 
            || postBody.Count == 0) return null;
        
        var postData = "?";
        foreach (var item in postBody)
        {
            postData += $"{item.Key}={item.Value}&";
        }
        postData.RemoveLastElement();

        return postData;
    }       
}