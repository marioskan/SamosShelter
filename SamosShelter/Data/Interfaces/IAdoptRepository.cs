using System.Collections.Generic;
using SamosShelter.Data.Models;

namespace SamosShelter.Data.Interfaces
{
    public interface IAdoptRepository
    {
        IEnumerable<Adoption> Animals { get;  }

        Adoption GetAnimalById(int AnimalId);
    }
}