using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404_v2.Models
{
    public class ProfessionalVM
    {
        public List<ProfessionalBundles> ProfessionalItems { get; set; }

        public ProfessionalVM()
        {
            ProfessionalItems = new List<ProfessionalBundles>();
        }
    }
}
