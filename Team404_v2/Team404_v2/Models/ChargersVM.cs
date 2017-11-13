using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404_v2.Models
{
    public class ChargersVM
    {
		public List<AChargers> ChargersItems { get; set; }

		public ChargersVM()
		{
			ChargersItems = new List<AChargers>();
		}
	}
}
