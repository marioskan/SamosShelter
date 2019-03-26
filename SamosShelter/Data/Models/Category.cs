using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamosShelter.Data.Models
{
    public class Category
    {
        public string CategoryType { get; set; }

        public string CategoryDescription { get; set; }

        public List<Adoption> Animals { get; set; }

        
    }
}
