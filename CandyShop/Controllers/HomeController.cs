using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CandyShop.Models;
using CandyShop.ViewModels;

namespace CandyShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICandyRepository _CandyRepository;

        public HomeController(ICandyRepository CandyRepository)
        {
            _CandyRepository = CandyRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel()
            {
                CandyOnSale = _CandyRepository.GetCandyOnSale
            };

            return View(homeViewModel);
        }
    }
}
