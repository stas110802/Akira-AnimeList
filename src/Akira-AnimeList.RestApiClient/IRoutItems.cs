namespace Akira_AnimeList.RestApiClient;

public interface IRoutItems<T>
{
    public List<T> Items { get; set; }
}