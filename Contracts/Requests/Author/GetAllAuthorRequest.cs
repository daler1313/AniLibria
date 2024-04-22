using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests.Author
{
    public class GetAllAuthorRequest
    {
        public IEnumerable<Domain.Entity.Author> Items { get; set; } = Enumerable.Empty<Domain.Entity.Author>();
    }
}
