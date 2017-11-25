using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404_v2.Models
{
    public class SoundCardsVM
    {
		public List<CPSoundCards> CPSoundCards { get; set; }

		public SoundCardsVM()
		{
			CPSoundCards = new List<CPSoundCards>();
		}
	}
}
