using Domain.Enum;

namespace Domain.Entity
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }
        public GenreType Type { get; set; }

    }
}
