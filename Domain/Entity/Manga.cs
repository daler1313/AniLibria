﻿namespace Domain.Entity
{
    public class Manga
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int VolumeId { get; set; }
        public int GenreId { get; set; }
        public int AuthorId { get; set; }
        public int DateOfSsue { get; set; }
    }
}
