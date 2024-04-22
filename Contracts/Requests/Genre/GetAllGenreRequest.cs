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
        public IEnumerable<Genre> Items { get; set; } = Enumerable.Empty<Genre>();
    }
}
