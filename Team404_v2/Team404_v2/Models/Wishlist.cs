using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team404_v2.Models
{
	[Table ("Wishlist")]

	public class Wishlist
	{

		[Key]
		public string Id { get; set; }

		[MaxLength(250)]
		public string ItemNames { get; set; }
		[MaxLength(250)]
		public string LinkRemove { get; set; }
		[MaxLength(250)]
		public string Undo { get; set; }
		[MaxLength(250)]
		public string ProductLink { get; set; }

		public decimal? Prices1 { get; set; }
		public decimal? Prices2 { get; set; }
		public decimal? Prices3 {get; set;}
	

	}
}
