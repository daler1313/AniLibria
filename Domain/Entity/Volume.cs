namespace Domain.Entity
{
    public class Volume : BaseEntity
    {
        public int Quantities { get; set; }
        public int ChaptersQuantities { get; set; }
        public Manga Manga { get; set; }
        public int MandaId { get; set; }
    }
}
