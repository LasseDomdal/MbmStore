using System.Collections.Generic;
using MbmStore.Models;

namespace MbmStore.ViewModels
{
    public class ProductViewModel
    {
        
        public List<Book> Books { get; set; }
        public List<Movie> Movies { get; set; }
        public List<MusicCD> MusicCds { get; set; }

    }
}