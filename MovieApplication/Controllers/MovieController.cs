using ApplicationCore.Contracts;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MovieApplication.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;

        }

        public IActionResult Index()
        {
            
            var result = _movieRepository.GetAll();
            return View(result);
            
        }
    }
}
