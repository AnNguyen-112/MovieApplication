using ApplicationCore.Entities;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MovieApplication.Controllers
{
    public class GenreController: Controller
    {

        private readonly GenreRepository _genreRepository;

        public GenreController(GenreRepository genreRepository)
        {
            this._genreRepository = genreRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Genre genre)
        {
            if (ModelState.IsValid)
            {
                _genreRepository.Insert(genre);
                return RedirectToAction("Index");
            }

            return View(genre);
        }
    }
}
