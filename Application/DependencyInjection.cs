﻿using Application.Services;
using Domain.Entity;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IBaseService<Anime>, AnimeService>();
            services.AddScoped<IBaseService<Genre>, GenreService>();
            services.AddScoped<IBaseService<Comment>, CommentService>();
            services.AddScoped<IBaseService<Author>, AuthorService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
