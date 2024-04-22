using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests.Anime
{
    public class GetAllAnimeRequest
    {
        public IEnumerable<Anime> Items { get; set; } = Enumerable.Empty<Anime>();
    }
}
