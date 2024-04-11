namespace Domain.Entity
{
    public class Manga : BaseEntity
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public int GenreId { get; set; }
        public int AuthorId { get; set; }
        public int DateOfSsue { get; set; }
        public virtual ICollection<Reading> Readings { get; set; }
        public virtual ICollection<Volume> Volumes { get; set; }
    }
}
