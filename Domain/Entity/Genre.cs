using Domain.Enum;

namespace Domain.Entity
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }
        public GenreType Type { get; set; }
        public virtual ICollection<Manga> Mangas { get; set; }
        public virtual ICollection<Anime> Animes { get; set; }

    }
}
