using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Responses
{
    public class SingleAuthorResponse
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int YearOfDirth { get; set; }
    }
}
