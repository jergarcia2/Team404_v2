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
        [Display(Name = "Mini D1")]
        public string MiniDescription { get; set; }

        [MaxLength(250)]
        [Display(Name = "Mini D2")]
        public string MiniDescription2 { get; set; }

        [MaxLength(250)]
        [Display(Name = "Mini D3")]
        public string MiniDescription3 { get; set; }

        [Required]
        [MaxLength(250)]
<<<<<<< HEAD
        [Display(Name = "Long Description")]
        public string LongDescription1 { get; set; }
=======
        [Display(Name = "Long D1")]
        public string LongDescription1 { get; set; }

        [MaxLength(250)]
        [Display(Name = "Long D2")]
        public string LongDescription2 { get; set; }

        [MaxLength(250)]
        [Display(Name = "Long D3")]
        public string LongDescription3 { get; set; }
>>>>>>> jeremylocal

        [Required]
        [MaxLength(250)]
        [Display(Name = "Item Link")]
        public string ItemLink { get; set; }

        [MaxLength(250)]
        [Display(Name = "Wishlist")]
        public List<Wishlist> Wishlist { get; set; }

        [Required]
        [MaxLength(250)]
        [Display(Name = "P1 Name")]
        public string Price1Name { get; set; }

        [Required]
        [MaxLength(250)]
        [Display(Name = "P1 Link")]
        public string Price1Link { get; set; }

        [MaxLength(250)]
        [Display(Name = "P2 Name")]
        public string Price2Name { get; set; }

        [MaxLength(250)]
        [Display(Name = "P2 Link")]
        public string Price2Link { get; set; }

        [MaxLength(250)]
        [Display(Name = "P3 Name")]
        public string Price3Name { get; set; }

        [MaxLength(250)]
        [Display(Name = "P3 Link")]
        public string Price3Link { get; set; }

        [Required]
        [Display(Name = "Item 1$")]
        public decimal? ItemPrice { get; set; }

        [Display(Name = "Item 2$")]
        public decimal? ItemPrice2 { get; set; }

        [MaxLength(250)]
        [Display(Name = "Rm Details")]
        public string RemoveDetails { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Category")]
        public string Category { get; set; }
    }
}