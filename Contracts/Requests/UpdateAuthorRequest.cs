using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Contracts.Requests
{
    public class UpdateAuthorRequest
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string FullName { get; set; }
        public int YearOfDirth { get; set; }
    }
}
