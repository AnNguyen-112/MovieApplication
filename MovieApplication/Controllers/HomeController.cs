using Microsoft.AspNetCore.Mvc;
using MovieApplication.Models;
using MovieApplication.Models.Repository.IRepository;
using System.Diagnostics;

namespace MovieApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMovieServiceRepository _movieServiceRepository;

        public HomeController(ILogger<HomeController> logger, IMovieServiceRepository movieServiceRepository)
        {
            _logger = logger;
            _movieServiceRepository = movieServiceRepository;
        }

        public async Task<IActionResult> Index()
        {
            var movieCards = await _movieServiceRepository.GetMovieCardsAsync();
            return View(movieCards);                                
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
