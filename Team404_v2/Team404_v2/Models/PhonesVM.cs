using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404_v2.Models
{
    public class PhonesVM
    {
		public List<APhones> PhonesItems { get; set; }

		public PhonesVM()
		{
			 PhonesItems= new List<APhones>();
		}
	}
}
