using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404_v2.Models
{

    public class MidGradeVM
    {
        public List<MidGradeBundles> MidGradeBundles { get; set; }

        public MidGradeVM()
        {
            MidGradeBundles = new List<MidGradeBundles>();
        }
    }

}
