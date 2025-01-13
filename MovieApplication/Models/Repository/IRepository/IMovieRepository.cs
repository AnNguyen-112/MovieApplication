using ApplicationCore.Entities;


namespace MovieApplication.Models.Repository.IRepository
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetAllMovieAsync();
        Task<Movie> GetMovieByIdAsync(int id);
    }
}
