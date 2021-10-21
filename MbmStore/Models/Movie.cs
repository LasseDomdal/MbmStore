using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie : Product
    {
        public short Released { get; set; }
        
        //private string imageUrl;
        private string director;
        
        public string ImageUrl 
        {
            get; set; // autoimplemented property
            //get { return imageUrl; }
            //set { imageUrl = value; }
        }

        public string Director
        {
            get { return director; } 
            set { director = value; } 
        }
        
        // constructors
        public Movie(string title, decimal price) : base(title, price)
        {
        }

        public Movie(string title, decimal price, string director, string imageUrl) : base(title, price)
        {
            this.director = director;
            ImageUrl = imageUrl;
        }
    }
}