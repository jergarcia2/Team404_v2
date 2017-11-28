using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404_v2.Models
{
    public class BundlesVM
    {
        public List<Bundles> Bundles { get; set; }

        public BundlesVM()
        {
            Bundles = new List<Bundles>();
        }
    }
}
