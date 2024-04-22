using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Requests.User
{
    public class CreateUserRequest
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
