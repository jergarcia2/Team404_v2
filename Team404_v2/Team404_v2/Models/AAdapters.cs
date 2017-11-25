using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Team404_v2.Models
{
    public class AAdapters
    {
		[Key]
		public int Id { get; set; }

		[MaxLength(250)]
		public string ItemTitle { get; set; }


		[MaxLength(250)]
		public string MiniDescription { get; set; }

		[MaxLength(250)]
		public string MiniDescription2 { get; set; }

		[MaxLength(250)]
		public string MiniDescription3 { get; set; }

		[MaxLength(250)]
		public string LongDescription1 { get; set; }

		[MaxLength(250)]
		public string LongDescription2 { get; set; }

		[MaxLength(250)]
		public string LongDescription3 { get; set; }

		[MaxLength(250)]
		public string ItemLink { get; set; }

		[MaxLength(250)]
		public string Wishlist { get; set; }

		[MaxLength(250)]
		public string Price1Name { get; set; }

		[MaxLength(250)]
		public string Price1Link { get; set; }

		[MaxLength(250)]
		public string Price2Name { get; set; }

		[MaxLength(250)]
		public string Price2Link { get; set; }

		[MaxLength(250)]
		public string Price3Name { get; set; }

		[MaxLength(250)]
		public string Price3Link { get; set; }


		public decimal? ItemPrice { get; set; }


		public decimal? ItemPrice2 { get; set; }

		[MaxLength(250)]
		public string RemoveDetails { get; set; }

	}
}
