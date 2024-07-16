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
            CreateMap<UserRole, UserRoleDto>();
            CreateMap<UserRoleDto, UserRole>();
            //CreateMap<Book, BookDtoRequest>();
            //CreateMap<BookDtoRequest, Book>();

            //CreateMap<Category, CategoryDtoRequest>();
            //CreateMap<CategoryDtoRequest, Category>();

            //CreateMap<Author, AuthorDtoRequest>();
            //CreateMap<AuthorDtoRequest, Author>();



        }
    }
}
