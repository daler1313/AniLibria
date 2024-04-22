using AutoMapper;
using Contracts.Requests.Author;
using Contracts.Requests.User;
using Contracts.Responses.Author;
using Contracts.Responses.User;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Mapping
{
    public class UserMapProfile: Profile
    {
        public UserMapProfile() 
        {
            CreateMap<CreateUserRequest, User>();
            CreateMap<User, SingleUserResponse>();
            CreateMap<GetAllUserRequest, GetAllUserResponse>();
            CreateMap<UpdateUserRequest, User>();
        }
    }
}
