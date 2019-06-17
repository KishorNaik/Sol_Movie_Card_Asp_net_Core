using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sol_Movie_Card.Models;
using Sol_Movie_Card.Repository;
using Sol_Movie_Card.ViewModel;

namespace Sol_Movie_Card.Controllers
{
    public class MovieController : Controller
    {
        #region Declaration
        private MovieRepository movieRepository = null;
        #endregion

        #region Constructor
        public MovieController(MovieRepository movieRepository)
        {
            this.movieRepository = movieRepository;
            MovieVM = new MovieViewModel();
        }

        #endregion

        #region Property
        [BindProperty]
        public MovieViewModel MovieVM { get; set; }
        #endregion 

        public async  Task<IActionResult> Index()
        {
            MovieVM.MovieList =
                    await
                        movieRepository.GetListOfMoviesAsync()
                        as List<MovieModel>;

            return View(MovieVM);
        }
    }
}