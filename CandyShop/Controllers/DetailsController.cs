using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CandyShop.Models;

namespace CandyShop.Controllers
{
    public class DetailsController : Controller
    {
        protected readonly ICandyRepository _CandyRepository;
        protected readonly ICategoryPepository _CategoryPepository;

        public DetailsController(ICandyRepository CandyRepository ,ICategoryPepository CategoryPepository)
        {
            _CandyRepository = CandyRepository;
            _CategoryPepository = CategoryPepository;
        }

        public IActionResult Details() {
            return View(_CandyRepository.GetAllCandy);
        }
    }
}
