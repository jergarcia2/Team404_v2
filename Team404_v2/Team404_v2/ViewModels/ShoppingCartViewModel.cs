using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Team404_v2.Models;

namespace Team404_v2.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Wishlist> WishlistItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}