using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            pieRepository = _pieRepository;
            categoryRepository = _categoryRepository;
        }

        public ViewResult List()
        {
            return View(_pieRepository.AllPies);
        }
    }
}
