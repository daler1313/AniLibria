using Domain.Enum;

namespace Domain.Entity
{
    public class Vewing: BaseEntity
    {
        public Anime Animes { get; set; }
        public int AnimeId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Comment Comment { get; set; }
        public int CommentsId { get; set; }
        public Rating Rating { get; set; }
    }
}
