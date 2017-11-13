using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404_v2.Models
{
    public class CPMemory
    {
		public string ItemTitle { get; set; }
		public List<string> MiniDescription { get; set; }
		public List<string> LongDescription { get; set; }
		public string ItemLink { get; set; }
		public string Wishlist { get; set; }
		public string Price1Name { get; set; }
		public string Price2Name { get; set; }
		public string Price3Name { get; set; }
		public double ItemPrice { get; set; }
		public double ItemPrice2 { get; set; }
		public double ItemPrice3 { get; set; }
		public string RemoveDetails { get; set; }
		public CPMemory()
		{
			MiniDescription = new List<string>();
			LongDescription = new List<string>();
		}
	}
}
