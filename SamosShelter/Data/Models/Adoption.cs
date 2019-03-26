using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SamosShelter.Data.Models
{
    public class Adoption
    {
        public string Breed { get; set; }

        public string Name { get; set; }

        public double Age { get; set; }

        public string Image { get; set; }

        public int AnimalId { get; set; }

        public virtual Category Category { get; set; }
    }
}
