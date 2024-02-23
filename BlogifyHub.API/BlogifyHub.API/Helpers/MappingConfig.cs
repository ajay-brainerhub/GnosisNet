﻿using AutoMapper;
using BlogifyHub.Entities.Entities;
using BlogifyHub.Service.Models;

namespace BlogifyHub.API.Helpers
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Blog, BlogDto>().ReverseMap();
            });

            return mappingConfig;
        }
    }
}
