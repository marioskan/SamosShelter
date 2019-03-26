using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SamosShelter.Data.Interfaces;
using SamosShelter.ViewModels;

namespace SamosShelter.Controllers
{
    public class AdoptionController :Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IAdoptRepository _adoptRepository;

        public AdoptionController(ICategoryRepository categoryRepository, IAdoptRepository adoptRepository)
        {
            _categoryRepository = categoryRepository;
            _adoptRepository = adoptRepository;
        }

        public ViewResult List()
        {
            ViewBag.Name = "DotNet, How";
            var adoption = _adoptRepository.Animals;
            AdoptionListViewModel vm = new AdoptionListViewModel();
            vm.Animals = _adoptRepository.Animals;
            vm.CurrentCategory = "AnimalCategory";
            return View(vm);
        }
    }
}
