using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Team404_v2.Models
{
    public partial class ShoppingCart
    {
        MyModel storeDB = new MyModel();
        string ShoppingCartId { get; set; }
        public const string CartSessionKey = "CartId";
        public static ShoppingCart GetCart(HttpContextBase context)
        {
            var wishlist = new ShoppingCart();
            wishlist.ShoppingCartId = wishlist.GetCartId(context);
            return wishlist;
        }
        // Helper method to simplify shopping cart calls
        public static ShoppingCart GetCart(Controller controller)
        {
            return GetCart(controller.HttpContext);
        }
        public void AddToCart(Products product)
        {
            // Get the matching cart and album instances
            var wishlistItem = storeDB.Wishlists.SingleOrDefault(
                c => c.WishlistId == ShoppingCartId
                && c.ProductId == product.ProductId);

            if (wishlistItem == null)
            {
                // Create a new cart item if no cart item exists
                wishlistItem = new Wishlist
                {
                    ProductId = product.ProductId,
                    WishlistId = ShoppingCartId,
                    Count = 1,
                    DateCreated = DateTime.Now
                };
                storeDB.Wishlists.Add(wishlistItem);
            }
            else
            {
                // If the item does exist in the cart, 
                // then add one to the quantity
                wishlistItem.Count++;
            }
            // Save changes
            storeDB.SaveChanges();
        }
        public int RemoveFromCart(int id)
        {
            // Get the cart
            var wishlistItem = storeDB.Wishlists.Single(
                wishlist => wishlist.WishlistId == ShoppingCartId
                && wishlist.RecordId == id);

            int itemCount = 0;

            if (wishlistItem != null)
            {
                if (wishlistItem.Count > 1)
                {
                    wishlistItem.Count--;
                    itemCount = wishlistItem.Count;
                }
                else
                {
                    storeDB.Wishlists.Remove(wishlistItem);
                }
                // Save changes
                storeDB.SaveChanges();
            }
            return itemCount;
        }
        public void EmptyCart()
        {
            var wishlistItems = storeDB.Wishlists.Where(
                wishlist => wishlist.WishlistId == ShoppingCartId);

            foreach (var wishlistItem in wishlistItems)
            {
                storeDB.Wishlists.Remove(wishlistItem);
            }
            // Save changes
            storeDB.SaveChanges();
        }
        public List<Wishlist> GetCartItems()
        {
            return storeDB.Wishlists.Where(
                wishlist => wishlist.WishlistId == ShoppingCartId).ToList();
        }
        public int GetCount()
        {
            // Get the count of each item in the cart and sum them up
            int? count = (from wishlistItems in storeDB.Wishlists
                          where wishlistItems.WishlistId == ShoppingCartId
                          select (int?)wishlistItems.Count).Sum();
            // Return 0 if all entries are null
            return count ?? 0;
        }
        public decimal GetTotal()
        {
            // Multiply album price by count of that album to get 
            // the current price for each of those albums in the cart
            // sum all album price totals to get the cart total
            decimal? total = (from wishlistItems in storeDB.Wishlists
                              where wishlistItems.WishlistId == ShoppingCartId
                              select (int?)wishlistItems.Count *
                              (wishlistItems.Product.ItemPrice + wishlistItems.Product.ItemPrice2)).Sum();

            return total ?? decimal.Zero;
        }
        public int CreateOrder(Order order)
        {
            decimal orderTotal = 0;

            var wishlistItems = GetCartItems();
            // Iterate over the items in the cart, 
            // adding the order details for each
            foreach (var item in wishlistItems)
            {
                var orderDetail = new OrderDetail
                {
                    ProductId = item.ProductId,
                    OrderId = order.OrderId,
                    UnitPrice = item.Product.ItemPrice + item.Product.ItemPrice2,
                    Quantity = item.Count
                };
                // Set the order total of the shopping cart
                orderTotal += (item.Count * (item.Product.ItemPrice + item.Product.ItemPrice2));

                storeDB.OrderDetails.Add(orderDetail);

            }
            // Set the order's total to the orderTotal count
            order.Total = orderTotal;

            // Save the order
            storeDB.SaveChanges();
            // Empty the shopping cart
            EmptyCart();
            // Return the OrderId as the confirmation number
            return order.OrderId;
        }
        // We're using HttpContextBase to allow access to cookies.
        public string GetCartId(HttpContextBase context)
        {
            if (context.Session[CartSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(context.User.Identity.Name))
                {
                    context.Session[CartSessionKey] =
                        context.User.Identity.Name;
                }
                else
                {
                    // Generate a new random GUID using System.Guid class
                    Guid tempCartId = Guid.NewGuid();
                    // Send tempCartId back to client as a cookie
                    context.Session[CartSessionKey] = tempCartId.ToString();
                }
            }
            return context.Session[CartSessionKey].ToString();
        }
        // When a user has logged in, migrate their shopping cart to
        // be associated with their username
        public void MigrateCart(string userName)
        {
            var shoppingCart = storeDB.Wishlists.Where(
                c => c.WishlistId == ShoppingCartId);

            foreach (Wishlist item in shoppingCart)
            {
                item.WishlistId = userName;
            }
            storeDB.SaveChanges();
        }
    }
}