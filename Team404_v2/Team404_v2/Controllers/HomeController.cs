using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Team404_v2.Models;

namespace Team404_v2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WishList()
        {
            WishlistVM model = new WishlistVM();
            Wishlist Item1 = new Wishlist();
            Wishlist Item2 = new Wishlist();
            Item1.ItemNames = "Product 1";
            Item1.LinkRemove = "Delete";
            Item1.Undo = "Undo";
            Item1.Prices1 = 80;
            Item1.Prices2 = 75;
            Item1.Prices3 = 70;
            model.ListItems.Add(Item1);
            Item2.ItemNames = "Product 2";
            Item2.LinkRemove = "Delete";
            Item2.Undo = "Undo";
            Item2.Prices1 = 80;
            Item2.Prices2 = 75;
            Item2.Prices3 = 70;
            model.ListItems.Add(Item2);

            return View(model);
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost] //Processed when calling the 'Post' method
        public ActionResult Contact(ContactFM formModel)
        {
            //Validate Form Data
            if (string.IsNullOrWhiteSpace(formModel.ContactMessage))
            {
                return View();
            }
            return Redirect("ContactResponse");
        }

        public ActionResult ContactResponse()
        {
            return View();
        }
    }
}