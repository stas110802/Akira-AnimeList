using Newtonsoft.Json;

namespace Akira_AnimeList.RestApiClient.Models;

public sealed class AnimeInformation
{
    [JsonProperty("title")]
    public string? TitleName { get; set; }
    
    [JsonProperty("title_english")]
    public string? EnglishTitleName { get; set; }
    
    [JsonProperty("type")]
    public string? Type { get; set; }
    
    [JsonProperty("status")]
    public string? Status { get; set; }
    
    [JsonProperty("episodes")]
    public int? Episodes { get; set; }
    
    [JsonProperty("rating")]
    public string? Rating { get; set; }
    
    [JsonProperty("score")]
    public double? Score { get; set; }

    [JsonProperty("jpg")]
    public Image? JpgImage { get; set; }
    
}