using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Team404_v2.Models;

namespace Team404_v2.Controllers
{
    public class ComputerPartsController : Controller
    {
        // GET: ComputerParts
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cases()
        {
            var model = new ProductVM();

            var ctx = new MyModel();
            foreach (var item in ctx.Products)
            {
                model.Products.Add(item);
            }

            return View(model);
        }

        public ActionResult CoolingSystems()
        {
			var model = new ProductVM();
			var ctx = new MyModel();
			foreach (var item in ctx.Products)
			{
				model.Products.Add(item);
			}

			return View(model);

		}


        public ActionResult Memory()
        {
			var model = new ProductVM();
			var ctx = new MyModel();
			foreach (var item in ctx.Products)
			{
				model.Products.Add(item);
			}

			return View(model);
        }

        public ActionResult Motherboards()
        {
			var model = new ProductVM();
			var ctx = new MyModel();
			foreach (var item in ctx.Products)
			{
				model.Products.Add(item);
			}

			return View(model);
		}

		public ActionResult PowerSupply()
        {
			var model = new ProductVM();
			var ctx = new MyModel();
			foreach (var item in ctx.Products)
			{
				model.Products.Add(item);
			}

			return View(model);

		}

        public ActionResult Processors()
        {
			var model = new ProductVM();
			var ctx = new MyModel();
			foreach (var item in ctx.Products)
			{
				model.Products.Add(item);
			}

			return View(model);
		}

		public ActionResult SoundCards()
        {
			var model = new ProductVM();
			var ctx = new MyModel();
			foreach (var item in ctx.Products)
			{
				model.Products.Add(item);
			}

			return View(model);

		}

        public ActionResult VideoCards()
        {
			var model = new ProductVM();
			var ctx = new MyModel();
			foreach (var item in ctx.Products)
			{
				model.Products.Add(item);
			}

			return View(model);
		}

        public ActionResult Prods (string prodSearch, Products product)
        {
            MyModel db = new MyModel();

            var products = db.Products.Where(x => x.Category.Contains(prodSearch));

            if (ModelState.IsValid)
            {
                return View(products);
            }

            return View();
        }
	}
}