using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapper
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Role, RoleDto>();
            CreateMap<RoleDto, Role>();

            CreateMap<UserDtoResponse, User>();
            CreateMap<User, UserDtoResponse>();

            CreateMap<UserDtoRequest, User>();
            CreateMap<User, UserDtoRequest>();


            //CreateMap<Book, BookDtoRequest>();
            //CreateMap<BookDtoRequest, Book>();

            CreateMap<Category, CategoryDtoRequest>();
            CreateMap<CategoryDtoRequest, Category>();
            CreateMap<Category, CategoryDtoResponse>();
            CreateMap<CategoryDtoResponse, Category>();

            CreateMap<Author, AuthorDtoRequest>();
            CreateMap<AuthorDtoRequest, Author>();
            CreateMap<Author, AuthorDtoResponse>();
            CreateMap<AuthorDtoResponse, Author>();

            //CreateMap<Author, AuthorDtoRequest>();
            //CreateMap<AuthorDtoRequest, Author>();



        }
    }
}
