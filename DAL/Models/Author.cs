using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Book> Books { get; set; }

        public Author() { }

        public Author(int id, string firstName, string lastName, List<Book> books)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Books = books;
        }
    }
}
