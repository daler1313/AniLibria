using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests.Anime
{
    public class CreateAnimeRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }


        public int AuthorId { get; set; }

        public int GenreId { get; set; }
        public int DateOfSsue { get; set; }

    }
}
