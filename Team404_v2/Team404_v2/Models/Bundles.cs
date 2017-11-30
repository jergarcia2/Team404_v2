using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Team404_v2.Models
{
    public class Bundles
    {
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(50)]
		[Display(Name = "Category")]
		public string ProductCategory { get; set; }

        [Required]
        [Display(Name = "Title")]
        [MaxLength(250)]
		public string BundleTitle { get; set; }

        [Required]
        [Display(Name = "Price")]
        public decimal? BundlePrice { get; set; }

        [Required]
		[MaxLength(250)]
        [Display(Name = "Link")]
        public string BundleLink { get; set; }
        
        [Required]
		[MaxLength(250)]
        [Display(Name = "Product 1")]
        public string ProductName1 { get; set; }

        [MaxLength(250)]
        [Display(Name = "Product 2")]
        public string ProductName2 { get; set; }

        [MaxLength(250)]
        [Display(Name = "Product 3")]
        public string ProductName3 { get; set; }

		public string Wishlist { get; set; }
		public string RemoveDetails { get; set; }

        [Required]
		[MaxLength(250)]
        [Display(Name = "Desc 1")]
		public string MiniD1 {get; set; }

        [MaxLength(250)]
        [Display(Name = "Desc 2")]
        public string MiniD2 { get; set; }

        [MaxLength(250)]
        [Display(Name = "Desc 3")]
        public string MiniD3 { get; set; }

        [MaxLength(250)]
        [Display(Name = "Desc 4")]
        public string MiniD4 { get; set; }

        [MaxLength(250)]
        [Display(Name = "Desc 5")]
        public string MiniD5 { get; set; }

        [MaxLength(250)]
        [Display(Name = "Desc 6")]
        public string MiniD6 { get; set; }

		[MaxLength(250)]
        [Display(Name = "Desc 7")]
        public string MiniD7 { get; set; }

        [MaxLength(250)]
        [Display(Name = "Desc 8")]
        public string MiniD8{ get; set; }

        [MaxLength(250)]
        [Display(Name = "Desc 9")]
        public string MiniD9 { get; set; }
	}
}
