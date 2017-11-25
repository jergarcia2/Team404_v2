using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404_v2.Models
{
    public class AdaptersVM
    {
		public List<AAdapters> AAdapters { get; set; }

		public AdaptersVM()
		{
			AAdapters = new List<AAdapters>();
		}
	}
}
