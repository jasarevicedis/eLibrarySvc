using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int PublishYear { get; set; }
        public List<BookItem> BookItems { get; set; }
        public List<Category> Categories { get; set; }
        public List<Author> Authors { get; set; }
        public List<Review> Reviews { get; set; }
        public string Description { get; set; }
        public string CoverImage { get; set; }
        

        public Book()
        {
        }

       
    }
}
