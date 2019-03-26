using System.Collections.Generic;
using SamosShelter.Data.Models;

namespace SamosShelter.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}