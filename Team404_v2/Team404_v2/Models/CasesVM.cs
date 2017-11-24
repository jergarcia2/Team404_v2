using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Team404_v2.Models
{
    public class CasesVM
    {
		public List<CPCases> CPCases { get; set; }

		public CasesVM()
		{
			CPCases = new List<CPCases>(); 
		}
    }
}
