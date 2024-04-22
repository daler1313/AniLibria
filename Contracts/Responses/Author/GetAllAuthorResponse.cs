using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Responses.Author
{
    public class GetAllAuthorResponse
    {
        public IEnumerable<SingleAuthorResponse> Items { get; set; } = Enumerable.Empty<SingleAuthorResponse>();
    }
}
