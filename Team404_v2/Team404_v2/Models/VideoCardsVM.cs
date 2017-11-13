using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404_v2.Models
{
    public class VideoCardsVM
    {

		public List<CPVideoCards> VideoCardsItems { get; set; }

		public VideoCardsVM()
		{
			VideoCardsItems = new List<CPVideoCards>();
		}
	}
}
