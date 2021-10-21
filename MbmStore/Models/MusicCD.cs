using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {
        

        public string Artist { get; set; }
        public string Label { get; set; }
        public short Released { get; set; }
        
        private List<Track> tracks = new List<Track>();

        public List<Track> Tracks {
            get { return tracks; }
        }

        public MusicCD()
        {
        }

        public MusicCD(string title, decimal price, string artist, short released, string publisher, string imageUrl) : base(title, price)
        {
            Artist = artist;
            Released = released;
        }

        public void AddTrack(Track track) {
            tracks.Add(track);
        }
        
        public TimeSpan GetPlayingTIme()
        {
            TimeSpan tracksLenght = new TimeSpan(00,00,00);
            foreach (var track in tracks)
            {
                tracksLenght += track.Length;
            }

            return tracksLenght;
        }

    }
}