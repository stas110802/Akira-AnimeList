using Newtonsoft.Json;

namespace Akira_AnimeList.RestApiClient.Models;


public sealed class Image
{
    [JsonProperty("image_url")]
    public string? ImageUrl { get; set; }
    
    [JsonProperty("small_image_url")]
    public string? SmallImageUrl { get; set; }
    
    [JsonProperty("large_image_url")]
    public string? LargeImageUrl { get; set; }
}