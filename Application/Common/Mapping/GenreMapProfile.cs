﻿using AutoMapper;
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
    internal class GenreMapProfile : Profile
    {
        public GenreMapProfile()
        {
            CreateMap<CreateGenreRequest, Genre>();
            CreateMap<Genre, SingleGenreResponse>();
            CreateMap<GetAllGenreRequest, GetAllGenreResponse>();
            CreateMap<UpdateGenreRequest, Genre>();
        }
    }
}