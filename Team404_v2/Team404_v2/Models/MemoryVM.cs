using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404_v2.Models
{
    public class MemoryVM
    {
		public List<CPMemory> CPMemory { get; set; }

		public MemoryVM()
		{
			CPMemory = new List<CPMemory>();
		}
	}
}
