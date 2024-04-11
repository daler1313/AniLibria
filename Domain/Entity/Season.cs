namespace Domain.Entity
{
    public class Season : BaseEntity
    {
        public int Quantities {  get; set; }
        public int SeriesQuantities { get; set; }
        public Anime Animes { get; set; }
        public int AnimeId { get; set; }
    }
}
