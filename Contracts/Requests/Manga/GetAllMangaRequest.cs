using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests.Manga
{
    public class GetAllMangaRequest
    {
        public IEnumerable<Domain.Entity.Manga> Items { get; set; } = Enumerable.Empty<Domain.Entity.Manga>();
    }
}
