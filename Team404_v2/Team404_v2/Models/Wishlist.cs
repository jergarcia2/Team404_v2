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
		public int RecordId { get; set; }
        public string WishlistId { get; set; }
		public int ProductId  { get; set; }

        [MaxLength(250)]
		public string LinkRemove { get; set; }

        [MaxLength(250)]
		public string Undo { get; set; }

        [MaxLength(250)]
		public string ProductLink { get; set; }

        public int Count { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual Products Product { get; set; }
    }
}
