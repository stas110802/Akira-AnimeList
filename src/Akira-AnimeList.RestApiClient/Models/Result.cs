namespace Akira_AnimeList.RestApiClient.Models;

public sealed class Result<T> 
{
    public T? Data { get; set; }
    public string? Error { get; set; }
}