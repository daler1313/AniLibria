using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests.Comment
{
    public class GetAllCommentRequest
    {
        public IEnumerable<Domain.Entity.Comment> Items { get; set; } = Enumerable.Empty<Domain.Entity.Comment>();
    }
}
