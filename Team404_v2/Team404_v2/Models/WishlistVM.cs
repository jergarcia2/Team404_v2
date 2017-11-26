using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404_v2.Models
{
	public class WishlistVM
	{

		public List<Wishlist> Wishlist { get; set; }

		public WishlistVM()
		{
			Wishlist = new List<Wishlist>();
		}
	}
}