using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SamosShelter.Data.Models;

namespace SamosShelter.ViewModels
{
    public class AdoptionListViewModel
    {
        public IEnumerable<Adoption> Animals { get; set; }
        public string CurrentCategory { get; set; }
    }
}
