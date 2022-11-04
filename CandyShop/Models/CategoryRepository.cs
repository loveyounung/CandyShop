using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CandyShop.Models
{
    public class CategoryRepository : ICategoryPepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> GetAllCategories {
            get {
                return _appDbContext.Categires;
            }
        }

        #region back up
        //Select Data Temp
        public IEnumerable<Category> GetAllCategories_bak => new List<Category> {
            new Category { CategoryId =1,CategoryName ="Hard Candy" ,CategoryDescription ="Awesom and Delicious Hard Candy"},
            new Category {CategoryId =2,CategoryName ="Chocolate Candy" ,CategoryDescription ="Scuptious Chocole Candy" },
            new Category {CategoryId =3,CategoryName ="Chocolate Candy" ,CategoryDescription ="Scuptious Chocole Candy" },
        };
        #endregion

    }
}
