using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests.User
{
    public class GetAllUserRequest
    {
        public IEnumerable<Domain.Entity.User> Items { get; set; } = Enumerable.Empty<Domain.Entity.User>();
    }
}
