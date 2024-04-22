using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Responses.Comment
{
    public class GetAllCommentResponse
    {
        public IEnumerable<SingleCommentResponse> Items { get; set; } = Enumerable.Empty<SingleCommentResponse>();
    }
}
