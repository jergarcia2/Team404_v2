using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team404_v2.Models
{
	public class ProductVM
	{

		public List<Products> Products { get; set; }

		public ProductVM()
		{
			Products = new List<Products>();
		}
	}
}