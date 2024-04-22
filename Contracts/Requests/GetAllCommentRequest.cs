using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests
{
    public class GetAllCommentRequest
    {
        public IEnumerable<Comment> Items { get; set; } = Enumerable.Empty<Comment>();
    }
}
