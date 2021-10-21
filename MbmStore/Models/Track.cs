using System;

namespace MbmStore.Models
{
    public class Track
    {
        public string title { get; set; }
        
        public TimeSpan Length { get; set; }
        
        public string Composer {get; set;}

        public Track()
        {
        }

        public Track(string title, TimeSpan length)
        {
            this.title = title;
            Length = length;
        }
    }
}