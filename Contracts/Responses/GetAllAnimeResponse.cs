using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Responses
{
    public class GetAllAnimeResponse
    {
        public IEnumerable<SingleAnimeResponse> Items { get; set; } = Enumerable.Empty<SingleAnimeResponse>();
    }
}
