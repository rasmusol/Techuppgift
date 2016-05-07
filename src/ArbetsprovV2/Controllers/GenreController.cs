using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArbetsprovV2.Models;
using ArbetsprovV2.Models.ViewModels;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ArbetsprovV2.Controllers
{
    public class GenreController : Controller
    {
        // GET: /<controller>/
         IDataRepository _repository;

        public GenreController(IDataRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(ArtistViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            return RedirectToAction("Display", viewModel);
        }

        public IActionResult Display(ArtistViewModel viewModel)
        {
            return View(_repository.GetArtists(viewModel)) ;
        }
    }
}
