using Newtonsoft.Json;

namespace Akira_AnimeList.RestApiClient.Models.Roots;

public class AnimeInformationData
{
    [JsonProperty("data")]
    public List<AnimeInformation>? AnimeInformation { get; set; }
}