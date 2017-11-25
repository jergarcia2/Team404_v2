using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404_v2.Models
{
    public class ChargersVM
    {
		public List<AChargers> AChargers { get; set; }

		public ChargersVM()
		{
			AChargers = new List<AChargers>();
		}
	}
}
