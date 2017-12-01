using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Team404_v2.Models;
using Team404_v2.ViewModels;

namespace Team404_v2
{
    public class WishlistsController : Controller
    {
        private MyModel storeDB = new MyModel();

        // GET: Wishlists
        public ActionResult Index()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);

            // Set up our ViewModel
            var viewModel = new ShoppingCartViewModel
            {
                WishlistItems = cart.GetCartItems(),
                CartTotal = cart.GetTotal()
            };
            // Return the view
            return View(viewModel);
        }

        // GET: Wishlists/AddToWishlist/5
        public ActionResult AddToWishlist(int? id)
        {
            // Retrieve the album from the database
            var addedProduct = storeDB.Products
                .Single(product => product.ProductId == id);

            // Add it to the shopping cart
            var wishlist = ShoppingCart.GetCart(this.HttpContext);

            wishlist.AddToCart(addedProduct);

            // Go back to the main store page for more shopping
            return RedirectToAction("Index");
        }

        //
        // AJAX: /Wishlist/RemoveFromList/5
        [HttpPost]
        public ActionResult RemoveFromList(int id)
        {
            // Remove the item from the cart
            var wishlist = ShoppingCart.GetCart(this.HttpContext);

            // Get the name of the album to display confirmation
            string productName = storeDB.Wishlists
                .Single(item => item.RecordId == id).Product.ItemTitle;

            // Remove from cart
            int itemCount = wishlist.RemoveFromCart(id);

            // Display the confirmation message
            var results = new ShoppingCartRemoveViewModel
            {
                Message = Server.HtmlEncode(productName) +
                    " has been removed from your shopping cart.",
                CartTotal = wishlist.GetTotal(),
                CartCount = wishlist.GetCount(),
                ItemCount = itemCount,
                DeleteId = id
            };
            return Json(results);
        }

        //
        // GET: /Wishlist/ListSummary
        [ChildActionOnly]
        public ActionResult ListSummary()
        {
            var wishlist = ShoppingCart.GetCart(this.HttpContext);

            ViewData["CartCount"] = wishlist.GetCount();
            return PartialView("CartSummary");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                storeDB.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
