using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Team404_v2.Models
{
    public class Products
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        [Display(Name = "Item Title")]
        public string ItemTitle { get; set; }

        [Required]
        [MaxLength(250)]
        [Display(Name = "Mini Description")]
        public string MiniDescription { get; set; }

		public string MiniDescription2 { get; set; }

		public string MiniDescription3 { get; set; }
		[Required]
        [MaxLength(250)]
        [Display(Name = "Long Description")]
        public string LongDescription1 { get; set; }

		public string LongDescription2 { get; set; }
		public string LongDescription3 { get; set; }

		[Required]
        [MaxLength(250)]
        [Display(Name = "Item Link")]
        public string ItemLink { get; set; }

        [Required]
        [MaxLength(250)]
        [Display(Name = "Wishlist")]
        public List<Wishlist> Wishlist { get; set; }

        [Required]
        [MaxLength(250)]
        [Display(Name = "Price Name")]
        public string Price1Name { get; set; }

        [Required]
        [MaxLength(250)]
        [Display(Name = "Price Link")]
        public string Price1Link { get; set; }

        [MaxLength(250)]
        [Display(Name = "Price 2 Name")]
        public string Price2Name { get; set; }

        [MaxLength(250)]
        [Display(Name = "Price 2 Link")]
        public string Price2Link { get; set; }

        [MaxLength(250)]
        [Display(Name = "Price 3 Link")]
        public string Price3Link { get; set; }

        [MaxLength(250)]
        [Display(Name = "Price 3 Name")]
        public string Price3Name { get; set; }

        [Required]
        [Display(Name = "Item Price")]
        public decimal? ItemPrice { get; set; }

        [Display(Name = "Item 2 Price")]
        public decimal? ItemPrice2 { get; set; }

        [Required]
        [MaxLength(250)]
        [Display(Name = "Remove Details")]
        public string RemoveDetails { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Category")]
        public string Category { get; set; }
    }
}