using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Team404_v2.Models
{
    public class CasesVM
    {
		public List<CPCases> CasesItems { get; set; }

		public CasesVM()
		{
			CasesItems = new List<CPCases>(); 
		}
    }
}
