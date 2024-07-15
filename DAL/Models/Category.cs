using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public Category() { }

        public Category(int id, string name, List<Book> books) { 
            Id = id;
            Name = name;
            Books = books;
        }
    }
}
