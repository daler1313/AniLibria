using Domain.Enum;

namespace Domain.Entity
{
    public class Reading
    {
        //рейтинг
        public int Id { get; set; }
        public int MangaId { get; set; }
        public int UserId { get; set; }
        public int CommentId { get; set; }
        public Rating Rating { get; set; }
    }
}
