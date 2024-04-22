using AutoMapper;
using Contracts.Requests;
using Contracts.Responses;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Mapping
{
    internal class AuthorMapProfile : Profile
    {
        public AuthorMapProfile()
        {
            CreateMap<CreateAuthorRequest, Author>();
            CreateMap<Author, SingleAuthorResponse>();
            CreateMap<GetAllAuthorRequest, GetAllAuthorResponse>();
            CreateMap<UpdateAuthorRequest, Author>();
        }
    }
}
