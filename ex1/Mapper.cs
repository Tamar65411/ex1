﻿using AutoMapper;
using DTO;
using Entities;

namespace ex1
{
    public class Mapper :Profile
    {
        public Mapper()
        {
           CreateMap<OrdersTbl, OrderDTO>().ReverseMap();
           CreateMap<UsersTbl, UserDTO>().ReverseMap();
            CreateMap<Category, CategoriesDTO>().ReverseMap();

        }

    }
}