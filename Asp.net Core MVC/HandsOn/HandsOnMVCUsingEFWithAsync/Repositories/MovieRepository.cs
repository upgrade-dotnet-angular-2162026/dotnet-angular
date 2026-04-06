using HandsOnMVCUsingEFWithAsync.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
namespace HandsOnMVCUsingEFWithAsync.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDbContext _context;

        public MovieRepository(MovieDbContext context)
        {
            _context = context;
        }

        public async Task AddMovieAsync(Movie movie)
        {
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMovieAsync(int movieId)
        {
            var movie= await _context.Movies.FindAsync(movieId);
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
        }

        public async Task EditMovieAsync(Movie movie)
        {
           _context.Movies.Update(movie);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Movie>> GetAllMoviesAsync()
        {
            var movies = await _context.Movies.ToListAsync();
            return movies;
        }

        public async Task<List<Movie>> GetAllMoviesByDirectorAsync(string director)
        {
            var movies = await _context.Movies.Where(m=>m.Director==director).ToListAsync();
            return movies;
        }

        public async Task<List<Movie>> GetAllMoviesByYearAsync(int year)
        {
            var movies = await _context.Movies.Where(m => m.ReleaseYear == year).ToListAsync();
            return movies;
        }

        public async Task<Movie> GetMovieAsync(string movieName)
        {
            var movie = await _context.Movies.FirstOrDefaultAsync(m => m.Title == movieName);
            return movie;
        }

        public async Task<Movie> GetMovieByIdAsync(int movieId)
        {
            var movie = await _context.Movies.FindAsync(movieId);
            return movie;
        }

       
    }
}
