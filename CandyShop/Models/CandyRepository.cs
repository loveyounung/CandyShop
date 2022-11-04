using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CandyShop.Models
{
    public class CandyRepository : ICandyRepository
    {
        private readonly AppDbContext _appDbContext;

        public CandyRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //public IEnumerable<Candy> GetAllCandy => _appDbContext.Candies.Include(c => c.Category);

        public IEnumerable<Candy> GetAllCandy
        {
            get
            {
                if (_appDbContext.Candies != null)
                {
                    return _appDbContext.Candies.Include(c => c.Category);
                }
                else
                {
                    return new List<Candy>();
                }
            
            }
        }


        //ดึงข้อมูล CandyOnSale
        public IEnumerable<Candy> GetCandyOnSale
        {
            get
            {
                return _appDbContext.Candies.Include(c => c.Category).Where(p => p.IsOnSale);
            }
        }

        //ดึงข้อมูล by candyId
        public Candy GetCandyById(int candyId)
        {
            return _appDbContext.Candies.FirstOrDefault(c => c.CandyId == candyId);
        }

        #region Back Up 

        //Select Data Temp

        /*
        private readonly ICategoryPepository _CategoryPepository = new CategoryRepository();
        public IEnumerable<Candy> GetAllCandy_bak => new List<Candy> {
            new Candy { CandyId = 1,Name ="Assorted Hard Candy",Price = 4.95M, Description="11111111111111"
        , Category = _CategoryPepository.GetAllCategories.ToList()[0],ImageUrl ="",IsInStock = true,IsOnSale = false ,ImageThumbnailUrl =""},
            new Candy { CandyId = 2,Name ="Assorted Hard Candy",Price = 4.00M, Description="22222222222"
        , Category = _CategoryPepository.GetAllCategories.ToList()[1],ImageUrl ="",IsInStock = true,IsOnSale = false ,ImageThumbnailUrl =""},
        };
        */

        public Candy GetCandyById_bak(int candyId)
        {
            return GetAllCandy.FirstOrDefault(c => c.CandyId == candyId);
        }


        #endregion
    }
}
