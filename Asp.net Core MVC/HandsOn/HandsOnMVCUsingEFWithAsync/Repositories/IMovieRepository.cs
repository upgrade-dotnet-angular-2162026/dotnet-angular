using HandsOnMVCUsingEFWithAsync.Entities;

namespace HandsOnMVCUsingEFWithAsync.Repositories
{
    public interface IMovieRepository
    {
        //declare the async functions
        Task AddMovieAsync(Movie movie);
        Task EditMovieAsync(Movie movie);    
        Task DeleteMovieAsync(int movieId);
        Task<Movie> GetMovieAsync(string movieName);
        Task<Movie> GetMovieByIdAsync(int movieId);
        Task<List<Movie>> GetAllMoviesAsync();
        Task<List<Movie>> GetAllMoviesByYearAsync(int year);
        Task<List<Movie>> GetAllMoviesByDirectorAsync(string director);
    }
}
