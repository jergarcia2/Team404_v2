using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404_v2.Models
{
    public class BeginnerVM
    {
        public List<BeginnerBundles> BeginnerItems { get; set; }

        public BeginnerVM()
        {
            BeginnerItems = new List<BeginnerBundles>();
        }
    }
}
