namespace Domain.Entity
{
    public class Comment : BaseEntity
    {
        public string Title { get; set; }
        public virtual ICollection<Anime> Animes { get; set; }
        public virtual ICollection<Reading> Readings { get; set; }
        public virtual ICollection<Vewing> Vewings { get; set; }
    }
}
