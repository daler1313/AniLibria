using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Contracts.Requests.Comment
{
    public class UpdateCommentRequest
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string Title { get; set; }

    }
}
