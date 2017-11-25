using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404_v2.Models
{
    public class VideoCardsVM
    {

		public List<CPVideoCards> CPVideoCards { get; set; }

		public VideoCardsVM()
		{
			CPVideoCards = new List<CPVideoCards>();
		}
	}
}
