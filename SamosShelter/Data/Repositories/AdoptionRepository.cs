using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SamosShelter.Data.Interfaces;
using SamosShelter.Data.Models;

namespace SamosShelter.Data.Repositories
{
    public class AdoptionRepository :IAdoptRepository
    {
        private readonly AppDbContext _appDbContext;

        public AdoptionRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Adoption> Animals => _appDbContext.Animals.Include(c => c.Category);

        public Adoption GetAnimalById(int animalId) =>
            _appDbContext.Animals.FirstOrDefault(p => p.AnimalId == animalId);

    }
}
