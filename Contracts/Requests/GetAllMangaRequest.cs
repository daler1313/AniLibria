using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests
{
    public class GetAllMangaRequest
    {
        public IEnumerable<Manga> Items { get; set; } = Enumerable.Empty<Manga>();
    }
}
