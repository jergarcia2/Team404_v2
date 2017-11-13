using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404_v2.Models
{
    public class MotherboardVM
    {

		public List<CPMotherboard> MotherboardItems { get; set; }

		public MotherboardVM()
		{
			MotherboardItems = new List<CPMotherboard>();
		}
	}
}
