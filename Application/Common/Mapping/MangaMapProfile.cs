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
    public class MangaMapProfile : Profile
    {
        public MangaMapProfile() 
        {
            CreateMap<CreateMangaRequest, Manga>();
            CreateMap<Manga, SingleMangaResponse>();
            CreateMap<GetAllMangaRequest, GetAllMangaResponse>();
            CreateMap<UpdateMangaRequest, Manga>();
        }
    }
}
