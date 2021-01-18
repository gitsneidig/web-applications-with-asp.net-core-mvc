using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockCategoryRepository : ICategoryRepository

    {
        public IEnumerable<Category> AllCategories => 
            new List<Category>
            {
                new Category{ CategoryId=1, CategoryName="Fruit Pies", Description="All-fruit pies" },
                new Category{ CategoryId=2, CategoryName="Cheese Cakes", Description="Cheesy desert pies" },
                new Category{ CategoryId=3, CategoryName="Seasonal Pies", Description="Pies for each season" }
            };
    }
}
