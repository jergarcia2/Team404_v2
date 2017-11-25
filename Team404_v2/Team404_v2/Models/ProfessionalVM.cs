using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404_v2.Models
{
    public class ProfessionalVM
    {
        public List<ProfessionalBundles> ProfessionalBundles { get; set; }

        public ProfessionalVM()
        {
            ProfessionalBundles = new List<ProfessionalBundles>();
        }
    }
}
