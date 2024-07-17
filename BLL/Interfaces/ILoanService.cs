using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ILoanService
    {
        Task<LoanDtoResponse> GetLoanById(int loanId);
        Task<List<LoanDtoResponse>> GetLoans();
        Task<object> AddLoan(LoanDtoRequest request);
        Task UpdateLoan(LoanDtoRequest request);
        Task DeleteLoan(int loanId);
    }
}
