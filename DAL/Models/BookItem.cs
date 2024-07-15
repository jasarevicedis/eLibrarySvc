using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class BookItem
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public string InstanceId { get; set; }

        public BookItem()
        {
        }

        public BookItem(int id, Book book, string instanceId)
        {
            Id = id;
            Book = book;
            InstanceId = instanceId;
        }
    }
}
