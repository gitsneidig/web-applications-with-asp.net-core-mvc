using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class MockPieRepository : IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Pie> AllPies => 
            new List<Pie>
            {
            new Pie { PieId = 1, Name="Strawberry Pie", Price=15.99M, ShortDescription="Strawberry Pie Short", LongDescription="Strawberry Pie Long", Category = _categoryRepository.AllCategories.ToList()[0] },
            new Pie { PieId = 2, Name="Cheesecake", Price=18.99M, ShortDescription="Cheesecake Short", LongDescription="Cheesecake Long", Category = _categoryRepository.AllCategories.ToList()[1] },
            new Pie { PieId = 3, Name="Rhubarb Pie", Price=15.99M, ShortDescription="Rhubarb Pie Short", LongDescription="Rhubarb Pie Long", Category = _categoryRepository.AllCategories.ToList()[0] },
            new Pie { PieId = 4, Name="Pumpkin Pie", Price=12.99M, ShortDescription="Pumpkin Pie Short", LongDescription="Pumpkin Pie Long", Category = _categoryRepository.AllCategories.ToList()[2] }
            };

        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public Pie GetPieById(int pieId)
        {
            
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
