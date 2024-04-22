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
    internal class CommentMapProfile : Profile
    {
      public CommentMapProfile()
        {
            CreateMap<CreateCommentRequest, Comment>();
            CreateMap<Comment, SingleCommentResponse>();
            CreateMap<GetAllCommentRequest, GetAllCommentResponse>();
            CreateMap<UpdateCommentRequest, Comment>();
        }  
    }
}
