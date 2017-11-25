using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404_v2.Models
{
    public class PhonesVM
    {
		public List<APhones> APhones { get; set; }

		public PhonesVM()
		{
			 APhones = new List<APhones>();
		}
	}
}
