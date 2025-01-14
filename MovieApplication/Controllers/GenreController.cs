using ApplicationCore.Contracts;
using ApplicationCore.Entities;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MovieApplication.Controllers
{
    public class GenreController: Controller
    {

        private readonly IGenreRepository _iGenreRepository;

        public GenreController(IGenreRepository iGenreRepository)
        {
            _iGenreRepository = iGenreRepository;
        }
        public IActionResult Index()
        {
            var result = _iGenreRepository.GetAll();
            return View(result);
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
                _iGenreRepository.Insert(genre);
                return RedirectToAction("Index");
            }

            return View(genre);
        }

        public IActionResult Detail(int id)
        {
            var g = _iGenreRepository.GetById(id);
            return View(g);
        }

        public IActionResult Edit(int id)
        {
            var g = _iGenreRepository.GetById(id);
            return View(g);
        }

        [HttpPost]
        public IActionResult Edit(Genre g)
        {
            if (ModelState.IsValid)
            {
                _iGenreRepository.Update(g, g.Id);
                return RedirectToAction("Index");
            }
            return View(g);
        }

        public IActionResult Delete(int id)
        {
            var g = _iGenreRepository.GetById(id);
            return View(g);
        }

        [HttpPost]
        public IActionResult Delete(Genre g)
        {
            var result = _iGenreRepository.GetById(g.Id);
            if (_iGenreRepository.Delete(g.Id) > 0)
            {
                
                return RedirectToAction("Index");
            }
            return View(result);
        }


    }
}
