using AutoMapper;
using MovieApplication.Models.ViewModels;


namespace MovieApplication.Models.Repository.IRepository
{
    public class MovieService : IMovieServiceRepository
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IMapper _mapper;

        public MovieService(IMovieRepository movieRepository, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _mapper = mapper;
        }
        public async Task<List<MovieCardVM>> GetMovieCardsAsync()
        {
            
            var movies = await _movieRepository.GetAllMovieAsync();


            return _mapper.Map<List<MovieCardVM>>(movies);
        }
    }
}
