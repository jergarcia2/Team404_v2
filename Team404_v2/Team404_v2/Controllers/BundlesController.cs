using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Team404_v2.Models;

namespace Team404_v2.Controllers
{
    public class BundlesController : Controller
    {
        // GET: Bundles
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Beginner()
        {
			//BeginnerVM model = new BeginnerVM();
			//BeginnerBundles Bundle1 = new BeginnerBundles();
			//Bundle1.BundleTitle = "Rockstar Bundle";
			//Bundle1.BundleLink = "View Bundle Details";
			//Bundle1.Wishlist = "Add to Wishlist";
			//Bundle1.RemoveDetails = "Hide Details";
			//Bundle1.BundlePrice = 514.97;
			//Bundle1.ProductName1 = "i5-7600K";
			//Bundle1.ProductName2 = "ASRock MB";
			//Bundle1.ProductName3 = "16GB";
			//Bundle1.MiniDescription1.Add("for product one");
			//Bundle1.MiniDescription1.Add("for product one");
			//Bundle1.MiniDescription1.Add("for product one");
			//Bundle1.MiniDescription2.Add("for product two");
			//Bundle1.MiniDescription2.Add("for product two");
			//Bundle1.MiniDescription2.Add("for product two");
			//Bundle1.MiniDescription3.Add("for product three");
			//Bundle1.MiniDescription3.Add("for product three");
			//Bundle1.MiniDescription3.Add("for product three");
			//model.BeginnerItems.Add(Bundle1);

			//return View(model);

			var model = new BeginnerVM();
			var ctx = new MyModel();
			foreach (var item in ctx.BeginnerBundles)
			{
				model.BeginnerBundles.Add(item);
			}

			return View(model);
		}

        public ActionResult MidGrade()
        {
			//MidGradeVM model = new MidGradeVM();
			//MidGradeBundles Bundle1 = new MidGradeBundles();
			//Bundle1.BundleTitle = "Rockstar Bundle";
			//Bundle1.BundleLink = "View Bundle Details";
			//Bundle1.Wishlist = "Add to Wishlist";
			//Bundle1.RemoveDetails = "Hide Details";
			//Bundle1.BundlePrice = 514.97;
			//Bundle1.ProductName1 = "i5-7600K";
			//Bundle1.ProductName2 = "ASRock MB";
			//Bundle1.ProductName3 = "16GB";
			//Bundle1.MiniDescription1.Add("for product one");
			//Bundle1.MiniDescription1.Add("for product one");
			//Bundle1.MiniDescription1.Add("for product one");
			//Bundle1.MiniDescription2.Add("for product two");
			//Bundle1.MiniDescription2.Add("for product two");
			//Bundle1.MiniDescription2.Add("for product two");
			//Bundle1.MiniDescription3.Add("for product three");
			//Bundle1.MiniDescription3.Add("for product three");
			//Bundle1.MiniDescription3.Add("for product three");

			//model.MidGradeItems.Add(Bundle1);

			//return View(model);

			var model = new MidGradeVM();
			var ctx = new MyModel();
			foreach (var item in ctx.MidGradeBundles)
			{
				model.MidGradeBundles.Add(item);
			}

			return View(model);
		}

        public ActionResult Professional()
        {
			//ProfessionalVM model = new ProfessionalVM();
			//ProfessionalBundles Bundle1 = new ProfessionalBundles();
			//Bundle1.BundleTitle = "Rockstar Bundle";
			//Bundle1.BundleLink = "View Bundle Details";
			//Bundle1.Wishlist = "Add to Wishlist";
			//Bundle1.RemoveDetails = "Hide Details";
			//Bundle1.BundlePrice = 514.97;
			//Bundle1.ProductName1 = "i5-7600K";
			//Bundle1.ProductName2 = "ASRock MB";
			//Bundle1.ProductName3 = "16GB";
			//Bundle1.MiniDescription1.Add("for product one");
			//Bundle1.MiniDescription1.Add("for product one");
			//Bundle1.MiniDescription1.Add("for product one");
			//Bundle1.MiniDescription2.Add("for product two");
			//Bundle1.MiniDescription2.Add("for product two");
			//Bundle1.MiniDescription2.Add("for product two");
			//Bundle1.MiniDescription3.Add("for product three");
			//Bundle1.MiniDescription3.Add("for product three");
			//Bundle1.MiniDescription3.Add("for product three");
			//model.ProfessionalItems.Add(Bundle1);

			//return View(model);

			var model = new ProfessionalVM();
			var ctx = new MyModel();
			foreach (var item in ctx.ProfessionalBundles)
			{
				model.ProfessionalBundles.Add(item);
			}

			return View(model);
		}
    }
}