using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublishYear { get; set; }
        public List<BookItem> BookItems { get; set; }
        public List<Category> Categories { get; set; }
        public List<Author> Authors { get; set; }
        //public string Description { get; set; }
        //public string CoverImage { get; set; }
        //public string ISBN { get; set; }

        public Book()
        {
        }

        public Book(int id, string title, int publishYear, List<BookItem> bookItems, List<Category> categories, List<Author> authors)
        {
            Id = id;
            Title = title;
            PublishYear = publishYear;
            BookItems = bookItems;
            Categories = categories;
            Authors = authors;
        }
    }
}
