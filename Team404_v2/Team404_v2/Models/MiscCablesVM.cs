using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404_v2.Models
{
    public class MiscCablesVM
    {
		public List<AMiscCables> AMiscCables { get; set; }

		public MiscCablesVM()
		{
			AMiscCables = new List<AMiscCables>();
		}
	}
}
