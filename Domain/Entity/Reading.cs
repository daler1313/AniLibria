using Domain.Enum;

namespace Domain.Entity
{
    public class Reading : BaseEntity
    {
        public Manga Manga { get; set; }
        public int MangaId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Comment Comment { get; set; }
        public int CommentId { get; set; }
        public Rating Rating { get; set; }
    }
}
