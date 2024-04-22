namespace Contracts.Requests.Animes
{
    public class GetAllAnimeRequestBase
    {
        public IEnumerable<Domain.Entity.Anime> Items { get; set; } = Enumerable.Empty<Domain.Entity.Anime>();
    }
}