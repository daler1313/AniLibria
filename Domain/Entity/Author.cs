namespace Domain.Entity
{
    public class Author: BaseEntity
    {
        public string FullName { get; set; }
        public int YearOfDirth { get; set; }
        public virtual ICollection<Anime> Animes { get; set; }
        public virtual ICollection<Manga> Mangas { get; set; }
    }
}
