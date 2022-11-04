﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandyShop.Models
{
    public interface ICategoryPepository
    {
        IEnumerable<Category> GetAllCategories { get; }
    }
}
