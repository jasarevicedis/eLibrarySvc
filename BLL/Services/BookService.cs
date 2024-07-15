using AutoMapper;
using BLL.Interfaces;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class BookService: IBookService
    {
        private readonly IMapper _mapper;
        private readonly IBookRepository _bookRepository;
    }
}
