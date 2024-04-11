using Domain.Enum;

namespace Domain.Entity
{
    public class Vewing: BaseEntity
    {
        public int AmineId { get; set; }
        public int UserId { get; set; }
        public int CommentsId { get; set; }
        public Rating Rating { get; set; }
    }
}
