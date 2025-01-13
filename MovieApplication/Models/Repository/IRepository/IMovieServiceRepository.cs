using MovieApplication.Models.ViewModels;


namespace MovieApplication.Models.Repository.IRepository
{
    public interface IMovieServiceRepository
    {
        Task<List<MovieCardVM>> GetMovieCardsAsync();
    }
}
