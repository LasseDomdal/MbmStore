using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Book : Product 
    {
        public string Author { get; set; }
        public string Publisher { get; set; }
        public short Published { get; set; }
        public string ISBN { get; set; }
        
        public string ImageUrl 
        {
            get; set; 
        }

        public Book() { }

        public Book(string title, decimal price, string author, short published, string isbn, string imageUrl) : base(title, price)
        {
            Author = author;
            Published = published;
            ISBN = isbn;
            ImageUrl = imageUrl;
        }
    }
}