using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SamosShelter.Data.Interfaces;
using SamosShelter.Data.Models;

namespace SamosShelter.Data.mocks
{
    public class MockAdoptionRepository:IAdoptRepository
    {
        private readonly  ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Adoption> Animals
        {
            get
            {
                return new List<Adoption>
                {
                    new Adoption
                    {
                        Name = "Lucy",
                        Breed = "Labrador",
                        Age = 1.5,
                        AnimalId = 001,
                        Image = "https://core.pupcdn.com/assets/puppyspot/img/schema/breed/labrador-retriever_aspect-ratio_1x1.jpg",
                        Category = _categoryRepository.Categories.First()
                    },
                    new Adoption
                    {
                        Name = "Lacy",
                        Breed = "Colley",
                        Age = 14,
                        AnimalId = 002,
                        Image = "http://www.topontiki.gr/sites/default/files/article/2017-10/screenshot_1_3.jpg",
                        Category = _categoryRepository.Categories.First()
                    },
                    new Adoption
                    {
                        Name = "Scooby Doo",
                        Breed = "Greate Dane",
                        Age = 10,
                        AnimalId = 003,
                        Image = "https://upload.wikimedia.org/wikipedia/en/5/53/Scooby-Doo.png",
                        Category = _categoryRepository.Categories.First()
                    }
                };
            }
            set => throw new NotImplementedException();
        }

        public Adoption GetAnimalById(int AnimalId)
        {
            throw new NotImplementedException();
        }
    }
}
