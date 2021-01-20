﻿using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            PiesListViewModel piesListViewModel = new PiesListViewModel();
            piesListViewModel.Pies = _pieRepository.AllPies;

            piesListViewModel.CurrentCategory = "Cheese Cakes";
            return View(piesListViewModel);
        }

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();
            return View(pie);
            
        }

    }
}
