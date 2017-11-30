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
			//CoolingSystemsVM model = new CoolingSystemsVM();
			//CPCoolingSystems Item1 = new CPCoolingSystems();
			//Item1.ItemTitle = "Item 1 Title Goes Here";
			//Item1.ItemLink = "View Item Details";
			//Item1.MiniDescription.Add("UPC:xxxxxxxxx");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//model.PCCoolingSystems.Add(Item1);

			//return View(model);
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

			
			//MemoryVM model = new MemoryVM();
			//CPMemory Item1 = new CPMemory();
			//Item1.ItemTitle = "Item 1 Title Goes Here";
			//Item1.ItemLink = "View Item Details";
			//Item1.MiniDescription.Add("UPC:xxxxxxxxx");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//model.MemoryItems.Add(Item1);

			return View(model);
        }

        public ActionResult Motherboards()
        {
			//MotherboardVM model = new MotherboardVM();
			//CPMotherboard Item1 = new CPMotherboard();
			//Item1.ItemTitle = "Item 1 Title Goes Here";
			//Item1.ItemLink = "View Item Details";
			//Item1.MiniDescription.Add("UPC:xxxxxxxxx");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//Item1.MiniDescription.Add("Bullet goes here");
			//model.CPMotherboard.Add(Item1);

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
	}
}