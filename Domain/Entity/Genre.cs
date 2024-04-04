using Domain.Enum;

namespace Domain.Entity
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GenreType Type { get; set; }

    }
}
