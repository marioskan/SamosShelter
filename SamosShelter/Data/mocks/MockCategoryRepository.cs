using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SamosShelter.Data.Interfaces;
using SamosShelter.Data.Models;

namespace SamosShelter.Data.mocks
{
    public class MockCategoryRepository:ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category{CategoryType = "Dog", CategoryDescription = "All available doggies"},
                    new Category{CategoryType = "Other", CategoryDescription = "Other available animals"}
                };
            }
        }
    }
}
