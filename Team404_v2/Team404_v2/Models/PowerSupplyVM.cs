using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404_v2.Models
{
    public class PowerSupplyVM
    {

		public List<CPPowerSupply> CPPowerSupply { get; set; }

		public PowerSupplyVM()
		{
			CPPowerSupply = new List<CPPowerSupply>();
		}
	}
}
