using AutoMapper;
using BLL.DTOs;
using BLL.Interfaces;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class LoanService: ILoanService
    {
        private readonly IMapper _mapper;
        private readonly ILoanRepository _loanRepository;

        public Task<object> AddLoan(LoanDtoRequest request)
        {
            throw new NotImplementedException();
        }

        public Task DeleteLoan(int loanId)
        {
            throw new NotImplementedException();
        }

        public Task<LoanDtoResponse> GetLoanById(int loanId)
        {
            throw new NotImplementedException();
        }

        public Task<List<LoanDtoResponse>> GetLoans()
        {
            throw new NotImplementedException();
        }

        public Task UpdateLoan(LoanDtoRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
