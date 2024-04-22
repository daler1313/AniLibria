using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests
{
    public class CreateAuthorRequest
    {
        public string FullName { get; set; }
        public int YearOfDirth { get; set; }
    }
}
