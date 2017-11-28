using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Team404_v2.Models
{
    public class BeginnerBundles
    {
		[Key]
		public int id { get; set; }
		[MaxLength(250)]
		public string BundleTitle { get; set; }

		public decimal? BundlePrice { get; set; }

		[MaxLength(250)]
		public string BundleLink { get; set; }
		[MaxLength(250)]
		public string ProductName1 { get; set; }
		[MaxLength(250)]
		public string ProductName2 { get; set; }
		[MaxLength(250)]
		public string ProductName3 { get; set; }
		public string Wishlist { get; set; }
		public string RemoveDetails { get; set; }

		[MaxLength(250)]
		public string MiniDescription11 {get; set; }
		[MaxLength(250)]
		public string MiniDescription12 { get; set; }
		[MaxLength(250)]
		public string MiniDescription13 { get; set; }


		[MaxLength(250)]
		public string MiniDescription21 { get; set; }
		[MaxLength(250)]
		public string MiniDescription22 { get; set; }
		[MaxLength(250)]
		public string MiniDescription23 { get; set; }



		[MaxLength(250)]
		public string MiniDescription31 { get; set; }
		[MaxLength(250)]
		public string MiniDescription32 { get; set; }
		[MaxLength(250)]
		public string MiniDescription33 { get; set; }


	}
}
