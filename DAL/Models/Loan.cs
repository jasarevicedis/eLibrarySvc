using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Loan
    {
        public Loan()
        {
        }

        public int LoanId { get; set; }
        public int BookItemId { get; set; }
        public int UserId   { get; set; }
        public BookItem BookItem { get; set; }
        public User User { get; set; }
        public DateTime LoanTime { get; set; }
    }
}
