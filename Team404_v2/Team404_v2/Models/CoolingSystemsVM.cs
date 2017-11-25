using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404_v2.Models
{
    public class CoolingSystemsVM
    {
			public List<CPCoolingSystems> PCCoolingSystems { get; set; }

			public CoolingSystemsVM()
			{
				PCCoolingSystems = new List<CPCoolingSystems>();
			}
		}
}
