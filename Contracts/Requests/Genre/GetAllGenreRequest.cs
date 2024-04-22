using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests.Genre
{
    public class GetAllGenreRequest
    {
        public IEnumerable<Domain.Entity.Genre> Items { get; set; } = Enumerable.Empty<Domain.Entity.Genre>();
    }
}
