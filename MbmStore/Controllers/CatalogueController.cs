using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MbmStore.Infrastructure;
using MbmStore.Models;
using MbmStore.ViewModels;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        // GET
        public ActionResult Index()
        {

            IList<Movie> movieList = new List<Movie>();
            movieList = Repository.Products.OfType<Movie>().ToList();
            
            IList<Book> bookList = new List<Book>();
            bookList = Repository.Products.OfType<Book>().ToList();
            
            
            IList<MusicCD> cdList = new List<MusicCD>();
            cdList = Repository.Products.OfType<MusicCD>().ToList();

            var productViewModel = new ProductViewModel
            {
                Movies = (List<Movie>) movieList,
                Books = (List<Book>) bookList,
                MusicCds = (List<MusicCD>) cdList
            };

            
            
            return View(productViewModel);
        }
    }
}