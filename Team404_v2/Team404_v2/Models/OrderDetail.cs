using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Team404_v2.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual Products Product { get; set; }
        public virtual Order Order { get; set; }
    }
}