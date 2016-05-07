using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ArbetsprovV2.Models;
using ArbetsprovV2.Models.ViewModels;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ArbetsprovV2.Controllers
{
    public class SongController : Controller
    {
        // GET: /<controller>/
         IDataRepository _repository;
        public SongController(IDataRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(SongViewModel viewModel)
        {
            if(!ModelState.IsValid)
            return View(viewModel);
            return RedirectToAction("Display",viewModel);
        }

        public IActionResult Display(SongViewModel viewModel, string mood = null)
        {
            return View(_repository.GetSongs(viewModel));
        }
    }
}
