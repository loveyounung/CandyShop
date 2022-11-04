using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CandyShop.Models;
using CandyShop.ViewModels;

namespace CandyShop.Controllers
{
    public class CandyController : Controller
    {
        private readonly ICandyRepository _CandyRepository;
        private readonly ICategoryPepository _CategoryPepository;


        public CandyController(ICandyRepository CandyRepository, ICategoryPepository CategoryPepository)
        {
            _CandyRepository = CandyRepository;
            _CategoryPepository = CategoryPepository;
        }

        public IActionResult List()
        {
            var candyListViewModel = new CandyListViewModel();
            candyListViewModel.Candies = _CandyRepository.GetAllCandy;
            candyListViewModel.CurrentCategory = "BestSellers";
            return View(candyListViewModel);

            /*
            ViewBag.CurrentCategory = "xxx";

            return View(_CandyRepository.GetAllCandy);
            */
        }

        public IActionResult Details(int id) {
            var candy = _CandyRepository.GetCandyById(id);
            if (candy == null) return NotFound();

            return View(candy);
        }

        public ViewResult List_bak() {
            ViewBag.CurrentCategory = "xxx";

            return View(_CandyRepository.GetAllCandy);
        }

    }
}
