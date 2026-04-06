using HandsOnMVCUsingEFWithAsync.DTOs;
using HandsOnMVCUsingEFWithAsync.Entities;
using HandsOnMVCUsingEFWithAsync.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnMVCUsingEFWithAsync.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [Route("GetAllMovies")]
        public async Task<IActionResult> Index()
        {
            var movies = await _movieRepository.GetAllMoviesAsync();
            //convert Movies to ReadMoviesDto
            var movieDtos = movies.Select(m => new ReadMovieDto()
            {
                MovieId = m.MovieId,
                Title = m.Title,
                ReleaseYear = m.ReleaseYear,
                Director = m.Director,

            });
            return View(movieDtos);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateMovieDto dto)
        {
            if(ModelState.IsValid)
            {
                //convert dto to movie entity
                var movie = new Movie()
                {
                    Title=dto.Title,
                    ReleaseYear=dto.ReleaseYear,
                    Director=dto.Director,
                };
                await _movieRepository.AddMovieAsync(movie);
                return RedirectToAction("Index");
                    
            }
            return View();
        }
    }
}