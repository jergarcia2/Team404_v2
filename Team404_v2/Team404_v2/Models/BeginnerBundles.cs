using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404_v2.Models
{
    public class BeginnerBundles
    {
		public string BundleTitle { get; set; }
		public double BundlePrice { get; set; }
		public string BundleLink { get; set; }
		public string ProductName1 { get; set; }
		public string ProductName2 { get; set; }
		public string ProductName3 { get; set; }
		public string Wishlist { get; set; }
		public string RemoveDetails { get; set; }
		public List<string> MiniDescription1 { get; set; }
		public List<string> MiniDescription2 { get; set; }
		public List<string> MiniDescription3 { get; set; }

		public BeginnerBundles()
		{
			MiniDescription1 = new List<string>();
			MiniDescription2 = new List<string>();
			MiniDescription3 = new List<string>();
		}
	}
}
