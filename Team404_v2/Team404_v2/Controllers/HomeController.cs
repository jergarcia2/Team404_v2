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
			var model = new WishlistVM();
			var ctx = new MyModel();
			foreach (var item in ctx.Wishlist)
			{
				model.Wishlist.Add(item);
			}

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