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
    internal class AnimeMapProfile: Profile
    {
        public AnimeMapProfile() 
        {
            CreateMap<CreateAnimeRequest, Anime>();
            CreateMap<Anime, SingleAnimeResponse>();
            CreateMap<GetAllAnimeRequest, GetAllAnimeResponse>();
            CreateMap<UpdateAnimeRequest, Anime>();
        }
    }
}
