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

        public Loan(int id, BookItem bookItem, User user, DateTime loanTime)
        {
            Id = id;
            BookItem = bookItem;
            User = user;
            LoanTime = loanTime;
        }

        public int Id { get; set; }
        public BookItem BookItem { get; set; }
        public User User { get; set; }
        public DateTime LoanTime { get; set; }
    }
}
