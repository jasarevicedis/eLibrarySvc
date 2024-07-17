﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class BookItem
    {
        public int BookItemId { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
        public string InstanceId { get; set; }

        public BookItem()
        {
        }

        
    }
}
