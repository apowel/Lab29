using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoviesDAL;

namespace Lab29.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly Lab29Context _context;

        public MoviesController(Lab29Context context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<Movie> GetMovies()
        {
            var movieList = _context.Movies.ToList();
            return Ok(movieList);
        }
        [HttpGet("genre/{genre}")]
        public ActionResult<List<Movie>> GetMovieByGenre(string genre)
        {
            var movies = _context.Movies.Where(e => e.Genre == genre).ToList();
            return movies;
        }
        [HttpGet("random")]
        public ActionResult<Movie> GetRandom()
        {
            Random id = new Random();
            int select = id.Next(0, _context.Movies.Count());
            var movie = _context.Movies.ToList()[select];
            return movie;
        }
        [HttpGet("random/{genre}")]
        public ActionResult<Movie> GetRandombyGenre(String genre)
        {
            List<Movie> genreMovies = _context.Movies.Where(e => e.Genre == genre).ToList();
            Random num = new Random();
            int select = num.Next(0, genreMovies.Count());
            var movie = genreMovies[select];
            return movie;
        }
        [HttpGet("randomlist/{numSelect}")]
        public ActionResult<List<Movie>> GetRandomOfAmount(int numSelect)
        {
            Random num = new Random();
            int select;
            List<Movie> movieList = _context.Movies.ToList();
            List<Movie> result = new List<Movie>();
            if (movieList.Count < numSelect)
            {
                return movieList;
            }
            else
            {
                for (int i = 0; i < Math.Abs(numSelect); i++)
                {
                    select = num.Next(0, movieList.Count());
                    result.Add(movieList[select]);
                    movieList.Remove(movieList[select]);
                }
                return result;
            }
        }
        [HttpGet("genres")]
        public ActionResult<List<string>> GetGenres()
        {
            List<string> movieGenres= new List<string>();
            foreach (var movie in _context.Movies)
            {
                movieGenres.Add(movie.Genre);
            }
            List<string> result = movieGenres.Distinct().ToList();
            return result;
        }
        [HttpGet("{movie}")]
        public ActionResult<Movie> GetMovie(string movie)
        {
            return _context.Movies.FirstOrDefault(e => e.Title == movie);
        }
        [HttpGet("keyword/{keyword}")]
        public ActionResult<List<Movie>> GetMoviebyKeyword(string keyword)
        {
            return _context.Movies.Where(e => e.Title.Contains(keyword)).ToList();
        }
    }
}
